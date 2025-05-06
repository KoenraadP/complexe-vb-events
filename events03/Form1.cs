using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace events03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnUp_Click(object sender, EventArgs e)
        {
            // 'lange' manier

            // huidige locatie van de picturebox
            //int x = pbxCreo.Location.X;
            //int y = pbxCreo.Location.Y;

            // nieuw verticaal locatie punt instellen
            //y = y - 10;

            // verplaatsen
            //pbxCreo.Location = new Point(x, y);


            // 'korte' manier
            // Top = de afstand tussen de bovenrand (top)
            // van de form en de bovenrand van de picturebox
            // door deze 'kleiner' te maken, komt de picturebox
            // dichter bij de bovenrand te staan dus gaat hij omhoog
            pbxCreo.Top -= 10;
        }

        private void BtnDown_Click(object sender, EventArgs e)
        {
            pbxCreo.Top += 10;
        }

        private void BtnRight_Click(object sender, EventArgs e)
        {
            // Left = de afstand tussen de linkerrand (left) van de form
            // en de linkerrand van de picturebox
            pbxCreo.Left += 10;
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            // pbxCreo.Left -= 10;
            // langer alternatief
            pbxCreo.Left = pbxCreo.Left - 10;
        }

        private void BtnUpRight_Click(object sender, EventArgs e)
        {
            pbxCreo.Top -= 10;
            pbxCreo.Left += 10;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // als ik op het pijltje omhoog druk...
            if (e.KeyCode == Keys.Up)
            {
                // ...dan moet de picturebox omhoog
                pbxCreo.Top -= 10;
            }

            if (e.KeyCode == Keys.Right)
            {
                pbxCreo.Left += 10;
            }
        }
    }
}
