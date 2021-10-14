﻿namespace PlenBotLogUploader
{
    partial class FormPings
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
            this.components = new System.ComponentModel.Container();
            this.listViewPings = new System.Windows.Forms.ListView();
            this.contextMenuStripInteract = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemTest = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonAddNew = new System.Windows.Forms.Button();
            this.labelInformation = new System.Windows.Forms.Label();
            this.contextMenuStripInteract.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewPings
            // 
            this.listViewPings.CheckBoxes = true;
            this.listViewPings.ContextMenuStrip = this.contextMenuStripInteract;
            this.listViewPings.HideSelection = false;
            this.listViewPings.Location = new System.Drawing.Point(12, 12);
            this.listViewPings.MultiSelect = false;
            this.listViewPings.Name = "listViewPings";
            this.listViewPings.Size = new System.Drawing.Size(561, 252);
            this.listViewPings.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listViewPings.TabIndex = 0;
            this.listViewPings.UseCompatibleStateImageBehavior = false;
            this.listViewPings.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.ListViewDiscordWebhooks_ItemChecked);
            // 
            // contextMenuStripInteract
            // 
            this.contextMenuStripInteract.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemEdit,
            this.toolStripMenuItemTest,
            this.toolStripMenuItemDelete,
            this.toolStripSeparator1,
            this.toolStripMenuItemAdd});
            this.contextMenuStripInteract.Name = "contextMenuStripInteract";
            this.contextMenuStripInteract.Size = new System.Drawing.Size(229, 98);
            this.contextMenuStripInteract.Opening += new System.ComponentModel.CancelEventHandler(this.ContextMenuStripInteract_Opening);
            // 
            // toolStripMenuItemEdit
            // 
            this.toolStripMenuItemEdit.Name = "toolStripMenuItemEdit";
            this.toolStripMenuItemEdit.Size = new System.Drawing.Size(228, 22);
            this.toolStripMenuItemEdit.Text = "Edit selected configuration";
            this.toolStripMenuItemEdit.Click += new System.EventHandler(this.ToolStripMenuItemEdit_Click);
            // 
            // toolStripMenuItemTest
            // 
            this.toolStripMenuItemTest.Name = "toolStripMenuItemTest";
            this.toolStripMenuItemTest.Size = new System.Drawing.Size(228, 22);
            this.toolStripMenuItemTest.Text = "Test selected configuration";
            this.toolStripMenuItemTest.Click += new System.EventHandler(this.ToolStripMenuItemTest_Click);
            // 
            // toolStripMenuItemDelete
            // 
            this.toolStripMenuItemDelete.Name = "toolStripMenuItemDelete";
            this.toolStripMenuItemDelete.Size = new System.Drawing.Size(228, 22);
            this.toolStripMenuItemDelete.Text = "Delete selected configuration";
            this.toolStripMenuItemDelete.Click += new System.EventHandler(this.ToolStripMenuItemDelete_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(225, 6);
            // 
            // toolStripMenuItemAdd
            // 
            this.toolStripMenuItemAdd.Name = "toolStripMenuItemAdd";
            this.toolStripMenuItemAdd.Size = new System.Drawing.Size(228, 22);
            this.toolStripMenuItemAdd.Text = "Add new ping configuration";
            this.toolStripMenuItemAdd.Click += new System.EventHandler(this.ToolStripMenuItemAdd_Click);
            // 
            // buttonAddNew
            // 
            this.buttonAddNew.Location = new System.Drawing.Point(425, 270);
            this.buttonAddNew.Name = "buttonAddNew";
            this.buttonAddNew.Size = new System.Drawing.Size(148, 23);
            this.buttonAddNew.TabIndex = 1;
            this.buttonAddNew.Text = "Add new ping configuration";
            this.buttonAddNew.UseVisualStyleBackColor = true;
            this.buttonAddNew.Click += new System.EventHandler(this.ButtonAddNew_Click);
            // 
            // labelInformation
            // 
            this.labelInformation.AutoSize = true;
            this.labelInformation.Location = new System.Drawing.Point(12, 275);
            this.labelInformation.Name = "labelInformation";
            this.labelInformation.Size = new System.Drawing.Size(295, 13);
            this.labelInformation.TabIndex = 2;
            this.labelInformation.Text = "You can right click the box window to bring up context menu.";
            // 
            // FormPings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(585, 301);
            this.Controls.Add(this.labelInformation);
            this.Controls.Add(this.buttonAddNew);
            this.Controls.Add(this.listViewPings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remote server pings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPings_FormClosing);
            this.contextMenuStripInteract.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStripInteract;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemEdit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAdd;
        public System.Windows.Forms.ListView listViewPings;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemTest;
        private System.Windows.Forms.Button buttonAddNew;
        private System.Windows.Forms.Label labelInformation;
    }
}