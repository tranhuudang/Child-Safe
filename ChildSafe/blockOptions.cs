using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
                btReportUrl2Server.Enabled = true;
            }
            else
            {
                btAdd2Table.Enabled = false;
                btReportUrl2Server.Enabled = false;
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
    }
}
