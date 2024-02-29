using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MegaDesk2._0___Team_Cumorah

{
    public class DeskQuote
    {


        //Constants of teh DesQuoteClass
        public const int BASE_PRICE = 200;

        public const int PRICE_PER_DRAWER = 50;

        public const int LAMINATE_PRICE = 100;

        public const int OAK_PRICE = 200;

        public const int PINE_PRICE = 50;

        public const int ROSEWOOD_PRICE = 300;

        public const int VENEER_PRICE = 125;



        //Properties of the DeskQuote Class

        public Desk Desk = new Desk();
        public string CustomerName { get; set; }
        public string QuoteDate { get; set; }
        public int Shipping { get; set; } //Options are 3, 5, 7, or 14
        public double QuoteTotal { get; set; }

        // Add a Contructor here that reads in the RushOrderPrice.txt file and sets the constants...

        private int[,] rushOrderPrices;

        public DeskQuote()
        {
            rushOrderPrices = ReadRushOrderPrices();
        }



        /*********************METHODS OF THE DESK QUOTE CLASS*********************/

        /**************** OTHER METHODS ****************/

        //A Method that calculates the total price of the Desk quote
        public void CalculateDeskQuotePrice()
        {
            //Call calculate surface area before checking if it's over 1k
            Desk.CalculateSurfaceArea();

            //Call calculate cost of surface area over 1K and save to variable
            double costOfSurfaceAreaOver1K = CalculateSurfaceAreaOver1K();

            //Call calculate cost of drawers and save to variable
            double costOfDrawers = CalculateCostOfDrawers();

            //call calculate cost of surface materials and save to variable
            double costOfMaterials = CalculateCostOfSurfaceMaterials();

            //call calculate cost of Shipping and save to variable
            double costOfShipping = CalculateShipping();

            //Add base price plus all variables
            double total = BASE_PRICE + costOfSurfaceAreaOver1K + costOfDrawers + costOfMaterials + costOfShipping;

            //Set the price of this quote
            QuoteTotal = total;

        }


        //A method that calculates the cost of surface area over 1,000 square inches
        public double CalculateSurfaceAreaOver1K()

        {

            double surfaceArea = Desk.SurfaceArea;

            if (surfaceArea < 1001)

            {

                return 0;

            }

            else

            {

                return surfaceArea - 1000;

            }

        }


        //A method that calculates the cost of the drawers
        public double CalculateCostOfDrawers()
        {
            return Desk.NumOfDrawers * 50;
        }

        //A method that calculates the cost of the selected surface material
        public double CalculateCostOfSurfaceMaterials()

        {

            double materialCost = 0;

            DesktopMaterial material = Desk.SurfaceMaterials;

            if (material == DesktopMaterial.Laminate)

            {

                materialCost = LAMINATE_PRICE;

            }

            else if (material == DesktopMaterial.Oak)

            {

                materialCost = OAK_PRICE;

            }

            else if (material == DesktopMaterial.Pine)

            {

                materialCost = PINE_PRICE;

            }

            else if (material == DesktopMaterial.Rosewood)

            {

                materialCost = ROSEWOOD_PRICE;

            }

            else if (material == DesktopMaterial.Veneer)

            {

                materialCost = VENEER_PRICE;

            }

            return materialCost;

        }


        //A method that calculates the cost of the seleced Shipping
        public double CalculateShipping()
        {
            double shippingCost = 0;

            int shippingSelection = Shipping;

            double surfaceArea = Desk.SurfaceArea;

            if (shippingSelection == 14)
            {
                return shippingCost;
            }

            int rushSizeIndex = surfaceArea < 1000 ? 0 : surfaceArea <= 2000 ? 1 : 2;
            int rushDaysIndex = shippingSelection == 3 ? 0 : shippingSelection == 5 ? 1 : 2;

            if (rushOrderPrices != null)
            {
                shippingCost = rushOrderPrices[rushSizeIndex, rushDaysIndex];
            }
            else
            {
                MessageBox.Show("Error: Rush order prices weren't loaded. Free shipping selected and applied automatically.");
            }



            return shippingCost;

        }


        private int[,] ReadRushOrderPrices()
        {
            try
            {
                string[] lines = File.ReadAllLines("rushOrderPrices.txt");
                int[,] rushOrderPrices = new int[3, 3];

                for (int i = 0; i < lines.Length; i++)
                {
                    string[] prices = lines[i].Split(',');
                    for (int j = 0; j < prices.Length; j++)
                    {
                        rushOrderPrices[i, j] = int.Parse(prices[j].Trim());
                    }
                }

                return rushOrderPrices;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Whoops, I couldn't get the rush order prices... {ex.Message}");
                return null;
            }
        }
    }

}
