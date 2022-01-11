using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
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
        string downloadedFiltersFolder = "FilterBase";
        private void blockOptions_Load(object sender, EventArgs e)
        {
            loadDownloadedFilter();

        }
        void loadDownloadedFilter()
        {
            cbDownloadedFiltersList.Items.Clear();
            // get all the file name in BaseFilter folder and put it in combobox list downloaded filters
            if (Directory.Exists(downloadedFiltersFolder))
            {
                string[] downloadedFilters = Directory.GetFiles(downloadedFiltersFolder);
                foreach (string file in downloadedFilters)
                {
                    string filterName = file.Substring(file.LastIndexOf('\\') + 1).Replace('_',' ');
                    cbDownloadedFiltersList.Items.Add(filterName);
                }
            }
        }

        private void cbDownloadedFiltersList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbDownloadedFiltersList.Text != "") btAdd.Enabled = true;
            else btAdd.Enabled = false;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {

            foreach(string filterName in cbDownloadedFiltersList.Items)
            {
                
                if ((cbDownloadedFiltersList.Text== filterName)&&(listOnDutyFilters.Items.IndexOf(cbDownloadedFiltersList.Text)==-1))
                {
                    listOnDutyFilters.Items.Add(filterName);
                }
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {

        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listOnDutyFilters.Items.RemoveAt(listOnDutyFilters.SelectedIndex);
        }
        string fileFilterUpdate = "FilterBaseUpdate";
        private void listOnDutyFilters_SelectedIndexChanged(object sender, EventArgs e)
        {
            // open file
            if (File.Exists(fileFilterUpdate))
            {
                // fomular of a custom panel

                // read from file the collection of all available filter
                string[] contents = File.ReadAllText(fileFilterUpdate).Split('@');
                foreach (string content in contents)
                {
                    if (content.Contains("@>"+cbDownloadedFiltersList))
                    {
                        string[] filter = content.Split('>');
                        string name = filter[1];
                        string description = filter[2];
                        string linkFile = filter[3];
                        string update = filter[4];
                        string licence = filter[5];
                        // add filters and it's description in to flowlayout list
                        //flowLayoutSet.Controls.Add(newControl(name, description, linkFile, update, licence));
                    }

                }
            }
        }
    }
}
