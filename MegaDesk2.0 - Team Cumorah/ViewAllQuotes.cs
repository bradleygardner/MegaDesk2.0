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

    public partial class ViewAllQuotes : Form

    {

        public ViewAllQuotes()

        {

            InitializeComponent();

        }


        private void ViewAllQuotes_Load(object sender, EventArgs e)

        {

            foreach (DeskQuote quote in DataStorage.DeskQuotes)
            {
                int rowIndex = ListAllQuotes.Rows.Add(

                    quote.CustomerName,

                    quote.QuoteDate,

                    $"{quote.Shipping} days",

                    $"{quote.Desk.Width} in",

                    $"{quote.Desk.Depth} in",

                    quote.Desk.SurfaceMaterials,

                    quote.Desk.NumOfDrawers,

                    $"{quote.QuoteTotal:C2}"

                    );
            }
        }

        /*************** METHODS FOR NAVIGATION BETWEEN VIEWS **************/

        //A Method that returns the user to the Main Menu when clicked
        private void buttonCloseViewAllQuotes_Click(object sender, EventArgs e)

        {

            MainMenu viewMainMenu = (MainMenu)Tag;

            viewMainMenu.Show();

            this.Close();

        }

    }
}
