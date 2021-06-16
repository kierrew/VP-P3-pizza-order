using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson3
{
    public partial class Form1 : Form
    {
        double total = 0.00;

        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            /*int drinks = 0;
            bool result = false;
            result = int.TryParse(tBoxDrinks.Text, out drinks);
            if(result == true)
            {
                if(drinks < 0)
                {
                    drinks = 0;
                }
                total += (drinks * 1.00);
            }*/
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            //determine cost for size
            if (rButtonSmall.Checked == true)
            {
                total = 7.25;
            }
            else if (rButtonMedium.Checked == true)
            {
                total = 13.75;
            }
            else if (rButtonLarge.Checked == true)
            {
                total = 16.50;
            }

            //determine cost for crust
            if (rButtonThick.Checked == true)
            {
                total += 1;
            }
            else if (rButtonPan.Checked == true)
            {
                total += 1.50;
            }

            //determine cost of sides
            if (checkBoxSalad.Checked == true)
            {
                total += 1;
            }
            if (checkBoxCheeseBread.Checked == true)
            {
                total += 1;
            }
            if (checkBoxFriedCheeseSticks.Checked == true)
            {
                total += 1;
            }

            //determine cost of toppings
            if (checkBoxBacon.Checked == true)
            {
                total += .5;
            }
            if (checkBoxBlackOlives.Checked == true)
            {
                total += .5;
            }
            if (checkBoxGreenOlives.Checked == true)
            {
                total += .5;
            }
            if (checkBoxGreenPeppers.Checked == true)
            {
                total += .5;
            }
            if (checkBoxHamburger.Checked == true)
            {
                total += .5;
            }
            if (checkBoxMushrooms.Checked == true)
            {
                total += .5;
            }
            if (checkBoxOnions.Checked == true)
            {
                total += .5;
            }
            if (checkBoxSausage.Checked == true)
            {
                total += .5;
            }

            //adds the price of the drinks
            int drinks = 0;
            bool result = false;
            result = int.TryParse(tBoxDrinks.Text, out drinks);
            if (result == true)
            {
                if (drinks < 0)
                {
                    drinks = 0;
                }
                total += (drinks * 1.00);
            }

            //creates confirmation message box 
            DialogResult dialogResult = MessageBox.Show("Your total is " + total.ToString("C") + "\n Is this what you want?", "Confimation", MessageBoxButtons.YesNo);
            if(dialogResult == DialogResult.Yes)
            {
                total = 0;
                MessageBox.Show("Thank you for your order");
                
                tBoxDrinks.Text = "0";

                if (checkBoxSalad.Checked == true)
                {
                    checkBoxSalad.Checked = false;
                }
                if (checkBoxCheeseBread.Checked == true)
                {
                    checkBoxCheeseBread.Checked = false;
                }
                if (checkBoxFriedCheeseSticks.Checked == true)
                {
                    checkBoxFriedCheeseSticks.Checked = false;
                }

                //determine cost of toppings
                if (checkBoxBacon.Checked == true)
                {
                    checkBoxBacon.Checked = false;
                }
                if (checkBoxBlackOlives.Checked == true)
                {
                    checkBoxBlackOlives.Checked = false;
                }
                if (checkBoxGreenOlives.Checked == true)
                {
                    checkBoxGreenOlives.Checked = false;
                }
                if (checkBoxGreenPeppers.Checked == true)
                {
                    checkBoxGreenPeppers.Checked = false;
                }
                if (checkBoxHamburger.Checked == true)
                {
                    checkBoxHamburger.Checked = false;
                }
                if (checkBoxMushrooms.Checked == true)
                {
                    checkBoxMushrooms.Checked = false;
                }
                if (checkBoxOnions.Checked == true)
                {
                    checkBoxOnions.Checked = false;
                }
                if (checkBoxSausage.Checked == true)
                {
                    checkBoxSausage.Checked = false;
                }

                rButtonSmall.Checked = true;
                rButtonThin.Checked = true;
            }
        }

        private void btnAboutUs_Click(object sender, EventArgs e)
        {
            MessageBox.Show("All ingredients are fresh when the pizza is delivered and if you have any questions "
                            + "about the amount of fat, salt, or calories in the pizza then you probably should not order one.");
        }

        private void rButtonSmall_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void groupBoxSize_Enter(object sender, EventArgs e)
        {
            /*if(rButtonSmall.Checked == true)
            {
                total = 7.25;
            }
            else if (rButtonMedium.Checked == true)
            {
                total = 13.75;
            }
            else if(rButtonLarge.Checked == true)
            {
                total = 16.50;
            }*/
        }

        private void groupBoxCrust_Enter(object sender, EventArgs e)
        {
            /*if(rButtonThick.Checked == true)
            {
                total += 1;
            }
            else if (rButtonPan.Checked == true)
            {
                total += 1.50;
            }*/
        }

        private void groupBoxSides_Enter(object sender, EventArgs e)
        {
            /*if(checkBoxSalad.Checked == true)
            {
                total += 1;
            }
            if (checkBoxCheeseBread.Checked == true)
            {
                total += 1;
            }
            if (checkBoxFriedCheeseSticks.Checked == true)
            {
                total += 1;
            }*/
        }

        private void groupBoxToppings_Enter(object sender, EventArgs e)
        {
            /*if (checkBoxBacon.Checked == true)
            {
                total += .5;
            }
            if (checkBoxBlackOlives.Checked == true)
            {
                total += .5;
            }
            if (checkBoxGreenOlives.Checked == true)
            {
                total += .5;
            }
            if (checkBoxGreenPeppers.Checked == true)
            {
                total += .5;
            }
            if (checkBoxHamburger.Checked == true)
            {
                total += .5;
            }
            if (checkBoxMushrooms.Checked == true)
            {
                total += .5;
            }
            if (checkBoxOnions.Checked == true)
            {
                total += .5;
            }
            if (checkBoxSausage.Checked == true)
            {
                total += .5;
            }*/
        }
    }
}
