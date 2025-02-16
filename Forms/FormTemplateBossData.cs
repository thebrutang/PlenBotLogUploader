﻿using PlenBotLogUploader.AppSettings;
using PlenBotLogUploader.DPSReport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PlenBotLogUploader
{
    public partial class FormTemplateBossData : Form
    {
        #region definitions
        // fields
        private readonly IDictionary<int, BossData> allBosses = Bosses.All;
        #endregion

        public FormTemplateBossData()
        {
            InitializeComponent();
            Icon = Properties.Resources.AppIcon;
            textBoxSuccessMessage.Text = ApplicationSettings.Current.BossTemplate.SuccessText;
            textBoxFailMessage.Text = ApplicationSettings.Current.BossTemplate.FailText;
        }

        private void FormTemplateBossData_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
            ApplicationSettings.Current.BossTemplate.SuccessText = textBoxSuccessMessage.Text;
            ApplicationSettings.Current.BossTemplate.FailText = textBoxFailMessage.Text;
            ApplicationSettings.Current.Save();
        }

        private void ButtonSuccessSave_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show($"This will change all non-golem, non-wvw, non-event Twitch message on success to \"{textBoxSuccessMessage.Text}\".\nAre you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result.Equals(DialogResult.Yes))
            {
                var BossesToChange = allBosses
                    .Where(x => !x.Value.Type.Equals(BossType.Golem))
                    .Where(x => !x.Value.Type.Equals(BossType.WvW))
                    .Where(x => !x.Value.Event)
                    .ToDictionary(x => x.Key, x => x.Value);
                foreach (var key in BossesToChange.Keys)
                {
                    var boss = allBosses[key];
                    boss.SuccessMsg = textBoxSuccessMessage.Text;
                }
                MessageBox.Show("All changes are saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ButtonFailSave_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show($"This will change all non-golem, non-wvw, non-event Twitch message on fail to \"{textBoxFailMessage.Text}\".\nAre you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result.Equals(DialogResult.Yes))
            {
                var BossesToChange = allBosses
                    .Where(x => !x.Value.Type.Equals(BossType.Golem))
                    .Where(x => !x.Value.Type.Equals(BossType.WvW))
                    .Where(x => !x.Value.Event)
                    .ToDictionary(x => x.Key, x => x.Value);
                foreach (var key in BossesToChange.Keys)
                {
                    var boss = allBosses[key];
                    boss.FailMsg = textBoxFailMessage.Text;
                }
                MessageBox.Show("All changes are saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
