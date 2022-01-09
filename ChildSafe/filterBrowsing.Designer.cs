
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.label19 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flowLayoutSet
            // 
            this.flowLayoutSet.AutoScroll = true;
            this.flowLayoutSet.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutSet.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutSet.Name = "flowLayoutSet";
            this.flowLayoutSet.Size = new System.Drawing.Size(516, 454);
            this.flowLayoutSet.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(421, 540);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(340, 540);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "OK";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(14, 544);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(71, 17);
            this.checkBox7.TabIndex = 2;
            this.checkBox7.Text = "Select all";
            this.checkBox7.UseVisualStyleBackColor = true;
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
            // filterBrowsing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 575);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.checkBox7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.flowLayoutSet);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "filterBrowsing";
            this.Text = "filterBrowsing";
            this.Load += new System.EventHandler(this.filterBrowsing_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutSet;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.Label label19;
    }
}