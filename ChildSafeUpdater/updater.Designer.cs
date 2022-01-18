
namespace ChildSafeUpdater
{
    partial class updater
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(updater));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbUpdate = new System.Windows.Forms.Label();
            this.clearFile = new System.Windows.Forms.Timer(this.components);
            this.startInstall = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ChildSafeUpdater.Properties.Resources.loading_animation;
            this.pictureBox1.Location = new System.Drawing.Point(172, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 128);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbUpdate
            // 
            this.lbUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUpdate.Location = new System.Drawing.Point(12, 179);
            this.lbUpdate.Name = "lbUpdate";
            this.lbUpdate.Size = new System.Drawing.Size(489, 27);
            this.lbUpdate.TabIndex = 1;
            this.lbUpdate.Text = "Please wait while we finishing our update...";
            this.lbUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clearFile
            // 
            this.clearFile.Enabled = true;
            this.clearFile.Interval = 2000;
            this.clearFile.Tick += new System.EventHandler(this.clearFile_Tick);
            // 
            // startInstall
            // 
            this.startInstall.Interval = 2000;
            this.startInstall.Tick += new System.EventHandler(this.startInstall_Tick);
            // 
            // updater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(513, 252);
            this.Controls.Add(this.lbUpdate);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "updater";
            this.Text = "Child Safe Updater";
            this.Load += new System.EventHandler(this.updater_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbUpdate;
        private System.Windows.Forms.Timer clearFile;
        private System.Windows.Forms.Timer startInstall;
    }
}

