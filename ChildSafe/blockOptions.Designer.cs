
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(blockOptions));
            this.groupBlacklist = new System.Windows.Forms.GroupBox();
            this.pnControlBlacklist = new System.Windows.Forms.Panel();
            this.btRemove = new System.Windows.Forms.Button();
            this.btAdd2Table = new System.Windows.Forms.Button();
            this.lbBlacklist = new System.Windows.Forms.Label();
            this.txUrl2AddBlackList = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btDisable = new System.Windows.Forms.Button();
            this.tbBlacklist = new System.Windows.Forms.DataGridView();
            this.urlAdded2Table = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.options = new System.Windows.Forms.LinkLabel();
            this.btSave = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbDetails = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listOnDutyFilters = new System.Windows.Forms.ListBox();
            this.removeOnDutyFilters = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btFilterBrowsing = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbDownloadedFiltersList = new System.Windows.Forms.ComboBox();
            this.errorReporter = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.groupBlacklist.SuspendLayout();
            this.pnControlBlacklist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbBlacklist)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.removeOnDutyFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorReporter)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBlacklist
            // 
            this.groupBlacklist.Controls.Add(this.pnControlBlacklist);
            this.groupBlacklist.Controls.Add(this.label3);
            this.groupBlacklist.Controls.Add(this.btDisable);
            this.groupBlacklist.Controls.Add(this.tbBlacklist);
            resources.ApplyResources(this.groupBlacklist, "groupBlacklist");
            this.groupBlacklist.Name = "groupBlacklist";
            this.groupBlacklist.TabStop = false;
            // 
            // pnControlBlacklist
            // 
            this.pnControlBlacklist.Controls.Add(this.btRemove);
            this.pnControlBlacklist.Controls.Add(this.btAdd2Table);
            this.pnControlBlacklist.Controls.Add(this.lbBlacklist);
            this.pnControlBlacklist.Controls.Add(this.txUrl2AddBlackList);
            resources.ApplyResources(this.pnControlBlacklist, "pnControlBlacklist");
            this.pnControlBlacklist.Name = "pnControlBlacklist";
            // 
            // btRemove
            // 
            resources.ApplyResources(this.btRemove, "btRemove");
            this.btRemove.Name = "btRemove";
            this.btRemove.UseVisualStyleBackColor = true;
            this.btRemove.Click += new System.EventHandler(this.btRemove_Click);
            // 
            // btAdd2Table
            // 
            resources.ApplyResources(this.btAdd2Table, "btAdd2Table");
            this.btAdd2Table.Name = "btAdd2Table";
            this.btAdd2Table.UseVisualStyleBackColor = true;
            this.btAdd2Table.Click += new System.EventHandler(this.btAdd2Table_Click);
            // 
            // lbBlacklist
            // 
            resources.ApplyResources(this.lbBlacklist, "lbBlacklist");
            this.lbBlacklist.Name = "lbBlacklist";
            // 
            // txUrl2AddBlackList
            // 
            this.txUrl2AddBlackList.FormattingEnabled = true;
            resources.ApplyResources(this.txUrl2AddBlackList, "txUrl2AddBlackList");
            this.txUrl2AddBlackList.Name = "txUrl2AddBlackList";
            this.txUrl2AddBlackList.SelectedIndexChanged += new System.EventHandler(this.txUrl2AddBlackList_SelectedIndexChanged);
            this.txUrl2AddBlackList.TextChanged += new System.EventHandler(this.txUrl2AddBlackList_TextChanged);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Name = "label3";
            // 
            // btDisable
            // 
            resources.ApplyResources(this.btDisable, "btDisable");
            this.btDisable.Name = "btDisable";
            this.btDisable.UseVisualStyleBackColor = true;
            this.btDisable.Click += new System.EventHandler(this.btDisable_Click);
            // 
            // tbBlacklist
            // 
            this.tbBlacklist.BackgroundColor = System.Drawing.SystemColors.Window;
            this.tbBlacklist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbBlacklist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.urlAdded2Table});
            resources.ApplyResources(this.tbBlacklist, "tbBlacklist");
            this.tbBlacklist.Name = "tbBlacklist";
            this.tbBlacklist.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbBlacklist_CellClick);
            this.tbBlacklist.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbBlacklist_CellContentClick);
            // 
            // urlAdded2Table
            // 
            resources.ApplyResources(this.urlAdded2Table, "urlAdded2Table");
            this.urlAdded2Table.Name = "urlAdded2Table";
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBlacklist);
            this.panel1.Name = "panel1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.options);
            this.panel2.Controls.Add(this.btSave);
            this.panel2.Controls.Add(this.btCancel);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // options
            // 
            resources.ApplyResources(this.options, "options");
            this.options.LinkColor = System.Drawing.Color.MediumBlue;
            this.options.Name = "options";
            this.options.TabStop = true;
            this.options.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.options_LinkClicked);
            // 
            // btSave
            // 
            this.btSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            resources.ApplyResources(this.btSave, "btSave");
            this.btSave.Name = "btSave";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btCancel
            // 
            resources.ApplyResources(this.btCancel, "btCancel");
            this.btCancel.Name = "btCancel";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.btFilterBrowsing);
            this.groupBox2.Controls.Add(this.btAdd);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cbDownloadedFiltersList);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lbDetails);
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            // 
            // lbDetails
            // 
            resources.ApplyResources(this.lbDetails, "lbDetails");
            this.lbDetails.Name = "lbDetails";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listOnDutyFilters);
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // listOnDutyFilters
            // 
            this.listOnDutyFilters.ContextMenuStrip = this.removeOnDutyFilters;
            resources.ApplyResources(this.listOnDutyFilters, "listOnDutyFilters");
            this.listOnDutyFilters.FormattingEnabled = true;
            this.listOnDutyFilters.Name = "listOnDutyFilters";
            this.listOnDutyFilters.SelectedIndexChanged += new System.EventHandler(this.listOnDutyFilters_SelectedIndexChanged);
            // 
            // removeOnDutyFilters
            // 
            this.removeOnDutyFilters.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeToolStripMenuItem});
            this.removeOnDutyFilters.Name = "removeOnDutyFilters";
            resources.ApplyResources(this.removeOnDutyFilters, "removeOnDutyFilters");
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            resources.ApplyResources(this.removeToolStripMenuItem, "removeToolStripMenuItem");
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // btFilterBrowsing
            // 
            resources.ApplyResources(this.btFilterBrowsing, "btFilterBrowsing");
            this.btFilterBrowsing.Name = "btFilterBrowsing";
            this.btFilterBrowsing.UseVisualStyleBackColor = true;
            this.btFilterBrowsing.Click += new System.EventHandler(this.btFilterBrowsing_Click);
            // 
            // btAdd
            // 
            resources.ApplyResources(this.btAdd, "btAdd");
            this.btAdd.Name = "btAdd";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // cbDownloadedFiltersList
            // 
            this.cbDownloadedFiltersList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbDownloadedFiltersList.FormattingEnabled = true;
            resources.ApplyResources(this.cbDownloadedFiltersList, "cbDownloadedFiltersList");
            this.cbDownloadedFiltersList.Name = "cbDownloadedFiltersList";
            this.cbDownloadedFiltersList.SelectedIndexChanged += new System.EventHandler(this.cbDownloadedFiltersList_SelectedIndexChanged);
            // 
            // errorReporter
            // 
            this.errorReporter.ContainerControl = this;
            // 
            // blockOptions
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "blockOptions";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.blockOptions_Load);
            this.groupBlacklist.ResumeLayout(false);
            this.groupBlacklist.PerformLayout();
            this.pnControlBlacklist.ResumeLayout(false);
            this.pnControlBlacklist.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbBlacklist)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.removeOnDutyFilters.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorReporter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBlacklist;
        private System.Windows.Forms.DataGridView tbBlacklist;
        private System.Windows.Forms.Button btAdd2Table;
        private System.Windows.Forms.Label lbBlacklist;
        private System.Windows.Forms.ComboBox txUrl2AddBlackList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btDisable;
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox listOnDutyFilters;
        private System.Windows.Forms.ContextMenuStrip removeOnDutyFilters;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lbDetails;
        private System.Windows.Forms.Panel pnControlBlacklist;
        private System.Windows.Forms.LinkLabel options;
    }
}