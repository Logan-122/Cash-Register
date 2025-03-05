using System;
using System.Windows.Forms;
using System.Threading;
using System.Media;
namespace Cash_Register
{
    public partial class Form1 : Form   
    {
       
        double burgerprice = 7.89;
        double frieprice = 3.79;
        double saladPrice = 3.25;
        int numofburger = 0;
        int numoffries = 0;
        int numofsalad = 0;
        double taxrate = 0.13;
        int tendered = 0;   
        public Form1()
        {
        
        
        InitializeComponent();
        }
        FormBorderStyle FormBorderStyle = FormBorderStyle.None;
      
        private void Form1_Load(object sender, EventArgs e)
        {
            
    }
       




        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void calculatetotalbutton_Click(object sender, EventArgs e)
        {
            try 
            { 

         numofburger = Convert.ToInt32(burgertextBox.Text);
            numoffries = Convert.ToInt32(numfriestextBox.Text);
            numofsalad = Convert.ToInt32(saladtextBox.Text);
            
                double subtotal = (burgerprice * numofburger) + (numoffries * frieprice) + (numofsalad * saladPrice);
                double tax = taxrate * subtotal;
                double total = subtotal + tax;

                subtotaloutput.Text = $"{subtotal.ToString("C")}";
                taxoutput.Text = $"{tax.ToString("C")}";
                totaloutput.Text = $"{total.ToString("C")}";
                calculatechange.Enabled = true; 
                
                }
            catch
            {
                subtotaloutput.Text = "ERROR";
                taxoutput.Text = "ERROR";
                totaloutput.Text = "ERROR";
            }
        }

        private void burgertextBox_TextChanged(object sender, EventArgs e)
        {

        }
        // calculate change button
        private void button3_Click(object sender, EventArgs e)
        {



            numofburger = Convert.ToInt32(burgertextBox.Text);
            numoffries = Convert.ToInt32(numfriestextBox.Text);
            numofsalad = Convert.ToInt32(saladtextBox.Text);

            double subtotal = (burgerprice * numofburger) + (numoffries * frieprice) + (numofsalad * saladPrice);
            double tax = taxrate * subtotal;
            double total = subtotal + tax;
            tendered = Convert.ToInt32(tenderetextbox.Text);
            double change = tendered - total;
            changeoutput.Text = $"{change.ToString("C")}";

            button1.Enabled = true;




            if (tendered < total) 
            {
                changeoutput.Text = "ERROR";
                button1.Enabled = false;

            }
        }
        
            private void button1_Click(object sender, EventArgs e)
            {
                
                
                    numofburger = Convert.ToInt32(burgertextBox.Text);
                    numoffries = Convert.ToInt32(numfriestextBox.Text);
                    numofsalad = Convert.ToInt32(saladtextBox.Text);
                    tendered = Convert.ToInt32(tenderetextbox.Text);

                    double newburger = numofburger * burgerprice;
                    double newoffries = numoffries * frieprice;
                    double newsalad = numofsalad * saladPrice;

                    double subtotal = (burgerprice * numofburger) + (numoffries * frieprice) + (numofsalad * saladPrice);
                    double tax = taxrate * subtotal;
                    double total = subtotal + tax;
                    double change = tendered - total;

            SoundPlayer player = new SoundPlayer(Properties.Resources.cash_register_print39);
            
            player.Play();



            Refresh();
            Thread.Sleep(1000);
            recipetoutput.Text = $"                    Burger Clan";
               player.Play();
            Refresh();
                Thread.Sleep(1000);
                recipetoutput.Text += "\n\nOrder Number 1533";
                Refresh();
                Thread.Sleep(1000);
                recipetoutput.Text += "\nMarch 3, 2025";
                Refresh();
                Thread.Sleep(1000);
                recipetoutput.Text += $"\nBurgers        x{numofburger}  @       {newburger}";
                Refresh();
                Thread.Sleep(1000);
                recipetoutput.Text += $"\nFries             x{numoffries}  @        {newoffries}";
               
            Refresh();
                Thread.Sleep(1000);
            recipetoutput.Text += $"\nSalad            x{numofsalad}  @       {newsalad}";
           player.Play();
            Refresh();
                Thread.Sleep(1000);
                recipetoutput.Text += $"\n\nSubtotal                    {subtotal.ToString("C")}";
                player.Play();
            Refresh();
                Thread.Sleep(1000);
                recipetoutput.Text += $"\nTax                               {tax.ToString("C")}";
                
            Refresh();
                Thread.Sleep(1000);
                recipetoutput.Text += $"\nTotal                          {total.ToString("C")}";
                Refresh();
                Thread.Sleep(1000);
                recipetoutput.Text += $" \n\nTendered                   {tendered.ToString("C")}";
                Refresh();
                Thread.Sleep(1000);
                recipetoutput.Text += $"\nChange                        {change.ToString("C")}";
                Refresh();
                Thread.Sleep(1000); 
                recipetoutput.Text += "\n\n----Have a Nice Day-----";
                neworder.Enabled = true;
            
            
            }
        
        private void neworder_Click(object sender, EventArgs e)
        {
            recipetoutput.Text = "";
            subtotaloutput.Text = "";
            taxoutput.Text = "";
            changeoutput.Text = "";
            totaloutput.Text = "";
            tenderetextbox.Text = "";
            numfriestextBox.Text = "";
            burgertextBox.Text = "";
            saladtextBox.Text = "";

        }

        private void fries_Click(object sender, EventArgs e)
        {

        }
    }
}
