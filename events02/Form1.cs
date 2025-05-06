using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace events02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CbxLanguages_SelectedIndexChanged(object sender, EventArgs e)
        {
            // tekst en vlag aanpassen volgens de gemaakte keuze
            switch (cbxLanguages.SelectedItem)
            {
                case "Nederlands":
                    lblGreeting.Text = "Goedemorgen!";
                    pbxFlag.Image = Properties.Resources.Flag_NL;
                    break;
                case "English":
                    lblGreeting.Text = "Good morning!";
                    pbxFlag.Image = Properties.Resources.Flag_UK;
                    break;
                case "Français":
                    lblGreeting.Text = "Bonjour!";
                    pbxFlag.Image = Properties.Resources.Flag_FR;
                    break;
                case "Deutsch":
                    lblGreeting.Text = "Guten Morgen!";
                    pbxFlag.Image = Properties.Resources.Flag_DE;
                    break;
            }
        }
    }
}
