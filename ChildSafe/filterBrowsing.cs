using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChildSafe
{
    public partial class filterBrowsing : Form
    {
        public filterBrowsing()
        {
            InitializeComponent();
        }

        private void filterBrowsing_Load(object sender, EventArgs e)
        {
            using (var client = new WebClient())
            {
                client.DownloadFile("https://raw.githubusercontent.com/zeroclubvn/ChildSafe_Project_X15/master/ChildSafe/filterListUpdate.txt", "FilterBaseUpdate");
            }
        }
    }
}
