
namespace ChildSafe
{
    partial class mainHall
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainHall));
            this.lbPromote = new System.Windows.Forms.Label();
            this.btStart = new System.Windows.Forms.Button();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.getStartedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.filtersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.whitelistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vietnamseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoupdateFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.checkForUpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkForUpdatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.githubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendFeedbackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbNotice = new System.Windows.Forms.Label();
            this.saparator = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.options = new System.Windows.Forms.LinkLabel();
            this.lbLoadingStatus = new System.Windows.Forms.Label();
            this.timerQuote = new System.Windows.Forms.Timer(this.components);
            this.panelLoading = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureMainHall = new System.Windows.Forms.PictureBox();
            this.btMenu = new System.Windows.Forms.PictureBox();
            this.contextMenu.SuspendLayout();
            this.panelLoading.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMainHall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // lbPromote
            // 
            resources.ApplyResources(this.lbPromote, "lbPromote");
            this.lbPromote.ForeColor = System.Drawing.Color.Navy;
            this.lbPromote.Name = "lbPromote";
            // 
            // btStart
            // 
            resources.ApplyResources(this.btStart, "btStart");
            this.btStart.Name = "btStart";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // contextMenu
            // 
            resources.ApplyResources(this.contextMenu, "contextMenu");
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.getStartedToolStripMenuItem,
            this.toolStripMenuItem1,
            this.filtersToolStripMenuItem,
            this.whitelistToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.toolStripMenuItem3,
            this.checkForUpdateToolStripMenuItem,
            this.githubToolStripMenuItem,
            this.sendFeedbackToolStripMenuItem,
            this.toolStripMenuItem2,
            this.aboutToolStripMenuItem});
            this.contextMenu.Name = "contextMenu";
            // 
            // getStartedToolStripMenuItem
            // 
            resources.ApplyResources(this.getStartedToolStripMenuItem, "getStartedToolStripMenuItem");
            this.getStartedToolStripMenuItem.Name = "getStartedToolStripMenuItem";
            // 
            // toolStripMenuItem1
            // 
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            // 
            // filtersToolStripMenuItem
            // 
            resources.ApplyResources(this.filtersToolStripMenuItem, "filtersToolStripMenuItem");
            this.filtersToolStripMenuItem.Name = "filtersToolStripMenuItem";
            this.filtersToolStripMenuItem.Click += new System.EventHandler(this.filtersToolStripMenuItem_Click);
            // 
            // whitelistToolStripMenuItem
            // 
            resources.ApplyResources(this.whitelistToolStripMenuItem, "whitelistToolStripMenuItem");
            this.whitelistToolStripMenuItem.Name = "whitelistToolStripMenuItem";
            this.whitelistToolStripMenuItem.Click += new System.EventHandler(this.whitelistToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            resources.ApplyResources(this.settingsToolStripMenuItem, "settingsToolStripMenuItem");
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.languageToolStripMenuItem,
            this.autoupdateFilterToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            // 
            // languageToolStripMenuItem
            // 
            resources.ApplyResources(this.languageToolStripMenuItem, "languageToolStripMenuItem");
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englishToolStripMenuItem,
            this.vietnamseToolStripMenuItem});
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            // 
            // englishToolStripMenuItem
            // 
            resources.ApplyResources(this.englishToolStripMenuItem, "englishToolStripMenuItem");
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.Click += new System.EventHandler(this.englishToolStripMenuItem_Click);
            // 
            // vietnamseToolStripMenuItem
            // 
            resources.ApplyResources(this.vietnamseToolStripMenuItem, "vietnamseToolStripMenuItem");
            this.vietnamseToolStripMenuItem.Name = "vietnamseToolStripMenuItem";
            this.vietnamseToolStripMenuItem.Click += new System.EventHandler(this.vietnamseToolStripMenuItem_Click);
            // 
            // autoupdateFilterToolStripMenuItem
            // 
            resources.ApplyResources(this.autoupdateFilterToolStripMenuItem, "autoupdateFilterToolStripMenuItem");
            this.autoupdateFilterToolStripMenuItem.Checked = true;
            this.autoupdateFilterToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.autoupdateFilterToolStripMenuItem.Name = "autoupdateFilterToolStripMenuItem";
            this.autoupdateFilterToolStripMenuItem.Click += new System.EventHandler(this.autoupdateFilterToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            resources.ApplyResources(this.toolStripMenuItem3, "toolStripMenuItem3");
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            // 
            // checkForUpdateToolStripMenuItem
            // 
            resources.ApplyResources(this.checkForUpdateToolStripMenuItem, "checkForUpdateToolStripMenuItem");
            this.checkForUpdateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkForUpdatesToolStripMenuItem,
            this.updateHistoryToolStripMenuItem});
            this.checkForUpdateToolStripMenuItem.Name = "checkForUpdateToolStripMenuItem";
            // 
            // checkForUpdatesToolStripMenuItem
            // 
            resources.ApplyResources(this.checkForUpdatesToolStripMenuItem, "checkForUpdatesToolStripMenuItem");
            this.checkForUpdatesToolStripMenuItem.Name = "checkForUpdatesToolStripMenuItem";
            // 
            // updateHistoryToolStripMenuItem
            // 
            resources.ApplyResources(this.updateHistoryToolStripMenuItem, "updateHistoryToolStripMenuItem");
            this.updateHistoryToolStripMenuItem.Name = "updateHistoryToolStripMenuItem";
            // 
            // githubToolStripMenuItem
            // 
            resources.ApplyResources(this.githubToolStripMenuItem, "githubToolStripMenuItem");
            this.githubToolStripMenuItem.Image = global::ChildSafe.Properties.Resources.github_20;
            this.githubToolStripMenuItem.Name = "githubToolStripMenuItem";
            this.githubToolStripMenuItem.Click += new System.EventHandler(this.githubToolStripMenuItem_Click);
            // 
            // sendFeedbackToolStripMenuItem
            // 
            resources.ApplyResources(this.sendFeedbackToolStripMenuItem, "sendFeedbackToolStripMenuItem");
            this.sendFeedbackToolStripMenuItem.Name = "sendFeedbackToolStripMenuItem";
            this.sendFeedbackToolStripMenuItem.Click += new System.EventHandler(this.sendFeedbackToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            resources.ApplyResources(this.toolStripMenuItem2, "toolStripMenuItem2");
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            // 
            // aboutToolStripMenuItem
            // 
            resources.ApplyResources(this.aboutToolStripMenuItem, "aboutToolStripMenuItem");
            this.aboutToolStripMenuItem.Image = global::ChildSafe.Properties.Resources.info_20;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // lbNotice
            // 
            resources.ApplyResources(this.lbNotice, "lbNotice");
            this.lbNotice.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lbNotice.Name = "lbNotice";
            // 
            // saparator
            // 
            resources.ApplyResources(this.saparator, "saparator");
            this.saparator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.saparator.Name = "saparator";
            // 
            // progressBar1
            // 
            resources.ApplyResources(this.progressBar1, "progressBar1");
            this.progressBar1.Name = "progressBar1";
            // 
            // options
            // 
            resources.ApplyResources(this.options, "options");
            this.options.LinkColor = System.Drawing.Color.MediumBlue;
            this.options.Name = "options";
            this.options.TabStop = true;
            this.options.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.options_LinkClicked);
            // 
            // lbLoadingStatus
            // 
            resources.ApplyResources(this.lbLoadingStatus, "lbLoadingStatus");
            this.lbLoadingStatus.Name = "lbLoadingStatus";
            // 
            // timerQuote
            // 
            this.timerQuote.Enabled = true;
            this.timerQuote.Interval = 8000;
            this.timerQuote.Tick += new System.EventHandler(this.timerQuote_Tick);
            // 
            // panelLoading
            // 
            resources.ApplyResources(this.panelLoading, "panelLoading");
            this.panelLoading.Controls.Add(this.lbLoadingStatus);
            this.panelLoading.Controls.Add(this.progressBar1);
            this.panelLoading.Name = "panelLoading";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Image = global::ChildSafe.Properties.Resources._5173004_mail_warning_internet_email_security_alert_attention1;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // pictureMainHall
            // 
            resources.ApplyResources(this.pictureMainHall, "pictureMainHall");
            this.pictureMainHall.Image = global::ChildSafe.Properties.Resources.danger_256;
            this.pictureMainHall.Name = "pictureMainHall";
            this.pictureMainHall.TabStop = false;
            // 
            // btMenu
            // 
            resources.ApplyResources(this.btMenu, "btMenu");
            this.btMenu.ContextMenuStrip = this.contextMenu;
            this.btMenu.Image = global::ChildSafe.Properties.Resources.more_24;
            this.btMenu.Name = "btMenu";
            this.btMenu.TabStop = false;
            this.btMenu.Click += new System.EventHandler(this.btMenu_Click);
            // 
            // mainHall
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelLoading);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.options);
            this.Controls.Add(this.saparator);
            this.Controls.Add(this.lbNotice);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.lbPromote);
            this.Controls.Add(this.pictureMainHall);
            this.Controls.Add(this.btMenu);
            this.Name = "mainHall";
            this.Load += new System.EventHandler(this.mainHall_Load);
            this.contextMenu.ResumeLayout(false);
            this.panelLoading.ResumeLayout(false);
            this.panelLoading.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMainHall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btMenu;
        private System.Windows.Forms.PictureBox pictureMainHall;
        private System.Windows.Forms.Label lbPromote;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Label lbNotice;
        private System.Windows.Forms.Label saparator;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.LinkLabel options;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem getStartedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendFeedbackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkForUpdateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkForUpdatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label lbLoadingStatus;
        private System.Windows.Forms.Timer timerQuote;
        private System.Windows.Forms.ToolStripMenuItem filtersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem whitelistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vietnamseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoupdateFilterToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem githubToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelLoading;
    }
}

