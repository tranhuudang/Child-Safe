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
using System.IO;

namespace ChildSafe
{
    public partial class filterBrowsing : Form
    {
        Control newControl(string name, string descriptionText, string updateText, string licenceText)
        {
            Panel newPanel = new Panel();
            CheckBox newCheckbox = new CheckBox();
            Label description = new Label();
            Label update = new Label();
            Label licence = new Label();
            Label updateContent = new Label();
            Label licenceContent = new Label();
            newPanel.Size = new Size(493, 88);
            newPanel.BackColor = Color.Gainsboro;
            newPanel.Controls.Add(newCheckbox);
            newPanel.Controls.Add(description);
            newPanel.Controls.Add(update);
            newPanel.Controls.Add(licence);
            newPanel.Controls.Add(updateContent);
            newPanel.Controls.Add(licenceContent);

            newCheckbox.Location = new Point(10, 8);
            newCheckbox.Text = name;

            description.Location = new Point(10, 30);
            description.Size = new Size(470, 35);
            description.Text = descriptionText;

            updateContent.Text = "Update:";
            licenceContent.Text = "Licence:";
            updateContent.Location = new Point(11, 65);
            licenceContent.Location = new Point(175, 65);

            update.Text = updateText;
            update.Location = new Point(60, 65);
            licence.Location = new Point(226, 65);
            licence.Text = licenceText;
            return newPanel;
        }
        public filterBrowsing()
        {
            InitializeComponent();
        }
        string fileFilterUpdate = "FilterBaseUpdate";
        private void filterBrowsing_Load(object sender, EventArgs e)
        {
            //download list filter
            using (var client = new WebClient())
            {
                client.DownloadFile("https://raw.githubusercontent.com/zeroclubvn/ChildSafe_Project_X15/master/ChildSafe/filterListUpdate.txt", fileFilterUpdate);
            }
            // open file
            if (File.Exists(fileFilterUpdate))
            {
                // fomular of a custom panel

                // read from file the collection of all available filter
                string[] contents = File.ReadAllText(fileFilterUpdate).Split('@');
                foreach (string content in contents)
                {
                    if (content != "")
                    {
                        string[] filter = content.Split('>');
                        string name = filter[1];
                        string description = filter[2];
                        string update = filter[4];
                       // string licence = filter[5];
                        // add filters and it's description in to flowlayout list
                        flowLayoutSet.Controls.Add(newControl(name, description, update, ""));
                    }

                }
            }
        }
    }
}
