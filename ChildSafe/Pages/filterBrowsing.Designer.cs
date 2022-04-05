
namespace ChildSafe
{
    partial class filterBrowsing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(filterBrowsing));
            this.flowLayoutSet = new System.Windows.Forms.FlowLayoutPanel();
            this.selectedFilterUrl = new System.Windows.Forms.ListBox();
            this.selectedFilterName = new System.Windows.Forms.ListBox();
            this.btCancel = new System.Windows.Forms.Button();
            this.btOk = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.btDownloadFilter = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lbDownloadStatus = new System.Windows.Forms.Label();
            this.lbUpdateTime = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutSet.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutSet
            // 
            resources.ApplyResources(this.flowLayoutSet, "flowLayoutSet");
            this.flowLayoutSet.Controls.Add(this.selectedFilterUrl);
            this.flowLayoutSet.Controls.Add(this.selectedFilterName);
            this.flowLayoutSet.Name = "flowLayoutSet";
            // 
            // selectedFilterUrl
            // 
            resources.ApplyResources(this.selectedFilterUrl, "selectedFilterUrl");
            this.selectedFilterUrl.FormattingEnabled = true;
            this.selectedFilterUrl.Name = "selectedFilterUrl";
            this.selectedFilterUrl.SelectedIndexChanged += new System.EventHandler(this.selectedFilterUrl_SelectedIndexChanged);
            // 
            // selectedFilterName
            // 
            resources.ApplyResources(this.selectedFilterName, "selectedFilterName");
            this.selectedFilterName.FormattingEnabled = true;
            this.selectedFilterName.Name = "selectedFilterName";
            this.selectedFilterName.SelectedIndexChanged += new System.EventHandler(this.selectedFilterName_SelectedIndexChanged);
            // 
            // btCancel
            // 
            resources.ApplyResources(this.btCancel, "btCancel");
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btCancel.Name = "btCancel";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btOk
            // 
            resources.ApplyResources(this.btOk, "btOk");
            this.btOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btOk.Name = "btOk";
            this.btOk.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            resources.ApplyResources(this.label19, "label19");
            this.label19.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label19.Name = "label19";
            // 
            // btDownloadFilter
            // 
            resources.ApplyResources(this.btDownloadFilter, "btDownloadFilter");
            this.btDownloadFilter.Name = "btDownloadFilter";
            this.btDownloadFilter.UseVisualStyleBackColor = true;
            this.btDownloadFilter.Click += new System.EventHandler(this.btDownloadFilter_Click);
            // 
            // progressBar1
            // 
            resources.ApplyResources(this.progressBar1, "progressBar1");
            this.progressBar1.Name = "progressBar1";
            // 
            // lbDownloadStatus
            // 
            resources.ApplyResources(this.lbDownloadStatus, "lbDownloadStatus");
            this.lbDownloadStatus.Name = "lbDownloadStatus";
            // 
            // lbUpdateTime
            // 
            resources.ApplyResources(this.lbUpdateTime, "lbUpdateTime");
            this.lbUpdateTime.ForeColor = System.Drawing.Color.Orange;
            this.lbUpdateTime.Name = "lbUpdateTime";
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.lbUpdateTime);
            this.panel1.Controls.Add(this.lbDownloadStatus);
            this.panel1.Controls.Add(this.progressBar1);
            this.panel1.Controls.Add(this.btDownloadFilter);
            this.panel1.Controls.Add(this.btOk);
            this.panel1.Controls.Add(this.btCancel);
            this.panel1.Name = "panel1";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Image = global::ChildSafe.Properties.Resources.lock_64;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // filterBrowsing
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.flowLayoutSet);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "filterBrowsing";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.filterBrowsing_FormClosing);
            this.Load += new System.EventHandler(this.filterBrowsing_Load);
            this.flowLayoutSet.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutSet;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ListBox selectedFilterUrl;
        private System.Windows.Forms.Button btDownloadFilter;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lbDownloadStatus;
        private System.Windows.Forms.ListBox selectedFilterName;
        private System.Windows.Forms.Label lbUpdateTime;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}