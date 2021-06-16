namespace Lesson3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rButtonSmall = new System.Windows.Forms.RadioButton();
            this.rButtonMedium = new System.Windows.Forms.RadioButton();
            this.rButtonLarge = new System.Windows.Forms.RadioButton();
            this.groupBoxSize = new System.Windows.Forms.GroupBox();
            this.rButtonThin = new System.Windows.Forms.RadioButton();
            this.rButtonThick = new System.Windows.Forms.RadioButton();
            this.rButtonPan = new System.Windows.Forms.RadioButton();
            this.groupBoxCrust = new System.Windows.Forms.GroupBox();
            this.checkBoxCheeseBread = new System.Windows.Forms.CheckBox();
            this.checkBoxSalad = new System.Windows.Forms.CheckBox();
            this.checkBoxFriedCheeseSticks = new System.Windows.Forms.CheckBox();
            this.checkBoxBacon = new System.Windows.Forms.CheckBox();
            this.checkBoxBlackOlives = new System.Windows.Forms.CheckBox();
            this.checkBoxGreenOlives = new System.Windows.Forms.CheckBox();
            this.checkBoxSausage = new System.Windows.Forms.CheckBox();
            this.groupBoxSides = new System.Windows.Forms.GroupBox();
            this.checkBoxMushrooms = new System.Windows.Forms.CheckBox();
            this.checkBoxHamburger = new System.Windows.Forms.CheckBox();
            this.checkBoxGreenPeppers = new System.Windows.Forms.CheckBox();
            this.checkBoxOnions = new System.Windows.Forms.CheckBox();
            this.groupBoxToppings = new System.Windows.Forms.GroupBox();
            this.tBoxDrinks = new System.Windows.Forms.TextBox();
            this.lblDrinks = new System.Windows.Forms.Label();
            this.btnAboutUs = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.groupBoxSize.SuspendLayout();
            this.groupBoxCrust.SuspendLayout();
            this.groupBoxSides.SuspendLayout();
            this.groupBoxToppings.SuspendLayout();
            this.SuspendLayout();
            // 
            // rButtonSmall
            // 
            this.rButtonSmall.AutoSize = true;
            this.rButtonSmall.Checked = true;
            this.rButtonSmall.Location = new System.Drawing.Point(15, 23);
            this.rButtonSmall.Name = "rButtonSmall";
            this.rButtonSmall.Size = new System.Drawing.Size(50, 17);
            this.rButtonSmall.TabIndex = 0;
            this.rButtonSmall.TabStop = true;
            this.rButtonSmall.Text = "Small";
            this.rButtonSmall.UseVisualStyleBackColor = true;
            this.rButtonSmall.CheckedChanged += new System.EventHandler(this.rButtonSmall_CheckedChanged);
            // 
            // rButtonMedium
            // 
            this.rButtonMedium.AutoSize = true;
            this.rButtonMedium.Location = new System.Drawing.Point(15, 77);
            this.rButtonMedium.Name = "rButtonMedium";
            this.rButtonMedium.Size = new System.Drawing.Size(62, 17);
            this.rButtonMedium.TabIndex = 1;
            this.rButtonMedium.Text = "Medium";
            this.rButtonMedium.UseVisualStyleBackColor = true;
            // 
            // rButtonLarge
            // 
            this.rButtonLarge.AutoSize = true;
            this.rButtonLarge.Location = new System.Drawing.Point(15, 131);
            this.rButtonLarge.Name = "rButtonLarge";
            this.rButtonLarge.Size = new System.Drawing.Size(52, 17);
            this.rButtonLarge.TabIndex = 2;
            this.rButtonLarge.Text = "Large";
            this.rButtonLarge.UseVisualStyleBackColor = true;
            // 
            // groupBoxSize
            // 
            this.groupBoxSize.Controls.Add(this.rButtonSmall);
            this.groupBoxSize.Controls.Add(this.rButtonLarge);
            this.groupBoxSize.Controls.Add(this.rButtonMedium);
            this.groupBoxSize.Location = new System.Drawing.Point(37, 32);
            this.groupBoxSize.Name = "groupBoxSize";
            this.groupBoxSize.Size = new System.Drawing.Size(123, 178);
            this.groupBoxSize.TabIndex = 3;
            this.groupBoxSize.TabStop = false;
            this.groupBoxSize.Text = "Size";
            this.groupBoxSize.Enter += new System.EventHandler(this.groupBoxSize_Enter);
            // 
            // rButtonThin
            // 
            this.rButtonThin.AutoSize = true;
            this.rButtonThin.Checked = true;
            this.rButtonThin.Location = new System.Drawing.Point(15, 65);
            this.rButtonThin.Name = "rButtonThin";
            this.rButtonThin.Size = new System.Drawing.Size(46, 17);
            this.rButtonThin.TabIndex = 4;
            this.rButtonThin.TabStop = true;
            this.rButtonThin.Text = "Thin";
            this.rButtonThin.UseVisualStyleBackColor = true;
            // 
            // rButtonThick
            // 
            this.rButtonThick.AutoSize = true;
            this.rButtonThick.Location = new System.Drawing.Point(15, 125);
            this.rButtonThick.Name = "rButtonThick";
            this.rButtonThick.Size = new System.Drawing.Size(52, 17);
            this.rButtonThick.TabIndex = 5;
            this.rButtonThick.Text = "Thick";
            this.rButtonThick.UseVisualStyleBackColor = true;
            // 
            // rButtonPan
            // 
            this.rButtonPan.AutoSize = true;
            this.rButtonPan.Location = new System.Drawing.Point(15, 185);
            this.rButtonPan.Name = "rButtonPan";
            this.rButtonPan.Size = new System.Drawing.Size(44, 17);
            this.rButtonPan.TabIndex = 6;
            this.rButtonPan.Text = "Pan";
            this.rButtonPan.UseVisualStyleBackColor = true;
            // 
            // groupBoxCrust
            // 
            this.groupBoxCrust.Controls.Add(this.rButtonThin);
            this.groupBoxCrust.Controls.Add(this.rButtonPan);
            this.groupBoxCrust.Controls.Add(this.rButtonThick);
            this.groupBoxCrust.Location = new System.Drawing.Point(37, 276);
            this.groupBoxCrust.Name = "groupBoxCrust";
            this.groupBoxCrust.Size = new System.Drawing.Size(162, 237);
            this.groupBoxCrust.TabIndex = 7;
            this.groupBoxCrust.TabStop = false;
            this.groupBoxCrust.Text = "Crust";
            this.groupBoxCrust.Enter += new System.EventHandler(this.groupBoxCrust_Enter);
            // 
            // checkBoxCheeseBread
            // 
            this.checkBoxCheeseBread.AutoSize = true;
            this.checkBoxCheeseBread.Location = new System.Drawing.Point(24, 42);
            this.checkBoxCheeseBread.Name = "checkBoxCheeseBread";
            this.checkBoxCheeseBread.Size = new System.Drawing.Size(93, 17);
            this.checkBoxCheeseBread.TabIndex = 8;
            this.checkBoxCheeseBread.Text = "Cheese Bread";
            this.checkBoxCheeseBread.UseVisualStyleBackColor = true;
            // 
            // checkBoxSalad
            // 
            this.checkBoxSalad.AutoSize = true;
            this.checkBoxSalad.Location = new System.Drawing.Point(24, 81);
            this.checkBoxSalad.Name = "checkBoxSalad";
            this.checkBoxSalad.Size = new System.Drawing.Size(53, 17);
            this.checkBoxSalad.TabIndex = 9;
            this.checkBoxSalad.Text = "Salad";
            this.checkBoxSalad.UseVisualStyleBackColor = true;
            // 
            // checkBoxFriedCheeseSticks
            // 
            this.checkBoxFriedCheeseSticks.AutoSize = true;
            this.checkBoxFriedCheeseSticks.Location = new System.Drawing.Point(24, 120);
            this.checkBoxFriedCheeseSticks.Name = "checkBoxFriedCheeseSticks";
            this.checkBoxFriedCheeseSticks.Size = new System.Drawing.Size(122, 17);
            this.checkBoxFriedCheeseSticks.TabIndex = 10;
            this.checkBoxFriedCheeseSticks.Text = "Fried CHeese Sticks";
            this.checkBoxFriedCheeseSticks.UseVisualStyleBackColor = true;
            // 
            // checkBoxBacon
            // 
            this.checkBoxBacon.AutoSize = true;
            this.checkBoxBacon.Location = new System.Drawing.Point(6, 42);
            this.checkBoxBacon.Name = "checkBoxBacon";
            this.checkBoxBacon.Size = new System.Drawing.Size(57, 17);
            this.checkBoxBacon.TabIndex = 11;
            this.checkBoxBacon.Text = "Bacon";
            this.checkBoxBacon.UseVisualStyleBackColor = true;
            // 
            // checkBoxBlackOlives
            // 
            this.checkBoxBlackOlives.AutoSize = true;
            this.checkBoxBlackOlives.Location = new System.Drawing.Point(6, 80);
            this.checkBoxBlackOlives.Name = "checkBoxBlackOlives";
            this.checkBoxBlackOlives.Size = new System.Drawing.Size(85, 17);
            this.checkBoxBlackOlives.TabIndex = 12;
            this.checkBoxBlackOlives.Text = "Black Olives";
            this.checkBoxBlackOlives.UseVisualStyleBackColor = true;
            // 
            // checkBoxGreenOlives
            // 
            this.checkBoxGreenOlives.AutoSize = true;
            this.checkBoxGreenOlives.Location = new System.Drawing.Point(6, 118);
            this.checkBoxGreenOlives.Name = "checkBoxGreenOlives";
            this.checkBoxGreenOlives.Size = new System.Drawing.Size(87, 17);
            this.checkBoxGreenOlives.TabIndex = 13;
            this.checkBoxGreenOlives.Text = "Green Olives";
            this.checkBoxGreenOlives.UseVisualStyleBackColor = true;
            // 
            // checkBoxSausage
            // 
            this.checkBoxSausage.AutoSize = true;
            this.checkBoxSausage.Location = new System.Drawing.Point(6, 308);
            this.checkBoxSausage.Name = "checkBoxSausage";
            this.checkBoxSausage.Size = new System.Drawing.Size(68, 17);
            this.checkBoxSausage.TabIndex = 14;
            this.checkBoxSausage.Text = "Sausage";
            this.checkBoxSausage.UseVisualStyleBackColor = true;
            // 
            // groupBoxSides
            // 
            this.groupBoxSides.Controls.Add(this.checkBoxCheeseBread);
            this.groupBoxSides.Controls.Add(this.checkBoxSalad);
            this.groupBoxSides.Controls.Add(this.checkBoxFriedCheeseSticks);
            this.groupBoxSides.Location = new System.Drawing.Point(281, 32);
            this.groupBoxSides.Name = "groupBoxSides";
            this.groupBoxSides.Size = new System.Drawing.Size(171, 178);
            this.groupBoxSides.TabIndex = 15;
            this.groupBoxSides.TabStop = false;
            this.groupBoxSides.Text = "Sides";
            this.groupBoxSides.Enter += new System.EventHandler(this.groupBoxSides_Enter);
            // 
            // checkBoxMushrooms
            // 
            this.checkBoxMushrooms.AutoSize = true;
            this.checkBoxMushrooms.Location = new System.Drawing.Point(6, 232);
            this.checkBoxMushrooms.Name = "checkBoxMushrooms";
            this.checkBoxMushrooms.Size = new System.Drawing.Size(80, 17);
            this.checkBoxMushrooms.TabIndex = 3;
            this.checkBoxMushrooms.Text = "Mushrooms";
            this.checkBoxMushrooms.UseVisualStyleBackColor = true;
            this.checkBoxMushrooms.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBoxHamburger
            // 
            this.checkBoxHamburger.AutoSize = true;
            this.checkBoxHamburger.Location = new System.Drawing.Point(6, 194);
            this.checkBoxHamburger.Name = "checkBoxHamburger";
            this.checkBoxHamburger.Size = new System.Drawing.Size(78, 17);
            this.checkBoxHamburger.TabIndex = 4;
            this.checkBoxHamburger.Text = "Hamburger";
            this.checkBoxHamburger.UseVisualStyleBackColor = true;
            // 
            // checkBoxGreenPeppers
            // 
            this.checkBoxGreenPeppers.AutoSize = true;
            this.checkBoxGreenPeppers.Location = new System.Drawing.Point(6, 156);
            this.checkBoxGreenPeppers.Name = "checkBoxGreenPeppers";
            this.checkBoxGreenPeppers.Size = new System.Drawing.Size(97, 17);
            this.checkBoxGreenPeppers.TabIndex = 5;
            this.checkBoxGreenPeppers.Text = "Green Pepeprs";
            this.checkBoxGreenPeppers.UseVisualStyleBackColor = true;
            // 
            // checkBoxOnions
            // 
            this.checkBoxOnions.AutoSize = true;
            this.checkBoxOnions.Location = new System.Drawing.Point(6, 270);
            this.checkBoxOnions.Name = "checkBoxOnions";
            this.checkBoxOnions.Size = new System.Drawing.Size(59, 17);
            this.checkBoxOnions.TabIndex = 6;
            this.checkBoxOnions.Text = "Onions";
            this.checkBoxOnions.UseVisualStyleBackColor = true;
            // 
            // groupBoxToppings
            // 
            this.groupBoxToppings.Controls.Add(this.checkBoxBacon);
            this.groupBoxToppings.Controls.Add(this.checkBoxOnions);
            this.groupBoxToppings.Controls.Add(this.checkBoxSausage);
            this.groupBoxToppings.Controls.Add(this.checkBoxBlackOlives);
            this.groupBoxToppings.Controls.Add(this.checkBoxGreenOlives);
            this.groupBoxToppings.Controls.Add(this.checkBoxMushrooms);
            this.groupBoxToppings.Controls.Add(this.checkBoxGreenPeppers);
            this.groupBoxToppings.Controls.Add(this.checkBoxHamburger);
            this.groupBoxToppings.Location = new System.Drawing.Point(573, 32);
            this.groupBoxToppings.Name = "groupBoxToppings";
            this.groupBoxToppings.Size = new System.Drawing.Size(200, 344);
            this.groupBoxToppings.TabIndex = 16;
            this.groupBoxToppings.TabStop = false;
            this.groupBoxToppings.Text = "Toppings";
            this.groupBoxToppings.Enter += new System.EventHandler(this.groupBoxToppings_Enter);
            // 
            // tBoxDrinks
            // 
            this.tBoxDrinks.Location = new System.Drawing.Point(281, 292);
            this.tBoxDrinks.Name = "tBoxDrinks";
            this.tBoxDrinks.Size = new System.Drawing.Size(100, 20);
            this.tBoxDrinks.TabIndex = 17;
            this.tBoxDrinks.Text = "0";
            this.tBoxDrinks.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblDrinks
            // 
            this.lblDrinks.AutoSize = true;
            this.lblDrinks.Location = new System.Drawing.Point(278, 276);
            this.lblDrinks.Name = "lblDrinks";
            this.lblDrinks.Size = new System.Drawing.Size(37, 13);
            this.lblDrinks.TabIndex = 18;
            this.lblDrinks.Text = "Drinks";
            // 
            // btnAboutUs
            // 
            this.btnAboutUs.Location = new System.Drawing.Point(281, 490);
            this.btnAboutUs.Name = "btnAboutUs";
            this.btnAboutUs.Size = new System.Drawing.Size(75, 23);
            this.btnAboutUs.TabIndex = 19;
            this.btnAboutUs.Text = "About Us";
            this.btnAboutUs.UseVisualStyleBackColor = true;
            this.btnAboutUs.Click += new System.EventHandler(this.btnAboutUs_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(281, 386);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(75, 23);
            this.btnOrder.TabIndex = 20;
            this.btnOrder.Text = "Order In";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 566);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnAboutUs);
            this.Controls.Add(this.lblDrinks);
            this.Controls.Add(this.tBoxDrinks);
            this.Controls.Add(this.groupBoxToppings);
            this.Controls.Add(this.groupBoxSides);
            this.Controls.Add(this.groupBoxCrust);
            this.Controls.Add(this.groupBoxSize);
            this.Name = "Form1";
            this.Text = "Project 3";
            this.groupBoxSize.ResumeLayout(false);
            this.groupBoxSize.PerformLayout();
            this.groupBoxCrust.ResumeLayout(false);
            this.groupBoxCrust.PerformLayout();
            this.groupBoxSides.ResumeLayout(false);
            this.groupBoxSides.PerformLayout();
            this.groupBoxToppings.ResumeLayout(false);
            this.groupBoxToppings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rButtonSmall;
        private System.Windows.Forms.RadioButton rButtonMedium;
        private System.Windows.Forms.RadioButton rButtonLarge;
        private System.Windows.Forms.GroupBox groupBoxSize;
        private System.Windows.Forms.RadioButton rButtonThin;
        private System.Windows.Forms.RadioButton rButtonThick;
        private System.Windows.Forms.RadioButton rButtonPan;
        private System.Windows.Forms.GroupBox groupBoxCrust;
        private System.Windows.Forms.CheckBox checkBoxCheeseBread;
        private System.Windows.Forms.CheckBox checkBoxSalad;
        private System.Windows.Forms.CheckBox checkBoxFriedCheeseSticks;
        private System.Windows.Forms.CheckBox checkBoxBacon;
        private System.Windows.Forms.CheckBox checkBoxBlackOlives;
        private System.Windows.Forms.CheckBox checkBoxGreenOlives;
        private System.Windows.Forms.CheckBox checkBoxSausage;
        private System.Windows.Forms.GroupBox groupBoxSides;
        private System.Windows.Forms.CheckBox checkBoxMushrooms;
        private System.Windows.Forms.CheckBox checkBoxHamburger;
        private System.Windows.Forms.CheckBox checkBoxGreenPeppers;
        private System.Windows.Forms.CheckBox checkBoxOnions;
        private System.Windows.Forms.GroupBox groupBoxToppings;
        private System.Windows.Forms.TextBox tBoxDrinks;
        private System.Windows.Forms.Label lblDrinks;
        private System.Windows.Forms.Button btnAboutUs;
        private System.Windows.Forms.Button btnOrder;
    }
}

