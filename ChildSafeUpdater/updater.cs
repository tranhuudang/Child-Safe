using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChildSafeUpdater
{
    public partial class updater : Form
    {
        public updater()
        {
            InitializeComponent();
        }

        private void updater_Load(object sender, EventArgs e)
        {

        }

        private void numStage_ValueChanged(object sender, EventArgs e)
        {
           

        }

        private void clearFile_Tick(object sender, EventArgs e)
        {
            clearFile.Enabled = false;
            string currentDir = Directory.GetCurrentDirectory();
            string[] files = Directory.GetFiles(currentDir);

            string[] keepAliveFile = { "ChildSafeUpdater.exe", "ChildSafe_Setup.msi", "ChildSafeUpdater.exe.config", "ChildSafeUpdater.pdb" };
            foreach (string file in files)
            {
                bool exist = false;
                foreach (string fileName in keepAliveFile)
                {

                    if (file == currentDir + @"\" + fileName)
                    {
                        exist = true;
                        break;
                    }
                    else
                        exist = false;

                }
                if (!exist) File.Delete(file);
            }
            startInstall.Enabled = true;
        }

        private void startInstall_Tick(object sender, EventArgs e)
        {
            startInstall.Enabled = false;
            Process.Start("ChildSafe_Setup.msi");
        }
    }
}
