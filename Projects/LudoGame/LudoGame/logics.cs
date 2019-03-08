using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LudoGame
{
    class logics
    {
        public int rollDice(PictureBox px)
        {
           int dice = 0;
            Random r = new Random();
            dice = r.Next(1, 7);

            px.Image = Image.FromFile(@"C:\Users\Daniyal kukda\documents\visual studio 2013\Projects\LudoGame\LudoGame\Resources\" + dice + ".png");
            px.SizeMode = PictureBoxSizeMode.StretchImage;

            return dice;
        }
    }
}
