using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

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
        string defaultChildSafeBaseFilter_Url = "https://raw.githubusercontent.com/zeroclubvn/Vietnamese-Trash-Websites-Filter/main/adult_websites";
        private void disableProtect()
        {
            // safely clear the block list without delete the file
            FileStream fileStream = File.Open(host, FileMode.Open); fileStream.SetLength(0);
            fileStream.Close();
            // change visual
            btStart.Text = "START";
            pictureMainHall.Image = Properties.Resources.danger_128;
            // change protected state
            Properties.Settings.Default["protectEnable"] = false;
            btStart.Enabled = true;
        }
        private void enableProtect()
        {
            panelLoading.Visible = true;
            // in options we have the oppotunity to add more filter to the block list, all fillter with be combined in OnDuty file. 
            // if user don't use option feature, application will look for ChildSafeBaseFilter which is the default filter of this program.
            // ChildSafeBaseFilter is downloaded when the app is openning and connecting to internet.
            if (File.Exists(onDutyFilters))
            {
                string[] list2Block = File.ReadAllText(onDutyFilters).Split('\n');
                progressBar1.Maximum = list2Block.Length;
                progressBar1.Value = 0;
                using (StreamWriter writetext = new StreamWriter(host))
                {
                    foreach (string line in list2Block)
                    {
                        if (line.StartsWith("#") || line.StartsWith("::") || line.StartsWith("fe80") || line == "")
                        {

                        }
                        else if (line.StartsWith("0.0.0.0") || line.StartsWith("127.0.0.1"))
                        {
                            writetext.WriteLine(line);
                        }
                        else
                        {
                            writetext.WriteLine("127.0.0.1 " + line);

                        }
                        progressBar1.Value++;
                    }
                    writetext.Close();
                }
                // delete onDuty file after finish using it
                File.Delete(onDutyFilters);
                lbLoadingStatus.Text = "Completed";
                panelLoading.Visible = false;
                btStart.Enabled = true;
            }
            // we use default filter instead in case no option filter is added
            else if (File.Exists(defaultChildSafeBaseFilter))
            {
                string[] list2Block = File.ReadAllText(defaultChildSafeBaseFilter).Split('\n');
                progressBar1.Maximum = list2Block.Length;
                progressBar1.Value = 0;

                using (StreamWriter writetext = new StreamWriter(host))
                {
                    foreach (string line in list2Block)
                    {
                        writetext.WriteLine("127.0.0.0 " + line);
                        progressBar1.Value++;
                    }
                    writetext.Close();

                }
                lbLoadingStatus.Text = "Completed";
                panelLoading.Visible = false;
                btStart.Enabled = true;
            }
            // change the visual
            btStart.Text = "STOP";
            pictureMainHall.Image = Properties.Resources.check_blue_128;
            // change protected state
            Properties.Settings.Default["protectEnable"] = true;
        }
        private void btStart_Click(object sender, EventArgs e)
        {
            btStart.Enabled = false;
            if (Properties.Settings.Default["protectEnable"].ToString() == "True")
            {
                disableProtect();
            }
            else
            {
                enableProtect();
            }
            Properties.Settings.Default.Save();
        }

        private void options_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // auto refresh filter data after save modifications in filter options
            blockOptions optionsForm = new blockOptions();
            if (optionsForm.ShowDialog() == DialogResult.OK)
            {
                if (Properties.Settings.Default["protectEnable"].ToString() == "True")
                {
                    btStart.Enabled = false;
                    refresh.Enabled = true;
                }
            }

        }

        private void btMenu_Click(object sender, EventArgs e)
        {
            contextMenu.Show(Cursor.Position.X - 150, Cursor.Position.Y);
        }

        private void timerQuote_Tick(object sender, EventArgs e)
        {
            // Generate new text quote for every 5 seconds.
            promoteQuote newQuote = new promoteQuote();
            if (Properties.Settings.Default["language"].ToString() == "English")
                lbPromote.Text = newQuote.getRandomQuote("en-US");
            else
                lbPromote.Text = newQuote.getRandomQuote("vi-VI");


        }

        private void mainHall_Load(object sender, EventArgs e)
        {
            // load current settings of the app
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
                default:
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");
                    Properties.Settings.Default["Language"] = "English";
                    break;
            }
            this.Controls.Clear();
            InitializeComponent();
            // other custom related to language change
            switch (Properties.Settings.Default["language"].ToString())
            {
                case "English":
                    englishToolStripMenuItem.Checked = true;
                    vietnamseToolStripMenuItem.Checked = false;
                    break;
                case "Tiếng Việt":
                    englishToolStripMenuItem.Checked = false;
                    vietnamseToolStripMenuItem.Checked = true;
                    break;
                default:
                    englishToolStripMenuItem.Checked = true;
                    vietnamseToolStripMenuItem.Checked = false;
                    break;

            }
            // load protection state
            if (Properties.Settings.Default["protectEnable"].ToString() == "True")
            {
                pictureMainHall.Image = Properties.Resources.check_blue_128;
                btStart.Text = "STOP";
            }
            else
            {
                pictureMainHall.Image = Properties.Resources.danger_128;
                btStart.Text = "START";
            }
            // download default filter for child safe
            Thread downloadDefaultFilter = new Thread(() =>
            {
                WebClient client = new WebClient();
                client.DownloadFileAsync(new Uri(defaultChildSafeBaseFilter_Url), defaultChildSafeBaseFilter);
            }
            );
            downloadDefaultFilter.Start();
            Version version = Assembly.GetExecutingAssembly().GetName().Version;
            this.Text += " v" + version.Major;
        }


        private void filtersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            blockOptions blockOptionForm = new blockOptions();
            blockOptionForm.ShowDialog();
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

        private void whitelistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            whiteList whiteListForm = new whiteList();
            whiteListForm.ShowDialog();
        }

        private void autoupdateFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void technicalSupportToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");
            Properties.Settings.Default["Language"] = "English";
            Properties.Settings.Default.Save();
            this.Controls.Clear();
            InitializeComponent();
        }

        private void vietnamseToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("vi-VI");
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("vi-VI");

            Properties.Settings.Default["Language"] = "Tiếng Việt";
            Properties.Settings.Default.Save();
            this.Controls.Clear();
            InitializeComponent();

        }

        private void btIgnore_Click(object sender, EventArgs e)
        {
            gbUpdate.Visible = false;
        }

        private void btDownload_Click(object sender, EventArgs e)
        {
            Thread setup = new Thread(() =>
            {
                WebClient downloadSetup = new WebClient();
                downloadSetup.DownloadFileCompleted += new AsyncCompletedEventHandler(downloadSetup_DownloadFileCompleted);
                downloadSetup.DownloadFileAsync(new Uri("https://github.com/zeroclubvn/ChildSafe_Project_X15/raw/master/ChildSafe/Setup/ChildSafe_Setup.msi"), "ChildSafe_Setup.msi");

            });
            setup.Start();
        }
        void downloadSetup_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate
            {

                if (File.Exists("ChildSafe_Setup.msi"))
                {
                    if (File.Exists("ChildSafeUpdater.exe"))
                    {
                        if (MessageBox.Show("Download completed, do you want to process update now?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            Process.Start("ChildSafeUpdater.exe");
                            this.Close();
                        }
                    }
                }

            });
        }

        private void checkForUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                XmlDocument updateFile = new XmlDocument();
                updateFile.Load("https://raw.githubusercontent.com/zeroclubvn/ChildSafe_Project_X15/master/ChildSafe/updateInfo.xml" + "?" + DateTime.Now.Ticks.ToString());
                Version netVersion = new Version(updateFile.SelectSingleNode("//currentVersion/version").InnerText);
                string describe = updateFile.SelectSingleNode("//currentVersion/describe").InnerText;
                string linkSetup = updateFile.SelectSingleNode("//path").InnerText;
                Version currentVersion = Assembly.GetExecutingAssembly().GetName().Version;
                if (netVersion > currentVersion)
                {
                    gbUpdate.Visible = true;
                    lbUpdateDetail.Text = describe;
                }
                else
                {
                    MessageBox.Show("You're running the lastest version of Child Safe!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Can't connect to the internet!");
                throw;
            }

        }

        private void refresh_Tick(object sender, EventArgs e)
        {
            if (refresh.Tag != null)
            {
                refresh.Enabled = false;
                // now enable protect again after 2 second
                enableProtect();
                refresh.Tag = null;
            }
            else
            {

                disableProtect();
                refresh.Tag = "DisableProtect_OK";
            }
        }
    }
}
