using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk2._0___Team_Cumorah

{

    public partial class DisplayQuote : Form

    {

        private DeskQuote quote;

        public DisplayQuote()

        {

            InitializeComponent();

        }

        public DisplayQuote(DeskQuote quote)

        {

            InitializeComponent();

            this.quote = quote;

            try

            {
                string price = quote.QuoteTotal.ToString();

                CustomerNameDisplay.Text = quote.CustomerName;

                PriceQuoteDisplay.Text = "$" + price;

                QuoteDateDisplay.Text = quote.QuoteDate;

                string width = quote.Desk.Width.ToString();

                WidthDisplay.Text = width + " inches";

                string depth = quote.Desk.Depth.ToString();

                DepthDisplay.Text = depth + " inches";

                string drawers = quote.Desk.NumOfDrawers.ToString();

                NumOfDrawersDisplay.Text = drawers + " drawers";

                string materials = quote.Desk.SurfaceMaterials.ToString();

                MaterialsDisplay.Text = materials;

                string shipping = quote.Shipping.ToString();

                ShippingDisplay.Text = shipping + " Days";
            }

            catch (Exception e)

            {

                MessageBox.Show(e.Message);

            }

        }

        //A method to close the view when the Close button is clicked.
        private void buttonCloseDisplayQuote_Click(object sender, EventArgs e)

        {

            this.Close();

        }
    }
}
