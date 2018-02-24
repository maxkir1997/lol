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
    class Class3 : Class1
    {
        public override void Draw(PictureBox cc)
        {
            Graphics g = cc.CreateGraphics();
            g.Clear(Color.WhiteSmoke);
            g.DrawEllipse(new Pen(Color.Red), 300, 80, 80, 80);
        }
    }
}