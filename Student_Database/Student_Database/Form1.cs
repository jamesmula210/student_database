using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Database
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label12_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult exit;
            exit = MessageBox.Show("Do you want to exit?","Student_Database",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            if (exit == DialogResult.Yes)
            {
                Application.Exit();
            }

        }
        void clearEverything(Control cont)
        { 
            foreach(Control c in cont.Controls)
            {
                if (c is TextBox)
                    ((TextBox)c).Clear();
                else
                    clearEverything(c);
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            clearEverything(this);
            cmbGender.Text = "";
            rtbTranscript.Text = "";
        }

        private void NumbersOnly(object sender, KeyPressEventArgs e)
        {
            int asciiCode = Convert.ToInt32(e.KeyChar);
            if ((asciiCode != 8))
            {
                if((asciiCode >= 48 && asciiCode <= 57))
                {
                    e.Handled = false;
                }
                else
                {
                    MessageBox.Show("Enter numbers only", "Error!Numbers only please", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    e.Handled = true;
                }
            }
        }
    }
}
