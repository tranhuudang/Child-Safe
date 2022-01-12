using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChildSafe
{
    public partial class about : Form
    {
        public about()
        {
            InitializeComponent();
        }

        private void linkGithub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/zeroclubvn/ChildSafe_Project_X15");

        }

        private void about_Load(object sender, EventArgs e)
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
    }
}
