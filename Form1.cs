using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module4Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Declare the constants
            const double PRICE_ONE = 39.95;
            const double PRICE_TWO = 89.99;
            const double PRICE_THREE = 139.95;
            const int SIZE_ONE = 5;
            const int SIZE_TWO = 8;
            //Declare the variables
            double hieghtInFeet;
            double finalPrice = 0;

            hieghtInFeet = Convert.ToDouble(textBox1.Text);
            //Decide what the outcome is using a nested decision
            if (hieghtInFeet < SIZE_ONE)
                finalPrice = PRICE_ONE;

                else if (hieghtInFeet >= SIZE_ONE)
                    if (hieghtInFeet <= SIZE_TWO)
                        finalPrice = PRICE_TWO;

                else finalPrice = PRICE_THREE;
                
            //Display the output
            label2.Text = $"It will cost ${finalPrice} for a sign that is {hieghtInFeet} feet long.";
        }
    }
}
