using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk2._0___Team_Cumorah
{
    public partial class SearchQuote : Form
    {
        public SearchQuote()
        {
            InitializeComponent();
        }

        private void buttonCloseSearchQuotes_Click(object sender, EventArgs e)
        {
            MainMenu viewMainMenu = (MainMenu)Tag;
            viewMainMenu.Show();
            this.Close();
        }

        private void materialSelectBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Add the ability for the user to SEARCH through the orders by combo-box selected surface material
            //display the Desk quote with the customer name, quote date, Desk specs, and overall price quote.

            if (materialSelectBox.SelectedIndex != -1)
            {
                // Get the list of Data
                List<DeskQuote> filteredQuotes = DataStorage.SearchDeskQuote((DesktopMaterial)materialSelectBox.SelectedIndex);

                // Clear previous entry
                listAllQuotes.Rows.Clear();

                foreach (var quote in filteredQuotes)
                {
                    // Add a new row with data
                    int rowIndex = listAllQuotes.Rows.Add(
                        quote.CustomerName,
                        quote.QuoteDate,
                        $"{quote.Shipping} days",
                        $"{quote.Desk.Width} in",
                        $"{quote.Desk.Depth} in",
                        quote.Desk.NumOfDrawers,
                        $"{quote.QuoteTotal:C2}" // Format as currency with two decimal places
                    );
                }
            }
        }

    }
}
