
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
            this.flowLayoutSet = new System.Windows.Forms.FlowLayoutPanel();
            this.selectedFilterUrl = new System.Windows.Forms.ListBox();
            this.selectedFilterName = new System.Windows.Forms.ListBox();
            this.btCancel = new System.Windows.Forms.Button();
            this.btOk = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.btDownloadFilter = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lbDownloadStatus = new System.Windows.Forms.Label();
            this.flowLayoutSet.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutSet
            // 
            this.flowLayoutSet.AutoScroll = true;
            this.flowLayoutSet.Controls.Add(this.selectedFilterUrl);
            this.flowLayoutSet.Controls.Add(this.selectedFilterName);
            this.flowLayoutSet.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutSet.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutSet.Name = "flowLayoutSet";
            this.flowLayoutSet.Size = new System.Drawing.Size(516, 454);
            this.flowLayoutSet.TabIndex = 0;
            // 
            // selectedFilterUrl
            // 
            this.selectedFilterUrl.FormattingEnabled = true;
            this.selectedFilterUrl.Location = new System.Drawing.Point(3, 3);
            this.selectedFilterUrl.Name = "selectedFilterUrl";
            this.selectedFilterUrl.Size = new System.Drawing.Size(159, 69);
            this.selectedFilterUrl.TabIndex = 4;
            this.selectedFilterUrl.Visible = false;
            // 
            // selectedFilterName
            // 
            this.selectedFilterName.FormattingEnabled = true;
            this.selectedFilterName.Location = new System.Drawing.Point(168, 3);
            this.selectedFilterName.Name = "selectedFilterName";
            this.selectedFilterName.Size = new System.Drawing.Size(159, 69);
            this.selectedFilterName.TabIndex = 5;
            this.selectedFilterName.Visible = false;
            this.selectedFilterName.SelectedIndexChanged += new System.EventHandler(this.selectedFilterName_SelectedIndexChanged);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(429, 578);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 1;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btOk
            // 
            this.btOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btOk.Enabled = false;
            this.btOk.Location = new System.Drawing.Point(348, 578);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(75, 23);
            this.btOk.TabIndex = 1;
            this.btOk.Text = "OK";
            this.btOk.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            this.label19.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label19.Location = new System.Drawing.Point(6, 462);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(498, 75);
            this.label19.TabIndex = 3;
            this.label19.Text = "*we not recommend you to use all the filter at the same time because it will effe" +
    "ct your daily usage. Choose filter base on your specific need is definitely bett" +
    "er in this case.";
            // 
            // btDownloadFilter
            // 
            this.btDownloadFilter.Enabled = false;
            this.btDownloadFilter.Location = new System.Drawing.Point(12, 578);
            this.btDownloadFilter.Name = "btDownloadFilter";
            this.btDownloadFilter.Size = new System.Drawing.Size(75, 23);
            this.btDownloadFilter.TabIndex = 1;
            this.btDownloadFilter.Text = "Download";
            this.btDownloadFilter.UseVisualStyleBackColor = true;
            this.btDownloadFilter.Click += new System.EventHandler(this.btDownloadFilter_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 540);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(492, 23);
            this.progressBar1.TabIndex = 4;
            // 
            // lbDownloadStatus
            // 
            this.lbDownloadStatus.AutoSize = true;
            this.lbDownloadStatus.Location = new System.Drawing.Point(12, 524);
            this.lbDownloadStatus.Name = "lbDownloadStatus";
            this.lbDownloadStatus.Size = new System.Drawing.Size(108, 13);
            this.lbDownloadStatus.TabIndex = 5;
            this.lbDownloadStatus.Text = "Ready to download";
            // 
            // filterBrowsing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 613);
            this.Controls.Add(this.lbDownloadStatus);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.btDownloadFilter);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.flowLayoutSet);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "filterBrowsing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "filterBrowsing";
            this.Load += new System.EventHandler(this.filterBrowsing_Load);
            this.flowLayoutSet.ResumeLayout(false);
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
    }
}