using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorPicker
{
    public partial class Form1 : Form
    {
        public int R;
        public int G;
        public int B;
        public Form1()
        {
            InitializeComponent();
            R = 125;
            G = 125;
            B = 125;
            textBox1.BackColor = Color.FromArgb(R, G, B);
        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            R = trackBar1.Value;
            textBox1.BackColor = Color.FromArgb(R, G, B);
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            G = trackBar2.Value;
            textBox1.BackColor = Color.FromArgb(R, G, B);
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            B = trackBar3.Value;
            textBox1.BackColor = Color.FromArgb(R, G, B);
        }

        private void textBox1_MouseMove(object sender, MouseEventArgs e)
        {
            string hex = string.Format("#{0:X2}{1:X2}{2:X2}", R, G, B);
            toolTip1.Show(hex, textBox1, 5000) ;
        }
    }
}
