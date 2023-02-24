using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cash_Register
{
    public partial class carDealerships : Form
    {
        public carDealerships()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                // global varibables
                double BugattiPrice = 54999989.00;
                double LamborghiniPrice = 311333.00;
                double MokeAmericaPrice = 22975.00;
                double taxrate = 0.13;
                
                // get input
                int numberbugatti = Convert.ToInt32(BugattiInput.Text);
                int numberlamborghini = Convert.ToInt32(lamborghiniInput.Text);
                int numbermokeamerica = Convert.ToInt32(mokeInput.Text);

                // calculations
                double subtotalbugatti = numberbugatti * BugattiPrice;
                double subtotallamborghini = numberlamborghini * LamborghiniPrice;
                double subtotalnubermokeamerica = numbermokeamerica * MokeAmericaPrice;
                double subtotal = subtotalbugatti + subtotallamborghini + subtotalnubermokeamerica;
                double taxTotal = taxrate * subtotal;


                // output

                subTotalOutput.Text = $"{subtotal.ToString("C")}";
                taxTotalOutput.Text = $"{taxTotal.ToString("c")}";

            




            }
            catch
            {
                subTotalOutput.Text = "no";
            }
        }
    }
}

    