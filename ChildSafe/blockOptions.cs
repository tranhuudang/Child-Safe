using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChildSafe
{
    public partial class blockOptions : Form
    {
        
        public blockOptions()
        {
            InitializeComponent();
        }

        private void btAdd2Table_Click(object sender, EventArgs e)
        {
            if (txUrl2AddBlackList.Text.Length > 5)
            {
                tbBlacklist.Rows.Add(txUrl2AddBlackList.Text);
                File.AppendAllText("BlackList", txUrl2AddBlackList.Text+"\n");
                txUrl2AddBlackList.Text = null;

            }

        }

        private void txUrl2AddBlackList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbBlacklist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txUrl2AddBlackList_TextChanged(object sender, EventArgs e)
        {
            if (txUrl2AddBlackList.Text.Length > 5)
            {
                btAdd2Table.Enabled = true;
            }
            else
            {
                btAdd2Table.Enabled = false;
            }
        }
        int selectedCellIndex = -1;
        int numberOfRow = 1;
        private void tbBlacklist_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            numberOfRow = tbBlacklist.Rows.Count;
            if (numberOfRow != 1)
            {
                btRemove.Enabled = true;
            }
            else
            {
                btRemove.Enabled = false;
            }
            selectedCellIndex = e.RowIndex;

        }


        private void btRemove_Click(object sender, EventArgs e)
        {

            if ((numberOfRow != 1) && (selectedCellIndex != -1))
            {
                try
                {
                    string blacklist = File.ReadAllText(ChildSafeAsset.blackList).Replace(tbBlacklist.CurrentCell.Value.ToString(), "");
                    File.WriteAllText(ChildSafeAsset.blackList, blacklist);
                }
                catch (Exception)
                {

                    throw;
                }
                
                tbBlacklist.Rows.RemoveAt(selectedCellIndex);
                selectedCellIndex--;
                numberOfRow--;
                
            }
            else
            {
                btRemove.Enabled = false;
            }
        }

        private void btFilterBrowsing_Click(object sender, EventArgs e)
        {
            filterBrowsing filterBrowsingForm = new filterBrowsing();
            if (filterBrowsingForm.ShowDialog() == DialogResult.OK)
            {
                loadDownloadedFilter();
            };
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void blockOptions_Load(object sender, EventArgs e)
        {
            
           
            // load language - this one should always go first because the initialize component will clear and rebuild all control
            switch (Properties.Settings.Default["language"].ToString())
            {
                case "English":
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");
                    Properties.Settings.Default["Language"] = "English";
                    break;
                case "Tiếng Việt":
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("vi-VN");
                    Properties.Settings.Default["Language"] = "Tiếng Việt";
                    break;
            }
            this.Controls.Clear();
            InitializeComponent();
            // change static text language
            switch (Properties.Settings.Default["language"].ToString())
            {
                case "English":
                    removeToolStripMenuItem.Text = "Remove";
                    break;
                case "Tiếng Việt":
                    removeToolStripMenuItem.Text = "Gỡ bỏ";
                    break;
            }
            // load up current active filter
            string[] filters = Properties.Settings.Default["listOnDutyFilters"].ToString().Split('>');
            if (filters.Length != 0)
                foreach (string item in filters)
                {
                    if (item != "")
                        listOnDutyFilters.Items.Add(item);
                }
            // check state of blacklist in setting to whether or not it's enable
            if (Properties.Settings.Default["blackListEnable"].ToString() == "True")
            {
                
                pnControlBlacklist.Enabled = true;
                tbBlacklist.Enabled = true;
                switch (Properties.Settings.Default["language"].ToString())
                {
                    case "English":
                        btDisable.Text = "Disable";
                        break;
                    case "Tiếng Việt":
                        btDisable.Text = "Vô hiệu";
                        break;
                }
            }
            else
            {
                pnControlBlacklist.Enabled = false;
                tbBlacklist.Enabled = false;
                switch (Properties.Settings.Default["language"].ToString())
                {
                    case "English":
                        btDisable.Text = "Enable";
                        break;
                    case "Tiếng Việt":
                        btDisable.Text = "Kích hoạt";
                        break;
                }
            }
            //
            loadBlacklist();
            loadDownloadedFilter();

        }
        void loadBlacklist()
        {
            if (File.Exists("Blacklist"))
            {
                string[] contents = File.ReadAllText("Blacklist").Split('\n');
                foreach(string line in contents)
                {
                    if(line!="")
                tbBlacklist.Rows.Add(line);
                }
            }
        }
        void loadDownloadedFilter()
        {
            FilterBox filterbox = new FilterBox();
            cbDownloadedFiltersList.DataSource= filterbox.getDownloadedFilter();
        }

        private void cbDownloadedFiltersList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbDownloadedFiltersList.Text != "") btAdd.Enabled = true;
            else btAdd.Enabled = false;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {

            foreach (string filterName in cbDownloadedFiltersList.Items)
            {

                if ((cbDownloadedFiltersList.Text == filterName) && (listOnDutyFilters.Items.IndexOf(cbDownloadedFiltersList.Text) == -1))
                {
                    listOnDutyFilters.Items.Add(filterName);
                }
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            string stringFilters = "";
            foreach(string item in listOnDutyFilters.Items)
            {
                stringFilters += item + ">";
            }
            Properties.Settings.Default["listOnDutyFilters"] = stringFilters;
            // read all text in chose filter and copy its contents to one file name OnDuty
            // when we back to home and hit start, app will looking for OnDuty file to move all web to hosts
            FilterBox filterbox = new FilterBox();
            filterbox.sendToPendingList(listOnDutyFilters);
            // save all current settings
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listOnDutyFilters.Items.RemoveAt(listOnDutyFilters.SelectedIndex);
        }
        
        private void listOnDutyFilters_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterBox filterbox = new FilterBox();
            lbDetails.Text = filterbox.getDownloadedFilterInfo(listOnDutyFilters.SelectedItem.ToString());
        }

        private void btDisable_Click(object sender, EventArgs e)
        {
              
            if (Properties.Settings.Default["blackListEnable"].ToString()=="True")
            {
                switch (Properties.Settings.Default["language"].ToString())
                {
                    case "English":
                        btDisable.Text = "Disable";
                        break;
                    case "Tiếng Việt":
                        btDisable.Text = "Vô hiệu";
                        break;
                }
                Properties.Settings.Default["blackListEnable"] = false;
                pnControlBlacklist.Enabled = true;
                tbBlacklist.Enabled = true;
                if(File.Exists("Blacklist-D"))
                File.Move("Blacklist-D", "Blacklist");
            }
            else
            {
                switch (Properties.Settings.Default["language"].ToString())
                {
                    case "English":
                        btDisable.Text = "Enable";
                        break;
                    case "Tiếng Việt":
                        btDisable.Text = "Kích hoạt";
                        break;
                }
                Properties.Settings.Default["blackListEnable"] = true;
                pnControlBlacklist.Enabled = false;
                tbBlacklist.Enabled = false;
                if (File.Exists("Blacklist"))
                    File.Move("Blacklist", "Blacklist-D");
            }

        }

        private void options_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            whiteList whiteListForm = new whiteList();
            whiteListForm.Show();
            
        }
    }
}
