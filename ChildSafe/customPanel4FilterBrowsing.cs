using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace ChildSafe
{
    class customPanel4FilterBrowsing
    {
        
        Control newControl (string name, string descriptionText, string updateText, string licenceText)
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
            newCheckbox.Location = new Point(10, 10);
            description.Location = new Point(11, 30);
            description.Size = new Size(470, 35);
            updateContent.Text = "Update:";
            licenceContent.Text = "Licence:";
            updateContent.Location = new Point(11, 65);
            licenceContent.Location = new Point(175, 65);
            update.Location = new Point(66, 65);
            licence.Location = new Point(226, 65);
            return newPanel;
        }
    }
}
