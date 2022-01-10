using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChildSafe
{
    public partial class mainHall : Form
    {
        public mainHall()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        string host = Path.GetPathRoot(Environment.SystemDirectory) + @"Windows\System32\drivers\etc\host";
        string defaultBlockListFile = "FilterSet.default";
        private void btStart_Click(object sender, EventArgs e)
        {
            if (File.Exists(defaultBlockListFile))
            {
                string [] list2Block =File.ReadAllLines(defaultBlockListFile);
                progressBar1.Maximum = list2Block.Length;
                using (StreamWriter writetext = new StreamWriter(host))
                {
                    foreach (string line in list2Block)
                    {
                        writetext.WriteLine(line);
                        progressBar1.Value++;
                    }
                }
                lbLoadingStatus.Text = "Completed";
            }
            else
            {

            }
        }

        private void options_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            blockOptions optionsForm = new blockOptions();
            optionsForm.ShowDialog();
        }

        private void btMenu_Click(object sender, EventArgs e)
        {
            contextMenu.Show(Cursor.Position.X-150, Cursor.Position.Y);
        }

        private void timerQuote_Tick(object sender, EventArgs e)
        {
            // Generate new text quote for every 5 seconds.
            promoteQuote newQuote = new promoteQuote();
            lbPromote.Text = newQuote.getRandomQuote();

        }

        private void mainHall_Load(object sender, EventArgs e)
        {
            // download default filter for child safe
            Thread downloadDefaultFilter = new Thread(() =>
            {
                WebClient client = new WebClient();
                client.DownloadFileAsync(new Uri("google.com"), "ChildSafeBaseFilter");
            }
            );
            // get the current state of program
            if ((Properties.Settings.Default["protectEnable"].ToString()) == "False")
            {
                pictureMainHall.Image = Properties.Resources.danger_128;
                btStart.Text = "START";

            }
            else
            {
                pictureMainHall.Image = Properties.Resources.check_green_256;
                btStart.Text = "STOP";
            }
        }

        private void filtersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filterBrowsing filterBrowsingForm = new filterBrowsing();
            filterBrowsingForm.ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            about aboutForm = new about();
            aboutForm.ShowDialog();
        }

        private void githubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/zeroclubvn/ChildSafe_Project_X15");
        }

        private void sendFeedbackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/zeroclubvn/ChildSafe_Project_X15/issues");
        }
    }
}
