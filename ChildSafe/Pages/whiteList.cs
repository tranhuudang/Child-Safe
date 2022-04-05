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
    public partial class whiteList : Form
    {
        public whiteList()
        {
            InitializeComponent();
        }

        private void btAdd2Table_Click(object sender, EventArgs e)
        {
            if (txUrl2AddWhiteList.Text.Length > 5)
            {
                tbWhitelist.Rows.Add(txUrl2AddWhiteList.Text);
                File.AppendAllText(ChildSafeAsset.whiteList, txUrl2AddWhiteList.Text + "\n");
                txUrl2AddWhiteList.Text = null;
            }
        }

        private void btRemove_Click(object sender, EventArgs e)
        {
            if ((numberOfRow != 1) && (selectedCellIndex != -1))
            {
                try
                {
                    string whitelist = File.ReadAllText(ChildSafeAsset.whiteList).Replace(tbWhitelist.CurrentCell.Value.ToString(), "");
                    File.WriteAllText(ChildSafeAsset.whiteList, whitelist);
                }
                catch (Exception)
                {

                    throw;
                }

                tbWhitelist.Rows.RemoveAt(selectedCellIndex);
                selectedCellIndex--;
                numberOfRow--;

            }
            else
            {
                btRemove.Enabled = false;
            }
        }
        int selectedCellIndex = -1;
        int numberOfRow = 1;
        private void tbWhitelist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void tbWhitelist_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            numberOfRow = tbWhitelist.Rows.Count;
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

        private void whiteList_Load(object sender, EventArgs e)
        {
            // load language
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
            // check state of whitelist in setting to whether or not it's enable
            if (Properties.Settings.Default["whiteListEnable"].ToString() == "True")
            {

                pnControlWhitelist.Enabled = true;
                tbWhitelist.Enabled = true;
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
                pnControlWhitelist.Enabled = false;
                tbWhitelist.Enabled = false;
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
            loadWhitelist();
        }
        void loadWhitelist()
        {
            if (File.Exists(ChildSafeAsset.whiteList))
            {
                string[] contents = File.ReadAllText(ChildSafeAsset.whiteList).Split('\n');
                foreach (string line in contents)
                {
                    if (line != "")
                        tbWhitelist.Rows.Add(line);
                }
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btCancel_Click_1(object sender, EventArgs e)
        {

        }

        private void btApply_Click(object sender, EventArgs e)
        {
            // remove item in whitelist out of host file
            if (File.Exists(ChildSafeAsset.whiteList))
            {
                string[] whitelist = File.ReadAllLines(ChildSafeAsset.whiteList);
                string onDutyAfterWhiteList = File.ReadAllText(ChildSafeAsset.onDutyFilters);
                foreach (string whiteLine in whitelist)
                {
                    if (onDutyAfterWhiteList.Contains(whiteLine))
                    {
                        MessageBox.Show("ok");
                        onDutyAfterWhiteList = onDutyAfterWhiteList.Replace(whiteLine, "whitelist");
                    }
                }
                File.WriteAllText(ChildSafeAsset.onDutyFilters, onDutyAfterWhiteList);
            }
        }

        private void btDisable_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default["whiteListEnable"].ToString() == "True")
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
                Properties.Settings.Default["whiteListEnable"] = false;
                pnControlWhitelist.Enabled = true;
                tbWhitelist.Enabled = true;
                if (File.Exists(ChildSafeAsset.whiteList_D))
                    File.Move(ChildSafeAsset.whiteList_D, ChildSafeAsset.whiteList);
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
                Properties.Settings.Default["whiteListEnable"] = true;
                pnControlWhitelist.Enabled = false;
                tbWhitelist.Enabled = false;
                if (File.Exists(ChildSafeAsset.whiteList_D))
                    File.Move(ChildSafeAsset.whiteList, ChildSafeAsset.whiteList_D);
            }
        }

        private void txUrl2AddWhiteList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txUrl2AddWhiteList_TextChanged(object sender, EventArgs e)
        {
            if (txUrl2AddWhiteList.Text.Length > 5)
            {
                btAdd2Table.Enabled = true;
            }
            else
            {
                btAdd2Table.Enabled = false;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
