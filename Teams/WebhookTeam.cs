﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PlenBotLogUploader.Teams
{
    public class WebhookTeam
    {
        /// <summary>
        /// ID of the team, for internal use
        /// </summary>
        [JsonProperty("id")]
        public int ID { get; set; }

        /// <summary>
        /// Name of the webhook team
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// What limiter to the team should be applied
        /// </summary>
        [JsonProperty("limiter")]
        public WebhookTeamLimiter Limiter { get; set; }

        /// <summary>
        /// What value for the limiter should be applied
        /// </summary>
        [JsonProperty("limiterValue")]
        public int LimiterValue { get; set; }

        /// <summary>
        /// List of account names in the given team
        /// </summary>
        [JsonProperty("accountNames")]
        public List<string> AccountNames { get; set; } = new List<string>();

        /// <summary>
        /// Returns a string that represents the current object.
        /// </summary>
        /// <returns>A string that represents the current object.</returns>
        public override string ToString() => Name;

        public bool IsSatisfied(Dictionary<string, DPSReport.DPSReportJSONPlayers> players)
        {
            var sumOfTeamMembers = AccountNames.Select(x => players.Values.Where(y => y.DisplayName.Equals(x)).Count()).Sum();
            if (Limiter.Equals(WebhookTeamLimiter.Exact))
            {
                return sumOfTeamMembers == LimiterValue;
            }
            else if (Limiter.Equals(WebhookTeamLimiter.Except))
            {
                return sumOfTeamMembers == 0;
            }
            // min
            return sumOfTeamMembers >= LimiterValue;
        }

        /// <summary>
        /// Creates an WebhookTeam object from a serialised format.
        /// </summary>
        /// <param name="savedFormat">string representing the object</param>
        /// <returns>deserilised object of WebhookTeam type</returns>
        public static WebhookTeam FromSavedFormat(string serialisedFormat)
        {
            try
            {
                var values = serialisedFormat.Split(new string[] { "<;>" }, StringSplitOptions.None);
                int.TryParse(values[0], out int id);
                int.TryParse(values[2], out int limiter);
                int.TryParse(values[3], out int limiterValue);
                var accountNames = values[4].Split(new string[] { ";" }, StringSplitOptions.None).ToList();
                return new WebhookTeam()
                {
                    ID = id,
                    Name = values[1],
                    Limiter = (WebhookTeamLimiter)limiter,
                    LimiterValue = limiterValue,
                    AccountNames = accountNames
                };
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public static IDictionary<int, WebhookTeam> FromJsonString(string jsonData)
        {
            var parsedData = JsonConvert.DeserializeObject<IEnumerable<WebhookTeam>>(jsonData)
                             ?? throw new JsonException("Could not parse json to WebhookData");
            
            var result = parsedData.Select(x => (Key: x.ID, TeamWebhookData: x))
                .ToDictionary(x => x.Key, x => x.TeamWebhookData);

            return result;
        }
        
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;
            return Equals((WebhookTeam) obj);
        }

        protected bool Equals(WebhookTeam other)
        {
            return (ID == other.ID) && (Name == other.Name);
        }
        
        public override int GetHashCode()
        {
            unchecked
            {
                return (ID * 397) ^ (Name != null ? Name.GetHashCode() : 0);
            }
        }
    }
}
