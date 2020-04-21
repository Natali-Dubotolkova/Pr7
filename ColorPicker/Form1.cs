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
        public string hex;
        public Form1()
        {
            InitializeComponent();
            R = 125;
            G = 125;
            B = 125;
            pictureBox1.BackColor = Color.FromArgb(R, G, B);
        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            R = trackBar1.Value;
            pictureBox1.BackColor = Color.FromArgb(R, G, B);
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            G = trackBar2.Value;
            pictureBox1.BackColor = Color.FromArgb(R, G, B);
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            B = trackBar3.Value;
            pictureBox1.BackColor = Color.FromArgb(R, G, B);
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            //"X2" indicates the string should be formatted in Hexadecimal
            hex = string.Format("#{0:X2}{1:X2}{2:X2}", R, G, B);
            toolTip1.Show(hex, pictureBox1, 2000) ;
            
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            Clipboard.SetText(hex);
            string enter = Clipboard.GetText();
            MessageBox.Show(enter, "Буфер обмена",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
