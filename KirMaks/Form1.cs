using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KirMaks
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Class2 g = new Class2();
            g.Draw(pictureBox1);
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            Class3 g = new Class3();
            g.Draw(pictureBox1);
        }
    }
}
