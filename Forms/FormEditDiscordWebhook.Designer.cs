﻿namespace PlenBotLogUploader
{
    partial class FormEditDiscordWebhook
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelName = new System.Windows.Forms.Label();
            this.labelUrl = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxUrl = new System.Windows.Forms.TextBox();
            this.checkBoxPlayers = new System.Windows.Forms.CheckBox();
            this.checkedListBoxBossesEnable = new System.Windows.Forms.CheckedListBox();
            this.groupBoxWebhookInfo = new System.Windows.Forms.GroupBox();
            this.groupBoxBossesEnable = new System.Windows.Forms.GroupBox();
            this.buttonUnSelectAllGolems = new System.Windows.Forms.Button();
            this.buttonUnSelectWvW = new System.Windows.Forms.Button();
            this.buttonUnSelectAllFractals = new System.Windows.Forms.Button();
            this.buttonUnSelectAllStrikes = new System.Windows.Forms.Button();
            this.buttonUnSelectAllRaids = new System.Windows.Forms.Button();
            this.buttonUnSelectAll = new System.Windows.Forms.Button();
            this.groupBoxConditionalPost = new System.Windows.Forms.GroupBox();
            this.radioButtonOnlySuccessAndFail = new System.Windows.Forms.RadioButton();
            this.radioButtonOnlyFail = new System.Windows.Forms.RadioButton();
            this.radioButtonOnlySuccess = new System.Windows.Forms.RadioButton();
            this.groupBoxWebhookTeam = new System.Windows.Forms.GroupBox();
            this.comboBoxWebhookTeam = new System.Windows.Forms.ComboBox();
            this.groupBoxWebhookInfo.SuspendLayout();
            this.groupBoxBossesEnable.SuspendLayout();
            this.groupBoxConditionalPost.SuspendLayout();
            this.groupBoxWebhookTeam.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(6, 16);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(86, 13);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Webhook name:";
            // 
            // labelUrl
            // 
            this.labelUrl.AutoSize = true;
            this.labelUrl.Location = new System.Drawing.Point(6, 55);
            this.labelUrl.Name = "labelUrl";
            this.labelUrl.Size = new System.Drawing.Size(82, 13);
            this.labelUrl.TabIndex = 1;
            this.labelUrl.Text = "Webhook URL:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(9, 32);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(377, 20);
            this.textBoxName.TabIndex = 2;
            // 
            // textBoxUrl
            // 
            this.textBoxUrl.Location = new System.Drawing.Point(9, 71);
            this.textBoxUrl.Name = "textBoxUrl";
            this.textBoxUrl.Size = new System.Drawing.Size(377, 20);
            this.textBoxUrl.TabIndex = 3;
            // 
            // checkBoxPlayers
            // 
            this.checkBoxPlayers.AutoSize = true;
            this.checkBoxPlayers.Location = new System.Drawing.Point(9, 97);
            this.checkBoxPlayers.Name = "checkBoxPlayers";
            this.checkBoxPlayers.Size = new System.Drawing.Size(354, 17);
            this.checkBoxPlayers.TabIndex = 5;
            this.checkBoxPlayers.Text = "Show detailed information about players and squad performance";
            this.checkBoxPlayers.UseVisualStyleBackColor = true;
            // 
            // checkedListBoxBossesEnable
            // 
            this.checkedListBoxBossesEnable.FormattingEnabled = true;
            this.checkedListBoxBossesEnable.Location = new System.Drawing.Point(6, 19);
            this.checkedListBoxBossesEnable.Name = "checkedListBoxBossesEnable";
            this.checkedListBoxBossesEnable.Size = new System.Drawing.Size(380, 214);
            this.checkedListBoxBossesEnable.TabIndex = 6;
            // 
            // groupBoxWebhookInfo
            // 
            this.groupBoxWebhookInfo.Controls.Add(this.textBoxName);
            this.groupBoxWebhookInfo.Controls.Add(this.labelName);
            this.groupBoxWebhookInfo.Controls.Add(this.labelUrl);
            this.groupBoxWebhookInfo.Controls.Add(this.checkBoxPlayers);
            this.groupBoxWebhookInfo.Controls.Add(this.textBoxUrl);
            this.groupBoxWebhookInfo.Location = new System.Drawing.Point(12, 12);
            this.groupBoxWebhookInfo.Name = "groupBoxWebhookInfo";
            this.groupBoxWebhookInfo.Size = new System.Drawing.Size(392, 121);
            this.groupBoxWebhookInfo.TabIndex = 7;
            this.groupBoxWebhookInfo.TabStop = false;
            this.groupBoxWebhookInfo.Text = "Webhook info";
            // 
            // groupBoxBossesEnable
            // 
            this.groupBoxBossesEnable.Controls.Add(this.buttonUnSelectAllGolems);
            this.groupBoxBossesEnable.Controls.Add(this.buttonUnSelectWvW);
            this.groupBoxBossesEnable.Controls.Add(this.buttonUnSelectAllFractals);
            this.groupBoxBossesEnable.Controls.Add(this.buttonUnSelectAllStrikes);
            this.groupBoxBossesEnable.Controls.Add(this.buttonUnSelectAllRaids);
            this.groupBoxBossesEnable.Controls.Add(this.buttonUnSelectAll);
            this.groupBoxBossesEnable.Controls.Add(this.checkedListBoxBossesEnable);
            this.groupBoxBossesEnable.Location = new System.Drawing.Point(410, 12);
            this.groupBoxBossesEnable.Name = "groupBoxBossesEnable";
            this.groupBoxBossesEnable.Size = new System.Drawing.Size(392, 271);
            this.groupBoxBossesEnable.TabIndex = 8;
            this.groupBoxBossesEnable.TabStop = false;
            this.groupBoxBossesEnable.Text = "Only upload for selected bosses";
            // 
            // buttonUnSelectAllGolems
            // 
            this.buttonUnSelectAllGolems.Location = new System.Drawing.Point(272, 242);
            this.buttonUnSelectAllGolems.Name = "buttonUnSelectAllGolems";
            this.buttonUnSelectAllGolems.Size = new System.Drawing.Size(54, 23);
            this.buttonUnSelectAllGolems.TabIndex = 12;
            this.buttonUnSelectAllGolems.Text = "Golems";
            this.buttonUnSelectAllGolems.UseVisualStyleBackColor = true;
            this.buttonUnSelectAllGolems.Click += new System.EventHandler(this.ButtonUnSelectAllGolems_Click);
            // 
            // buttonUnSelectWvW
            // 
            this.buttonUnSelectWvW.Location = new System.Drawing.Point(332, 242);
            this.buttonUnSelectWvW.Name = "buttonUnSelectWvW";
            this.buttonUnSelectWvW.Size = new System.Drawing.Size(54, 23);
            this.buttonUnSelectWvW.TabIndex = 11;
            this.buttonUnSelectWvW.Text = "WvW";
            this.buttonUnSelectWvW.UseVisualStyleBackColor = true;
            this.buttonUnSelectWvW.Click += new System.EventHandler(this.ButtonUnSelectWvW_Click);
            // 
            // buttonUnSelectAllFractals
            // 
            this.buttonUnSelectAllFractals.Location = new System.Drawing.Point(153, 242);
            this.buttonUnSelectAllFractals.Name = "buttonUnSelectAllFractals";
            this.buttonUnSelectAllFractals.Size = new System.Drawing.Size(54, 23);
            this.buttonUnSelectAllFractals.TabIndex = 10;
            this.buttonUnSelectAllFractals.Text = "Fractals";
            this.buttonUnSelectAllFractals.UseVisualStyleBackColor = true;
            this.buttonUnSelectAllFractals.Click += new System.EventHandler(this.ButtonUnSelectAllFractals_Click);
            // 
            // buttonUnSelectAllStrikes
            // 
            this.buttonUnSelectAllStrikes.Location = new System.Drawing.Point(212, 242);
            this.buttonUnSelectAllStrikes.Name = "buttonUnSelectAllStrikes";
            this.buttonUnSelectAllStrikes.Size = new System.Drawing.Size(54, 23);
            this.buttonUnSelectAllStrikes.TabIndex = 9;
            this.buttonUnSelectAllStrikes.Text = "Strikes";
            this.buttonUnSelectAllStrikes.UseVisualStyleBackColor = true;
            this.buttonUnSelectAllStrikes.Click += new System.EventHandler(this.ButtonUnSelectAllStrikes_Click);
            // 
            // buttonUnSelectAllRaids
            // 
            this.buttonUnSelectAllRaids.Location = new System.Drawing.Point(93, 242);
            this.buttonUnSelectAllRaids.Name = "buttonUnSelectAllRaids";
            this.buttonUnSelectAllRaids.Size = new System.Drawing.Size(54, 23);
            this.buttonUnSelectAllRaids.TabIndex = 8;
            this.buttonUnSelectAllRaids.Text = "Raids";
            this.buttonUnSelectAllRaids.UseVisualStyleBackColor = true;
            this.buttonUnSelectAllRaids.Click += new System.EventHandler(this.ButtonUnSelectAllRaids_Click);
            // 
            // buttonUnSelectAll
            // 
            this.buttonUnSelectAll.Location = new System.Drawing.Point(6, 242);
            this.buttonUnSelectAll.Name = "buttonUnSelectAll";
            this.buttonUnSelectAll.Size = new System.Drawing.Size(81, 23);
            this.buttonUnSelectAll.TabIndex = 7;
            this.buttonUnSelectAll.Text = "(Un)Select all";
            this.buttonUnSelectAll.UseVisualStyleBackColor = true;
            this.buttonUnSelectAll.Click += new System.EventHandler(this.ButtonUnSelectAll_Click);
            // 
            // groupBoxConditionalPost
            // 
            this.groupBoxConditionalPost.Controls.Add(this.radioButtonOnlySuccessAndFail);
            this.groupBoxConditionalPost.Controls.Add(this.radioButtonOnlyFail);
            this.groupBoxConditionalPost.Controls.Add(this.radioButtonOnlySuccess);
            this.groupBoxConditionalPost.Location = new System.Drawing.Point(12, 150);
            this.groupBoxConditionalPost.Name = "groupBoxConditionalPost";
            this.groupBoxConditionalPost.Size = new System.Drawing.Size(392, 66);
            this.groupBoxConditionalPost.TabIndex = 9;
            this.groupBoxConditionalPost.TabStop = false;
            this.groupBoxConditionalPost.Text = "Use this Webhook if...";
            // 
            // radioButtonOnlySuccessAndFail
            // 
            this.radioButtonOnlySuccessAndFail.AutoSize = true;
            this.radioButtonOnlySuccessAndFail.Location = new System.Drawing.Point(9, 43);
            this.radioButtonOnlySuccessAndFail.Name = "radioButtonOnlySuccessAndFail";
            this.radioButtonOnlySuccessAndFail.Size = new System.Drawing.Size(215, 17);
            this.radioButtonOnlySuccessAndFail.TabIndex = 2;
            this.radioButtonOnlySuccessAndFail.TabStop = true;
            this.radioButtonOnlySuccessAndFail.Text = "the encounter is either success or failure";
            this.radioButtonOnlySuccessAndFail.UseVisualStyleBackColor = true;
            // 
            // radioButtonOnlyFail
            // 
            this.radioButtonOnlyFail.AutoSize = true;
            this.radioButtonOnlyFail.Location = new System.Drawing.Point(245, 19);
            this.radioButtonOnlyFail.Name = "radioButtonOnlyFail";
            this.radioButtonOnlyFail.Size = new System.Drawing.Size(141, 17);
            this.radioButtonOnlyFail.TabIndex = 1;
            this.radioButtonOnlyFail.TabStop = true;
            this.radioButtonOnlyFail.Text = "the encounter is a failure";
            this.radioButtonOnlyFail.UseVisualStyleBackColor = true;
            // 
            // radioButtonOnlySuccess
            // 
            this.radioButtonOnlySuccess.AutoSize = true;
            this.radioButtonOnlySuccess.Location = new System.Drawing.Point(9, 20);
            this.radioButtonOnlySuccess.Name = "radioButtonOnlySuccess";
            this.radioButtonOnlySuccess.Size = new System.Drawing.Size(152, 17);
            this.radioButtonOnlySuccess.TabIndex = 0;
            this.radioButtonOnlySuccess.TabStop = true;
            this.radioButtonOnlySuccess.Text = "the encounter is a success";
            this.radioButtonOnlySuccess.UseVisualStyleBackColor = true;
            // 
            // groupBoxWebhookTeam
            // 
            this.groupBoxWebhookTeam.Controls.Add(this.comboBoxWebhookTeam);
            this.groupBoxWebhookTeam.Location = new System.Drawing.Point(12, 235);
            this.groupBoxWebhookTeam.Name = "groupBoxWebhookTeam";
            this.groupBoxWebhookTeam.Size = new System.Drawing.Size(392, 48);
            this.groupBoxWebhookTeam.TabIndex = 7;
            this.groupBoxWebhookTeam.TabStop = false;
            this.groupBoxWebhookTeam.Text = "Associate with a player team";
            // 
            // comboBoxWebhookTeam
            // 
            this.comboBoxWebhookTeam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxWebhookTeam.FormattingEnabled = true;
            this.comboBoxWebhookTeam.Location = new System.Drawing.Point(9, 19);
            this.comboBoxWebhookTeam.MaxDropDownItems = 100;
            this.comboBoxWebhookTeam.Name = "comboBoxWebhookTeam";
            this.comboBoxWebhookTeam.Size = new System.Drawing.Size(377, 21);
            this.comboBoxWebhookTeam.TabIndex = 0;
            // 
            // FormEditDiscordWebhook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(813, 291);
            this.Controls.Add(this.groupBoxWebhookTeam);
            this.Controls.Add(this.groupBoxConditionalPost);
            this.Controls.Add(this.groupBoxBossesEnable);
            this.Controls.Add(this.groupBoxWebhookInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEditDiscordWebhook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormEditDiscordWebhook";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormEditDiscordWebhook_FormClosing);
            this.groupBoxWebhookInfo.ResumeLayout(false);
            this.groupBoxWebhookInfo.PerformLayout();
            this.groupBoxBossesEnable.ResumeLayout(false);
            this.groupBoxConditionalPost.ResumeLayout(false);
            this.groupBoxConditionalPost.PerformLayout();
            this.groupBoxWebhookTeam.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelUrl;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxUrl;
        private System.Windows.Forms.CheckBox checkBoxPlayers;
        private System.Windows.Forms.CheckedListBox checkedListBoxBossesEnable;
        private System.Windows.Forms.GroupBox groupBoxWebhookInfo;
        private System.Windows.Forms.GroupBox groupBoxBossesEnable;
        private System.Windows.Forms.GroupBox groupBoxConditionalPost;
        private System.Windows.Forms.RadioButton radioButtonOnlySuccessAndFail;
        private System.Windows.Forms.RadioButton radioButtonOnlyFail;
        private System.Windows.Forms.RadioButton radioButtonOnlySuccess;
        private System.Windows.Forms.GroupBox groupBoxWebhookTeam;
        private System.Windows.Forms.ComboBox comboBoxWebhookTeam;
        private System.Windows.Forms.Button buttonUnSelectAll;
        private System.Windows.Forms.Button buttonUnSelectWvW;
        private System.Windows.Forms.Button buttonUnSelectAllFractals;
        private System.Windows.Forms.Button buttonUnSelectAllStrikes;
        private System.Windows.Forms.Button buttonUnSelectAllRaids;
        private System.Windows.Forms.Button buttonUnSelectAllGolems;
    }
}