using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning2._4
{
    public partial class FrmClipArt : Form
    {
#pragma warning disable IDE0052 // Remove unread private members
        private readonly List<F> figurer = new List<F>();
#pragma warning restore IDE0052 // Remove unread private members
        public FrmClipArt()
        {
            InitializeComponent();
        }

        private void BtnTriangel_Click(object sender, EventArgs e)
        {
            // Try to make new object
            try
            {
                // Making new triangel and taking in values
                Triangel nyTriangel = new Triangel(double.Parse(tbxBredd.Text), double.Parse(tbxHöjd.Text));
                // Adding made triangel in the listbox
                lbxFigurLista.Items.Add(nyTriangel);
            }
            // Catch Formmistake
            catch (FormatException)
            {
                MessageBox.Show("Fel inmatade värden.");
            }
        }

        private void BtnCirkel_Click(object sender, EventArgs e)
        {
            // Try to make a new object
            try
            {
                // Make a new circle and get in values
                Cirkel nyCirkel = new Cirkel(double.Parse(tbxBredd.Text), double.Parse(tbxHöjd.Text));
                // Put made circle in the listbox
                lbxFigurLista.Items.Add(nyCirkel);
            }
            // Catch formatmistake
            catch (FormatException)
            {
                MessageBox.Show("Fel inmatade värden.");
            }
        }

        private void BtnLinje_Click(object sender, EventArgs e)
        {
            // Try to make a new object
            try
            {
                // Make a new line and get in values
                Linje nyLinje = new Linje(double.Parse(tbxBredd.Text), double.Parse(tbxHöjd.Text));
                // Put the saved line in he listbox
                lbxFigurLista.Items.Add(nyLinje);
            }
            // Catch formatmistake
            catch (FormatException)
            {
                MessageBox.Show("Fel inmatade värden.");
            }
        }

        private void BtnArea_Click(object sender, EventArgs e)
        {
            // Reset the sum
            double summa = 0;
            // For ieach item in the listbox
            foreach (Figur F in lbxFigurLista.Items)
            {
                // In case the figure is triangle
                if (F is Triangel)
                {
                    // Add the calculated area to the sum
                    summa += (F as Triangel).BeräknaArea();
                }
                // In the case figure is a circle
                else if (F is Cirkel)
                {
                    // Add the calculated area to the sum
                    summa += (F as Cirkel).BeräknaArea();
                }
            }
            // Round the sum and show it also
            tbxArea.Text = Convert.ToString(Math.Round(summa, 2) + " cm²");
        }
    }
}