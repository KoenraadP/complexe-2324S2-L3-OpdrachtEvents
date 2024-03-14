using opdracht_events.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace opdracht_events
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                pictureBox1.Image = Resources.runright;
                pictureBox1.Left += 10;
            }

            if (e.KeyCode == Keys.Left)
            {
                pictureBox1.Image = Resources.runleft;
                pictureBox1.Left -= 10;
            }
        }
    }
}
