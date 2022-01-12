using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
                txUrl2AddWhiteList.Text = null;
            }
        }

        private void btRemove_Click(object sender, EventArgs e)
        {

            if ((numberOfRow != 1) && (selectedCellIndex != -1))
            {
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
        }

        private void btSwitcher_Click(object sender, EventArgs e)
        {

        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btCancel_Click_1(object sender, EventArgs e)
        {

        }
    }
}
