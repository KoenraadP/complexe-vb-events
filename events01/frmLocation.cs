using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace events01
{
    public partial class frmLocation : Form
    {
        public frmLocation()
        {
            InitializeComponent();
        }

        private void frmLocation_Click(object sender, EventArgs e)
        {
            
        }

        private void FrmLocation_MouseClick(object sender, MouseEventArgs e)
        {
            // MouseEventArgs bevatten properties die specifiek te maken hebbenn
            // met de muis/cursor
            // in lblX de 'X' positie van muis tonen waar geklikt werd
            lblX.Text = e.X.ToString();
            // in lblY de 'Y' positie van muis tonen waar geklikt werd
            lblY.Text = e.Y.ToString();

            // het panel verplaatsen naar de locatie waar geklikt werd
            // pnlLocation.Location = new Point(e.X, e.Y);

            // het panel bovenaan in de linkerhoek plaatsen
            // pnlLocation.Location = new Point(0, 0);

            // het panel onderaan rechts in de hoek plaatsen

            // code hieronder werkt niet volledig juist omdat er bepaalde
            // elementen van ons programma in de size extra meegerekend worden
            // bijvoorbeeld de balk bovenaan
            // int x = Width - pnlLocation.Width;
            // int y = Height - pnlLocation.Height;

            // clientsize is enkel het effectieve 'werkvlak'
            int x = ClientSize.Width - pnlLocation.Width;
            int y = ClientSize.Height - pnlLocation.Height;
            pnlLocation.Location = new Point(x, y);
        }
    }
}
