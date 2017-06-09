// Zailyn Tamayo

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drink_Dispenser_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Dispense button clicked
        private void Dispensebutton_Click(object sender, EventArgs e)
        {
            // User can only select a cold drink or a hot drink
            if (PepsiradioButton.Checked == true | DietradioButton.Checked == true |
                RTearadioButton.Checked == true | PTearadioButton.Checked == true |
                SMradioButton.Checked == true | WaterradioButton.Checked == true &&
                CoffeeradioButton.Checked == true | TearadioButton.Checked == true |
                HCradioButton.Checked == true | CreamcheckBox.Checked == true |
                SugarcheckBox.Checked == true | HoneycheckBox.Checked == true)
            {
                // Message to clear selection appears if user chooses both cold and hot
                MessageBox.Show("Please clear selection before choosing a Drink!");
            }
                // Cold drinks selection
            else if (PepsiradioButton.Checked == true)
                MessageBox.Show("Pepsi dispensed!");
            else if (DietradioButton.Checked == true)
                MessageBox.Show("Diet Pepsi dispensed!");
            else if (RTearadioButton.Checked == true)
                MessageBox.Show("Brisk Raspberry Tea dispensed!");
            else if (PTearadioButton.Checked == true)
                MessageBox.Show("Brisk Peach Tea dispensed!");
            else if (SMradioButton.Checked == true)
                MessageBox.Show("Sierra Mist dispensed!");
            else if (WaterradioButton.Checked == true)
                MessageBox.Show("AquaFina dispensed!");

                // Hot drinks selection
            else if (HCradioButton.Checked == true)
                MessageBox.Show("Hot Chocolate dispensed!");
            else if (TearadioButton.Checked == true)
            {
                // Extra options for tea
                if (CreamcheckBox.Checked == true && SugarcheckBox.Checked == false && HoneycheckBox.Checked == false)
                    MessageBox.Show("Tea with Cream dispensed!");
                else if (CreamcheckBox.Checked == true && SugarcheckBox.Checked == true)
                    MessageBox.Show("Tea with Cream and Sugar dispensed!");
                else if (CreamcheckBox.Checked == true && HoneycheckBox.Checked == true)
                    MessageBox.Show("Tea with Cream and Honey dispensed!");
                else if (SugarcheckBox.Checked == true && CreamcheckBox.Checked == false && HoneycheckBox.Checked == false)
                    MessageBox.Show("Tea with Sugar dispensed!");
                else if (HoneycheckBox.Checked == true && CreamcheckBox.Checked == false && SugarcheckBox.Checked == false)
                    MessageBox.Show("Tea with Honey dispensed!");
                else
                    MessageBox.Show("Hot Tea dispensed!");
            }
            else if (CoffeeradioButton.Checked == true)
            {
                //Extra options for coffee
                if (CreamcheckBox.Checked == true && SugarcheckBox.Checked == false && HoneycheckBox.Checked == false)
                    MessageBox.Show("Coffee with Cream dispensed!");
                else if (CreamcheckBox.Checked == true && SugarcheckBox.Checked == true)
                    MessageBox.Show("Coffee with Cream and Sugar dispensed!");
                else if (CreamcheckBox.Checked == true && HoneycheckBox.Checked == true)
                    MessageBox.Show("Coffee with Cream and Honey dispensed!");
                else if (SugarcheckBox.Checked == true && CreamcheckBox.Checked == false && HoneycheckBox.Checked == false)
                    MessageBox.Show("Coffee with Sugar dispensed!");
                else if (HoneycheckBox.Checked == true && CreamcheckBox.Checked == false && SugarcheckBox.Checked == false)
                    MessageBox.Show("Coffee with Honey dispensed!");
                else
                    MessageBox.Show("Black Coffee dispensed!");
            }
           
        }

        // Clear button clicked
        private void Clearbutton_Click(object sender, EventArgs e)
        {
            // Clears all selections
            PepsiradioButton.Checked = false;
            DietradioButton.Checked = false;
            RTearadioButton.Checked = false;
            PTearadioButton.Checked = false;
            SMradioButton.Checked = false;
            WaterradioButton.Checked = false;
            CoffeeradioButton.Checked = false;
            TearadioButton.Checked = false;
            HCradioButton.Checked = false;
            CreamcheckBox.Checked = false;
            SugarcheckBox.Checked = false;
            HoneycheckBox.Checked = false;
        }

        // Exit button clicked
        private void Exitbutton_Click(object sender, EventArgs e)
        {
            // Exits program
            this.Close();
        }
    }
}
