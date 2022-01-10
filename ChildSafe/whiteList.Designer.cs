
namespace ChildSafe
{
    partial class whiteList
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btSwitcher = new System.Windows.Forms.Button();
            this.tbWhitelist = new System.Windows.Forms.DataGridView();
            this.urlAdded2Table = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btRemove = new System.Windows.Forms.Button();
            this.btAdd2Table = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txUrl2AddWhiteList = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbWhitelist)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btSwitcher);
            this.groupBox1.Controls.Add(this.tbWhitelist);
            this.groupBox1.Controls.Add(this.btRemove);
            this.groupBox1.Controls.Add(this.btAdd2Table);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txUrl2AddWhiteList);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(772, 564);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Custom block";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(677, 24);
            this.label3.MaximumSize = new System.Drawing.Size(2, 100);
            this.label3.MinimumSize = new System.Drawing.Size(2, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(2, 15);
            this.label3.TabIndex = 6;
            // 
            // btSwitcher
            // 
            this.btSwitcher.Enabled = false;
            this.btSwitcher.Location = new System.Drawing.Point(685, 19);
            this.btSwitcher.Name = "btSwitcher";
            this.btSwitcher.Size = new System.Drawing.Size(75, 23);
            this.btSwitcher.TabIndex = 5;
            this.btSwitcher.Text = "Disable";
            this.btSwitcher.UseVisualStyleBackColor = true;
            // 
            // tbWhitelist
            // 
            this.tbWhitelist.BackgroundColor = System.Drawing.SystemColors.Window;
            this.tbWhitelist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbWhitelist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.urlAdded2Table});
            this.tbWhitelist.Location = new System.Drawing.Point(9, 48);
            this.tbWhitelist.Name = "tbWhitelist";
            this.tbWhitelist.Size = new System.Drawing.Size(753, 504);
            this.tbWhitelist.TabIndex = 4;
            this.tbWhitelist.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbWhitelist_CellClick);
            this.tbWhitelist.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbWhitelist_CellContentClick);
            // 
            // urlAdded2Table
            // 
            this.urlAdded2Table.HeaderText = "Website";
            this.urlAdded2Table.Name = "urlAdded2Table";
            this.urlAdded2Table.Width = 700;
            // 
            // btRemove
            // 
            this.btRemove.Enabled = false;
            this.btRemove.Location = new System.Drawing.Point(599, 19);
            this.btRemove.Name = "btRemove";
            this.btRemove.Size = new System.Drawing.Size(72, 23);
            this.btRemove.TabIndex = 3;
            this.btRemove.Text = "Remove";
            this.btRemove.UseVisualStyleBackColor = true;
            this.btRemove.Click += new System.EventHandler(this.btRemove_Click);
            // 
            // btAdd2Table
            // 
            this.btAdd2Table.Enabled = false;
            this.btAdd2Table.Location = new System.Drawing.Point(518, 19);
            this.btAdd2Table.Name = "btAdd2Table";
            this.btAdd2Table.Size = new System.Drawing.Size(75, 23);
            this.btAdd2Table.TabIndex = 2;
            this.btAdd2Table.Text = "Add";
            this.btAdd2Table.UseVisualStyleBackColor = true;
            this.btAdd2Table.Click += new System.EventHandler(this.btAdd2Table_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add a  website to white list";
            // 
            // txUrl2AddWhiteList
            // 
            this.txUrl2AddWhiteList.FormattingEnabled = true;
            this.txUrl2AddWhiteList.Location = new System.Drawing.Point(173, 21);
            this.txUrl2AddWhiteList.Name = "txUrl2AddWhiteList";
            this.txUrl2AddWhiteList.Size = new System.Drawing.Size(339, 21);
            this.txUrl2AddWhiteList.TabIndex = 0;
            // 
            // whiteList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 564);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.Name = "whiteList";
            this.Text = "whiteList";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbWhitelist)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btSwitcher;
        private System.Windows.Forms.DataGridView tbWhitelist;
        private System.Windows.Forms.DataGridViewTextBoxColumn urlAdded2Table;
        private System.Windows.Forms.Button btRemove;
        private System.Windows.Forms.Button btAdd2Table;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox txUrl2AddWhiteList;
    }
}