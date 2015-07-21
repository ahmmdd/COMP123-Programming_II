using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week11_StudentRegistration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.centennialcollege.ca");
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string values = "";
            string studentStatus;
            
            if(rbFullTime.Checked)
                studentStatus = "Full Time";
            else if(rbPartTime.Checked)
                studentStatus = "Part Time";
            else studentStatus = "Status not set";

            string programs = "";
            foreach(object element in lbxSubjects.SelectedItems) {
                programs += element.ToString() + " ";
            }

            values += txtFullName.Text + "\n";
            values += dtpRegDate.Value.ToString() + "\n";
            values += studentStatus + "\n";
            values += cmbProgram.SelectedItem + "\n";
            values += programs;

            MessageBox.Show(values);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void rbFullTime_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dtpRegDate_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
