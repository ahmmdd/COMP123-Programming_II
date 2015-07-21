using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week10_CountClicks
{
    public partial class CountClicks : Form
    {
        int clickCounter;
        Color oldcolor;
        public CountClicks()
        {
            InitializeComponent();
            clickCounter = 0;
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            clickCounter++;
            lblCounter.Text = "You have clicked " + clickCounter + " time(s).";
            //lblCounter.Text = e.ToString();
        }

        private void btnClick_MouseHover(object sender, EventArgs e)
        {
            oldcolor = btnClick.BackColor;
            btnClick.BackColor = Color.Blue;
        }

        private void btnClick_MouseLeave(object sender, EventArgs e)
        {
            btnClick.BackColor = oldcolor;
        }
    }
}
