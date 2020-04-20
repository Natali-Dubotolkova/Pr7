using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gobutton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
        "Поздравляем! Вы смогли нажать на кнопку!",
        "Сообщение",
        MessageBoxButtons.OK,
        MessageBoxIcon.Information,
        MessageBoxDefaultButton.Button1,
        MessageBoxOptions.DefaultDesktopOnly);
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            Random r = new Random();
            button1.Left = r.Next(0, this.ClientSize.Width - button1.Width);
            button1.Top = r.Next(0, this.ClientSize.Height - button1.Height);
        }

    }
}
