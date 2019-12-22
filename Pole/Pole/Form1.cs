using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pole
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtbok_TextChanged(object sender, EventArgs e)
        {
            double bok;
            if (double.TryParse(txtbok.Text, out bok) && bok > 0)
            {

                txtpole.Text = Math.Pow(bok,2).ToString();
                txtobwod.Text = (bok * 4).ToString();
                labelkomunikat.Text = string.Empty;
            }
            else
            {
                labelkomunikat.Text = "Wpisz liczbe dodatnia";
                txtpole.Text = string.Empty;
                txtobwod.Text = string.Empty;
            }
        }

        private void txtpole_TextChanged(object sender, EventArgs e)
        {

        }

        private void btmclear_Click(object sender, EventArgs e)
        {
            //txtpole.Text = string.Empty;
            //txtobwod.Text = string.Empty;
            txtbok.Text = string.Empty;
            labelkomunikat.Text = "Wprowadz dane";
        }
    }
}
