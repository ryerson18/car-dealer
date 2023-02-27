using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Cash_Register
{
    public partial class carDealerships : Form
    {
        double BugattiPrice = 54999989.00;
        double LamborghiniPrice = 311333.00;
        double MokeAmericaPrice = 22975.00;
        double taxrate = 0.13;
        int numberbugatti;
        int numberlamborghini;
        int numbermokeamerica;
        double subtotalbugatti;
        double subtotallamborghini; 
        double subtotalnubermokeamerica;
        double subtotal;
        double taxTotal;
        double totalPrice;


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
                
                // get input
                numberbugatti = Convert.ToInt32(BugattiInput.Text);
                numberlamborghini = Convert.ToInt32(lamborghiniInput.Text);
                numbermokeamerica = Convert.ToInt32(mokeInput.Text);

                // calculations
                subtotalbugatti = numberbugatti * BugattiPrice;
                subtotallamborghini = numberlamborghini * LamborghiniPrice;
                subtotalnubermokeamerica = numbermokeamerica * MokeAmericaPrice;
                subtotal = subtotalbugatti + subtotallamborghini + subtotalnubermokeamerica;
                taxTotal = taxrate * subtotal;
                totalPrice = taxTotal + subtotal;


                // output

                subTotalOutput.Text = $"{subtotal.ToString("C")}";
                taxTotalOutput.Text = $"{taxTotal.ToString("c")}";
                wholeTotalOutput.Text = $"{totalPrice.ToString("c")}";

            }
            catch
            {
                subTotalOutput.Text = "no";
            }
        }

        private void printReceiptButton_Click(object sender, EventArgs e)
        {
            printReceiptoutput.BackColor = Color.White;

            SoundPlayer player = new SoundPlayer(Properties.Resources.receipt);
            player.Play();

            //output
            printReceiptoutput.Text = "My store\n\n";
            Refresh();
            Thread.Sleep(500);

            printReceiptoutput.Text += $"Bugatti price =${BugattiPrice}\n\n";
            Refresh();
            Thread.Sleep(500);

            printReceiptoutput.Text += $"Lamborghini price =${LamborghiniPrice}\n\n";
            Refresh();
            Thread.Sleep(500);

            printReceiptoutput.Text += $"Moke America price =${MokeAmericaPrice}\n\n";
            Refresh();
            Thread.Sleep(500);

            printReceiptoutput.Text += $"Number of Bugatti = {numberbugatti}\n\n";
            Refresh();
            Thread.Sleep(500);

            printReceiptoutput.Text += $"Number of Lamborghini = {numberlamborghini}\n\n";
            Refresh();
            Thread.Sleep(500);

            printReceiptoutput.Text += $"Number of Moke America  = {numbermokeamerica}\n\n";
            Refresh();
            Thread.Sleep(500);

            printReceiptoutput.Text += $"Subtotal = ${subtotal}\n\n";
            Refresh();
            Thread.Sleep(500);

            printReceiptoutput.Text += $"TaxTotal = ${taxTotal}\n\n";
            Refresh();
            Thread.Sleep(500);


            printReceiptoutput.Text += $"Subtotal = ${totalPrice}\n\n";



            player.Stop();

        }
    }
}

    