using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LudoGame
{
    public partial class Form1 : Form
    {
        Boolean red = false;
        int x = 3;
        int y = 586;
        int diceValue = 0;

        int[] position = new int[100];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox4.Image = Image.FromFile(@"C:\Users\Daniyal kukda\documents\visual studio 2013\Projects\LudoGame\LudoGame\Resources\1.png");
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            logics obj = new logics();
            diceValue = obj.rollDice(pictureBox4);
            label1.Text = diceValue.ToString();
           if (red == true)
           {
               x += 86;

               label2.Text = x.ToString();
               label3.Text = y.ToString();
           }
           if (label1.Text == "6" && red == false)
           {
               pictureBox6.Visible = true;
               pictureBox2.Visible = false;
               red = true;
               pictureBox6.Location = new Point(x, y);
               label2.Text = x.ToString();
               label3.Text = y.ToString();
           }
        }

        private void inisitalizeSnakeBite()
        {
            position[17] = -10;
            position[54] = -19;
            position[64] = -3;
            position[62] = -43;
            position[87] = -51;
            position[93] = -20;
            position[95] = -20;
            position[98] = -19;
        }
    }
}
