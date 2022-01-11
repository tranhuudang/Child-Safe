
namespace ChildSafe
{
    partial class blockOptions
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btWhiteList = new System.Windows.Forms.Button();
            this.tbBlacklist = new System.Windows.Forms.DataGridView();
            this.urlAdded2Table = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btRemove = new System.Windows.Forms.Button();
            this.btAdd2Table = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txUrl2AddBlackList = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btSave = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbFilterDetails = new System.Windows.Forms.Label();
            this.btFilterBrowsing = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbDownloadedFiltersList = new System.Windows.Forms.ComboBox();
            this.errorReporter = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listOnDutyFilters = new System.Windows.Forms.ListBox();
            this.removeOnDutyFilters = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbBlacklist)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorReporter)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.removeOnDutyFilters.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btWhiteList);
            this.groupBox1.Controls.Add(this.tbBlacklist);
            this.groupBox1.Controls.Add(this.btRemove);
            this.groupBox1.Controls.Add(this.btAdd2Table);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txUrl2AddBlackList);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(772, 257);
            this.groupBox1.TabIndex = 0;
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
            // btWhiteList
            // 
            this.btWhiteList.Location = new System.Drawing.Point(685, 19);
            this.btWhiteList.Name = "btWhiteList";
            this.btWhiteList.Size = new System.Drawing.Size(75, 23);
            this.btWhiteList.TabIndex = 5;
            this.btWhiteList.Text = "Disable";
            this.btWhiteList.UseVisualStyleBackColor = true;
            // 
            // tbBlacklist
            // 
            this.tbBlacklist.BackgroundColor = System.Drawing.SystemColors.Window;
            this.tbBlacklist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbBlacklist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.urlAdded2Table});
            this.tbBlacklist.Location = new System.Drawing.Point(9, 48);
            this.tbBlacklist.Name = "tbBlacklist";
            this.tbBlacklist.Size = new System.Drawing.Size(753, 203);
            this.tbBlacklist.TabIndex = 4;
            this.tbBlacklist.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbBlacklist_CellClick);
            this.tbBlacklist.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbBlacklist_CellContentClick);
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
            this.btAdd2Table.Text = "Block";
            this.btAdd2Table.UseVisualStyleBackColor = true;
            this.btAdd2Table.Click += new System.EventHandler(this.btAdd2Table_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add a  website to black list";
            // 
            // txUrl2AddBlackList
            // 
            this.txUrl2AddBlackList.FormattingEnabled = true;
            this.txUrl2AddBlackList.Location = new System.Drawing.Point(173, 21);
            this.txUrl2AddBlackList.Name = "txUrl2AddBlackList";
            this.txUrl2AddBlackList.Size = new System.Drawing.Size(339, 21);
            this.txUrl2AddBlackList.TabIndex = 0;
            this.txUrl2AddBlackList.SelectedIndexChanged += new System.EventHandler(this.txUrl2AddBlackList_SelectedIndexChanged);
            this.txUrl2AddBlackList.TextChanged += new System.EventHandler(this.txUrl2AddBlackList_TextChanged);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(772, 564);
            this.panel1.TabIndex = 4;
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(606, 5);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 23);
            this.btSave.TabIndex = 13;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(687, 5);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 12;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.lbFilterDetails);
            this.groupBox2.Controls.Add(this.btFilterBrowsing);
            this.groupBox2.Controls.Add(this.btAdd);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cbDownloadedFiltersList);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 257);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(772, 261);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Other options";
            // 
            // lbFilterDetails
            // 
            this.lbFilterDetails.Location = new System.Drawing.Point(567, 66);
            this.lbFilterDetails.Name = "lbFilterDetails";
            this.lbFilterDetails.Size = new System.Drawing.Size(193, 188);
            this.lbFilterDetails.TabIndex = 12;
            this.lbFilterDetails.Text = "label4";
            // 
            // btFilterBrowsing
            // 
            this.btFilterBrowsing.Location = new System.Drawing.Point(667, 21);
            this.btFilterBrowsing.Name = "btFilterBrowsing";
            this.btFilterBrowsing.Size = new System.Drawing.Size(95, 23);
            this.btFilterBrowsing.TabIndex = 8;
            this.btFilterBrowsing.Text = "Browse..";
            this.btFilterBrowsing.UseVisualStyleBackColor = true;
            this.btFilterBrowsing.Click += new System.EventHandler(this.btFilterBrowsing_Click);
            // 
            // btAdd
            // 
            this.btAdd.Enabled = false;
            this.btAdd.Location = new System.Drawing.Point(570, 21);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(91, 23);
            this.btAdd.TabIndex = 11;
            this.btAdd.Text = "Add";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Search filter";
            // 
            // cbDownloadedFiltersList
            // 
            this.cbDownloadedFiltersList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbDownloadedFiltersList.FormattingEnabled = true;
            this.cbDownloadedFiltersList.Location = new System.Drawing.Point(96, 24);
            this.cbDownloadedFiltersList.Name = "cbDownloadedFiltersList";
            this.cbDownloadedFiltersList.Size = new System.Drawing.Size(468, 21);
            this.cbDownloadedFiltersList.TabIndex = 9;
            this.cbDownloadedFiltersList.SelectedIndexChanged += new System.EventHandler(this.cbDownloadedFiltersList_SelectedIndexChanged);
            // 
            // errorReporter
            // 
            this.errorReporter.ContainerControl = this;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listOnDutyFilters);
            this.groupBox3.Location = new System.Drawing.Point(15, 66);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(546, 188);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Active Filters";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btSave);
            this.panel2.Controls.Add(this.btCancel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 524);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(772, 40);
            this.panel2.TabIndex = 14;
            // 
            // listOnDutyFilters
            // 
            this.listOnDutyFilters.ContextMenuStrip = this.removeOnDutyFilters;
            this.listOnDutyFilters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listOnDutyFilters.FormattingEnabled = true;
            this.listOnDutyFilters.Location = new System.Drawing.Point(3, 18);
            this.listOnDutyFilters.Name = "listOnDutyFilters";
            this.listOnDutyFilters.Size = new System.Drawing.Size(540, 167);
            this.listOnDutyFilters.TabIndex = 0;
            this.listOnDutyFilters.SelectedIndexChanged += new System.EventHandler(this.listOnDutyFilters_SelectedIndexChanged);
            // 
            // removeOnDutyFilters
            // 
            this.removeOnDutyFilters.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeToolStripMenuItem});
            this.removeOnDutyFilters.Name = "removeOnDutyFilters";
            this.removeOnDutyFilters.Size = new System.Drawing.Size(118, 26);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // blockOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 564);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "blockOptions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BlockOptions";
            this.Load += new System.EventHandler(this.blockOptions_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbBlacklist)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorReporter)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.removeOnDutyFilters.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView tbBlacklist;
        private System.Windows.Forms.Button btAdd2Table;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox txUrl2AddBlackList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btWhiteList;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btFilterBrowsing;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbDownloadedFiltersList;
        private System.Windows.Forms.DataGridViewTextBoxColumn urlAdded2Table;
        private System.Windows.Forms.Button btRemove;
        private System.Windows.Forms.ErrorProvider errorReporter;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label lbFilterDetails;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox listOnDutyFilters;
        private System.Windows.Forms.ContextMenuStrip removeOnDutyFilters;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
    }
}