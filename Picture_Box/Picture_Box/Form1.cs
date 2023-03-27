using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Picture_Box
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //pictureBox1.Image = Image.FromFile(@"c:\picture.png");
            openFileDialog1.ShowDialog();
            string filepath = openFileDialog1.FileName;
            pic_mid.Image = Image.FromFile(filepath);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            pic_left.Image = Image.FromFile(@"c:\picture.png");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pic_right.Image = Image.FromFile(@"c:\picture.png");
        }
    }
}
