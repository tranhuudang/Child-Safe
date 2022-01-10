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
        string host = Path.GetPathRoot(Environment.SystemDirectory) + @"Windows\System32\drivers\etc\hosts";
        string onDutyFilters = "OnDuty";
        string defaultChildSafeBaseFilter = "ChildSafeBaseFilter";
        string defaultChildSafeBaseFilter_Url = "https://raw.githubusercontent.com/zeroclubvn/ChildSafe_Project_X15/master/ChildSafe/defaultChildSafeFilter.txt";
        private void btStart_Click(object sender, EventArgs e)
        {
            // in options we have the oppotunity to add more filter to the block list, all fillter with be combined in OnDuty file. 
            // if user don't use option feature, application will look for ChildSafeBaseFilter which is the default filter of this program.
            // ChildSafeBaseFilter is downloaded when the app is openning and connecting to internet.
            if (File.Exists(onDutyFilters))
            {
                string [] list2Block =File.ReadAllLines(onDutyFilters);
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
            // we use default filter instead in case no option filter is added
            else if (File.Exists(defaultChildSafeBaseFilter))
            {
                string[] list2Block = File.ReadAllLines(defaultChildSafeBaseFilter);
                progressBar1.Maximum = list2Block.Length;
                using (StreamWriter writetext = new StreamWriter(host))
                {
                    foreach (string line in list2Block)
                    {
                        writetext.WriteLine("127.0.0.0 "+line);
                        progressBar1.Value++;
                    }
                }
                lbLoadingStatus.Text = "Completed";
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
                client.DownloadFileAsync(new Uri(defaultChildSafeBaseFilter_Url), defaultChildSafeBaseFilter);
            }
            );
            downloadDefaultFilter.Start();
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
