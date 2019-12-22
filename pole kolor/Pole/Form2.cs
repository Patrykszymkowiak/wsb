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
    public partial class Color : Form
    {
        public Color()
        {
            InitializeComponent();
        }

        private void btmzamk1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btmzamk2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if(panel1.Visible)
            {
                panel1.Visible = false;
            }
            else
            {
                panel1.Visible = true;
            }
        }

        private void txtbok_TextChanged(object sender, EventArgs e)
        {
            int bok;

            if(int.TryParse(txtbok.Text, out bok) && bok <= 200)
            {
                panel1.Height = bok;
                panel1.Width = bok;
            }
            else
            {
                labelkomunikat.Text = "Wprowadzono błędne dane";
            }
        }

        private void btmkolor_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            panel1.BackColor = colorDialog1.Color;
        }
    }
}
