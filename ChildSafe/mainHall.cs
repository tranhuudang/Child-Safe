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
    public partial class mainHall : Form
    {
        public mainHall()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btStart_Click(object sender, EventArgs e)
        {

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

        }
    }
}
