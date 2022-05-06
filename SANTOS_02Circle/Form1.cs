using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SANTOS_02Circle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtBoxName.Text == "admin" && txtBoxPass.Text == "password" )
            {
                CircleForm circleForm = new CircleForm();
                circleForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Incorrect, try again");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void shwButton_Click(object sender, EventArgs e)
        {
            if (txtBoxPass.PasswordChar == '*')
            {
                button1.BringToFront();
                txtBoxPass.PasswordChar = '\0';
            }
        }

        private void hideBtn_Click(object sender, EventArgs e)
        {
            if (txtBoxPass.PasswordChar == '\0')
            {
                button1.BringToFront();
                txtBoxPass.PasswordChar = '*';
            }
        }
    }
 }

