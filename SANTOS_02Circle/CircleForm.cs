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
    public partial class CircleForm : Form
    {
        public CircleForm()
        {
            InitializeComponent();
        }

        private void txtBoxCircum_TextChanged(object sender, EventArgs e)
        {
            // empty shit
            
        }

        private void btntotal_Click(object sender, EventArgs e)
        {
            int radius;
            double circum; // variables 
            double area;

            radius = Convert.ToInt32(txtBoxRadius.Text);
            circum = 2 * Math.PI * radius; // solution for circumference
            area = Math.PI * Math.Pow(radius, 2); // for area 

            area = (double)Math.Round(area, 2); // limits to 2 decimal
            circum = (double)Math.Round(circum, 2);


            txtBoxCircum.Text = circum.ToString();
            txtBoxArea.Text = area.ToString(); // shows value in text, and not in message box

            



        }
    }
}
