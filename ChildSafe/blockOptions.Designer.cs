
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
            resources.ApplyResources(this.groupBlacklist, "groupBlacklist");
            this.groupBlacklist.Controls.Add(this.pnControlBlacklist);
            this.groupBlacklist.Controls.Add(this.label3);
            this.groupBlacklist.Controls.Add(this.btDisable);
            this.groupBlacklist.Controls.Add(this.tbBlacklist);
            this.errorReporter.SetError(this.groupBlacklist, resources.GetString("groupBlacklist.Error"));
            this.errorReporter.SetIconAlignment(this.groupBlacklist, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("groupBlacklist.IconAlignment"))));
            this.errorReporter.SetIconPadding(this.groupBlacklist, ((int)(resources.GetObject("groupBlacklist.IconPadding"))));
            this.groupBlacklist.Name = "groupBlacklist";
            this.groupBlacklist.TabStop = false;
            this.toolTip.SetToolTip(this.groupBlacklist, resources.GetString("groupBlacklist.ToolTip"));
            // 
            // pnControlBlacklist
            // 
            resources.ApplyResources(this.pnControlBlacklist, "pnControlBlacklist");
            this.pnControlBlacklist.Controls.Add(this.btRemove);
            this.pnControlBlacklist.Controls.Add(this.btAdd2Table);
            this.pnControlBlacklist.Controls.Add(this.lbBlacklist);
            this.pnControlBlacklist.Controls.Add(this.txUrl2AddBlackList);
            this.errorReporter.SetError(this.pnControlBlacklist, resources.GetString("pnControlBlacklist.Error"));
            this.errorReporter.SetIconAlignment(this.pnControlBlacklist, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("pnControlBlacklist.IconAlignment"))));
            this.errorReporter.SetIconPadding(this.pnControlBlacklist, ((int)(resources.GetObject("pnControlBlacklist.IconPadding"))));
            this.pnControlBlacklist.Name = "pnControlBlacklist";
            this.toolTip.SetToolTip(this.pnControlBlacklist, resources.GetString("pnControlBlacklist.ToolTip"));
            // 
            // btRemove
            // 
            resources.ApplyResources(this.btRemove, "btRemove");
            this.errorReporter.SetError(this.btRemove, resources.GetString("btRemove.Error"));
            this.errorReporter.SetIconAlignment(this.btRemove, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btRemove.IconAlignment"))));
            this.errorReporter.SetIconPadding(this.btRemove, ((int)(resources.GetObject("btRemove.IconPadding"))));
            this.btRemove.Name = "btRemove";
            this.toolTip.SetToolTip(this.btRemove, resources.GetString("btRemove.ToolTip"));
            this.btRemove.UseVisualStyleBackColor = true;
            this.btRemove.Click += new System.EventHandler(this.btRemove_Click);
            // 
            // btAdd2Table
            // 
            resources.ApplyResources(this.btAdd2Table, "btAdd2Table");
            this.errorReporter.SetError(this.btAdd2Table, resources.GetString("btAdd2Table.Error"));
            this.errorReporter.SetIconAlignment(this.btAdd2Table, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btAdd2Table.IconAlignment"))));
            this.errorReporter.SetIconPadding(this.btAdd2Table, ((int)(resources.GetObject("btAdd2Table.IconPadding"))));
            this.btAdd2Table.Name = "btAdd2Table";
            this.toolTip.SetToolTip(this.btAdd2Table, resources.GetString("btAdd2Table.ToolTip"));
            this.btAdd2Table.UseVisualStyleBackColor = true;
            this.btAdd2Table.Click += new System.EventHandler(this.btAdd2Table_Click);
            // 
            // lbBlacklist
            // 
            resources.ApplyResources(this.lbBlacklist, "lbBlacklist");
            this.errorReporter.SetError(this.lbBlacklist, resources.GetString("lbBlacklist.Error"));
            this.errorReporter.SetIconAlignment(this.lbBlacklist, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lbBlacklist.IconAlignment"))));
            this.errorReporter.SetIconPadding(this.lbBlacklist, ((int)(resources.GetObject("lbBlacklist.IconPadding"))));
            this.lbBlacklist.Name = "lbBlacklist";
            this.toolTip.SetToolTip(this.lbBlacklist, resources.GetString("lbBlacklist.ToolTip"));
            // 
            // txUrl2AddBlackList
            // 
            resources.ApplyResources(this.txUrl2AddBlackList, "txUrl2AddBlackList");
            this.errorReporter.SetError(this.txUrl2AddBlackList, resources.GetString("txUrl2AddBlackList.Error"));
            this.txUrl2AddBlackList.FormattingEnabled = true;
            this.errorReporter.SetIconAlignment(this.txUrl2AddBlackList, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txUrl2AddBlackList.IconAlignment"))));
            this.errorReporter.SetIconPadding(this.txUrl2AddBlackList, ((int)(resources.GetObject("txUrl2AddBlackList.IconPadding"))));
            this.txUrl2AddBlackList.Name = "txUrl2AddBlackList";
            this.toolTip.SetToolTip(this.txUrl2AddBlackList, resources.GetString("txUrl2AddBlackList.ToolTip"));
            this.txUrl2AddBlackList.SelectedIndexChanged += new System.EventHandler(this.txUrl2AddBlackList_SelectedIndexChanged);
            this.txUrl2AddBlackList.TextChanged += new System.EventHandler(this.txUrl2AddBlackList_TextChanged);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.errorReporter.SetError(this.label3, resources.GetString("label3.Error"));
            this.errorReporter.SetIconAlignment(this.label3, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label3.IconAlignment"))));
            this.errorReporter.SetIconPadding(this.label3, ((int)(resources.GetObject("label3.IconPadding"))));
            this.label3.Name = "label3";
            this.toolTip.SetToolTip(this.label3, resources.GetString("label3.ToolTip"));
            // 
            // btDisable
            // 
            resources.ApplyResources(this.btDisable, "btDisable");
            this.errorReporter.SetError(this.btDisable, resources.GetString("btDisable.Error"));
            this.errorReporter.SetIconAlignment(this.btDisable, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btDisable.IconAlignment"))));
            this.errorReporter.SetIconPadding(this.btDisable, ((int)(resources.GetObject("btDisable.IconPadding"))));
            this.btDisable.Name = "btDisable";
            this.toolTip.SetToolTip(this.btDisable, resources.GetString("btDisable.ToolTip"));
            this.btDisable.UseVisualStyleBackColor = true;
            this.btDisable.Click += new System.EventHandler(this.btDisable_Click);
            // 
            // tbBlacklist
            // 
            resources.ApplyResources(this.tbBlacklist, "tbBlacklist");
            this.tbBlacklist.BackgroundColor = System.Drawing.SystemColors.Window;
            this.tbBlacklist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbBlacklist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.urlAdded2Table});
            this.errorReporter.SetError(this.tbBlacklist, resources.GetString("tbBlacklist.Error"));
            this.errorReporter.SetIconAlignment(this.tbBlacklist, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("tbBlacklist.IconAlignment"))));
            this.errorReporter.SetIconPadding(this.tbBlacklist, ((int)(resources.GetObject("tbBlacklist.IconPadding"))));
            this.tbBlacklist.Name = "tbBlacklist";
            this.toolTip.SetToolTip(this.tbBlacklist, resources.GetString("tbBlacklist.ToolTip"));
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
            this.errorReporter.SetError(this.panel1, resources.GetString("panel1.Error"));
            this.errorReporter.SetIconAlignment(this.panel1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("panel1.IconAlignment"))));
            this.errorReporter.SetIconPadding(this.panel1, ((int)(resources.GetObject("panel1.IconPadding"))));
            this.panel1.Name = "panel1";
            this.toolTip.SetToolTip(this.panel1, resources.GetString("panel1.ToolTip"));
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Controls.Add(this.options);
            this.panel2.Controls.Add(this.btSave);
            this.panel2.Controls.Add(this.btCancel);
            this.errorReporter.SetError(this.panel2, resources.GetString("panel2.Error"));
            this.errorReporter.SetIconAlignment(this.panel2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("panel2.IconAlignment"))));
            this.errorReporter.SetIconPadding(this.panel2, ((int)(resources.GetObject("panel2.IconPadding"))));
            this.panel2.Name = "panel2";
            this.toolTip.SetToolTip(this.panel2, resources.GetString("panel2.ToolTip"));
            // 
            // options
            // 
            resources.ApplyResources(this.options, "options");
            this.errorReporter.SetError(this.options, resources.GetString("options.Error"));
            this.errorReporter.SetIconAlignment(this.options, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("options.IconAlignment"))));
            this.errorReporter.SetIconPadding(this.options, ((int)(resources.GetObject("options.IconPadding"))));
            this.options.LinkColor = System.Drawing.Color.MediumBlue;
            this.options.Name = "options";
            this.options.TabStop = true;
            this.toolTip.SetToolTip(this.options, resources.GetString("options.ToolTip"));
            // 
            // btSave
            // 
            resources.ApplyResources(this.btSave, "btSave");
            this.errorReporter.SetError(this.btSave, resources.GetString("btSave.Error"));
            this.errorReporter.SetIconAlignment(this.btSave, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btSave.IconAlignment"))));
            this.errorReporter.SetIconPadding(this.btSave, ((int)(resources.GetObject("btSave.IconPadding"))));
            this.btSave.Name = "btSave";
            this.toolTip.SetToolTip(this.btSave, resources.GetString("btSave.ToolTip"));
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btCancel
            // 
            resources.ApplyResources(this.btCancel, "btCancel");
            this.errorReporter.SetError(this.btCancel, resources.GetString("btCancel.Error"));
            this.errorReporter.SetIconAlignment(this.btCancel, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btCancel.IconAlignment"))));
            this.errorReporter.SetIconPadding(this.btCancel, ((int)(resources.GetObject("btCancel.IconPadding"))));
            this.btCancel.Name = "btCancel";
            this.toolTip.SetToolTip(this.btCancel, resources.GetString("btCancel.ToolTip"));
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.btFilterBrowsing);
            this.groupBox2.Controls.Add(this.btAdd);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cbDownloadedFiltersList);
            this.errorReporter.SetError(this.groupBox2, resources.GetString("groupBox2.Error"));
            this.errorReporter.SetIconAlignment(this.groupBox2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("groupBox2.IconAlignment"))));
            this.errorReporter.SetIconPadding(this.groupBox2, ((int)(resources.GetObject("groupBox2.IconPadding"))));
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            this.toolTip.SetToolTip(this.groupBox2, resources.GetString("groupBox2.ToolTip"));
            // 
            // groupBox4
            // 
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.Controls.Add(this.lbDetails);
            this.errorReporter.SetError(this.groupBox4, resources.GetString("groupBox4.Error"));
            this.errorReporter.SetIconAlignment(this.groupBox4, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("groupBox4.IconAlignment"))));
            this.errorReporter.SetIconPadding(this.groupBox4, ((int)(resources.GetObject("groupBox4.IconPadding"))));
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            this.toolTip.SetToolTip(this.groupBox4, resources.GetString("groupBox4.ToolTip"));
            // 
            // lbDetails
            // 
            resources.ApplyResources(this.lbDetails, "lbDetails");
            this.errorReporter.SetError(this.lbDetails, resources.GetString("lbDetails.Error"));
            this.errorReporter.SetIconAlignment(this.lbDetails, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lbDetails.IconAlignment"))));
            this.errorReporter.SetIconPadding(this.lbDetails, ((int)(resources.GetObject("lbDetails.IconPadding"))));
            this.lbDetails.Name = "lbDetails";
            this.toolTip.SetToolTip(this.lbDetails, resources.GetString("lbDetails.ToolTip"));
            // 
            // groupBox3
            // 
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Controls.Add(this.listOnDutyFilters);
            this.errorReporter.SetError(this.groupBox3, resources.GetString("groupBox3.Error"));
            this.errorReporter.SetIconAlignment(this.groupBox3, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("groupBox3.IconAlignment"))));
            this.errorReporter.SetIconPadding(this.groupBox3, ((int)(resources.GetObject("groupBox3.IconPadding"))));
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            this.toolTip.SetToolTip(this.groupBox3, resources.GetString("groupBox3.ToolTip"));
            // 
            // listOnDutyFilters
            // 
            resources.ApplyResources(this.listOnDutyFilters, "listOnDutyFilters");
            this.listOnDutyFilters.ContextMenuStrip = this.removeOnDutyFilters;
            this.errorReporter.SetError(this.listOnDutyFilters, resources.GetString("listOnDutyFilters.Error"));
            this.listOnDutyFilters.FormattingEnabled = true;
            this.errorReporter.SetIconAlignment(this.listOnDutyFilters, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("listOnDutyFilters.IconAlignment"))));
            this.errorReporter.SetIconPadding(this.listOnDutyFilters, ((int)(resources.GetObject("listOnDutyFilters.IconPadding"))));
            this.listOnDutyFilters.Name = "listOnDutyFilters";
            this.toolTip.SetToolTip(this.listOnDutyFilters, resources.GetString("listOnDutyFilters.ToolTip"));
            this.listOnDutyFilters.SelectedIndexChanged += new System.EventHandler(this.listOnDutyFilters_SelectedIndexChanged);
            // 
            // removeOnDutyFilters
            // 
            resources.ApplyResources(this.removeOnDutyFilters, "removeOnDutyFilters");
            this.errorReporter.SetError(this.removeOnDutyFilters, resources.GetString("removeOnDutyFilters.Error"));
            this.errorReporter.SetIconAlignment(this.removeOnDutyFilters, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("removeOnDutyFilters.IconAlignment"))));
            this.errorReporter.SetIconPadding(this.removeOnDutyFilters, ((int)(resources.GetObject("removeOnDutyFilters.IconPadding"))));
            this.removeOnDutyFilters.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeToolStripMenuItem});
            this.removeOnDutyFilters.Name = "removeOnDutyFilters";
            this.toolTip.SetToolTip(this.removeOnDutyFilters, resources.GetString("removeOnDutyFilters.ToolTip"));
            // 
            // removeToolStripMenuItem
            // 
            resources.ApplyResources(this.removeToolStripMenuItem, "removeToolStripMenuItem");
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // btFilterBrowsing
            // 
            resources.ApplyResources(this.btFilterBrowsing, "btFilterBrowsing");
            this.errorReporter.SetError(this.btFilterBrowsing, resources.GetString("btFilterBrowsing.Error"));
            this.errorReporter.SetIconAlignment(this.btFilterBrowsing, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btFilterBrowsing.IconAlignment"))));
            this.errorReporter.SetIconPadding(this.btFilterBrowsing, ((int)(resources.GetObject("btFilterBrowsing.IconPadding"))));
            this.btFilterBrowsing.Name = "btFilterBrowsing";
            this.toolTip.SetToolTip(this.btFilterBrowsing, resources.GetString("btFilterBrowsing.ToolTip"));
            this.btFilterBrowsing.UseVisualStyleBackColor = true;
            this.btFilterBrowsing.Click += new System.EventHandler(this.btFilterBrowsing_Click);
            // 
            // btAdd
            // 
            resources.ApplyResources(this.btAdd, "btAdd");
            this.errorReporter.SetError(this.btAdd, resources.GetString("btAdd.Error"));
            this.errorReporter.SetIconAlignment(this.btAdd, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btAdd.IconAlignment"))));
            this.errorReporter.SetIconPadding(this.btAdd, ((int)(resources.GetObject("btAdd.IconPadding"))));
            this.btAdd.Name = "btAdd";
            this.toolTip.SetToolTip(this.btAdd, resources.GetString("btAdd.ToolTip"));
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.errorReporter.SetError(this.label2, resources.GetString("label2.Error"));
            this.errorReporter.SetIconAlignment(this.label2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label2.IconAlignment"))));
            this.errorReporter.SetIconPadding(this.label2, ((int)(resources.GetObject("label2.IconPadding"))));
            this.label2.Name = "label2";
            this.toolTip.SetToolTip(this.label2, resources.GetString("label2.ToolTip"));
            // 
            // cbDownloadedFiltersList
            // 
            resources.ApplyResources(this.cbDownloadedFiltersList, "cbDownloadedFiltersList");
            this.cbDownloadedFiltersList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.errorReporter.SetError(this.cbDownloadedFiltersList, resources.GetString("cbDownloadedFiltersList.Error"));
            this.cbDownloadedFiltersList.FormattingEnabled = true;
            this.errorReporter.SetIconAlignment(this.cbDownloadedFiltersList, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("cbDownloadedFiltersList.IconAlignment"))));
            this.errorReporter.SetIconPadding(this.cbDownloadedFiltersList, ((int)(resources.GetObject("cbDownloadedFiltersList.IconPadding"))));
            this.cbDownloadedFiltersList.Name = "cbDownloadedFiltersList";
            this.toolTip.SetToolTip(this.cbDownloadedFiltersList, resources.GetString("cbDownloadedFiltersList.ToolTip"));
            this.cbDownloadedFiltersList.SelectedIndexChanged += new System.EventHandler(this.cbDownloadedFiltersList_SelectedIndexChanged);
            // 
            // errorReporter
            // 
            this.errorReporter.ContainerControl = this;
            resources.ApplyResources(this.errorReporter, "errorReporter");
            // 
            // blockOptions
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "blockOptions";
            this.toolTip.SetToolTip(this, resources.GetString("$this.ToolTip"));
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