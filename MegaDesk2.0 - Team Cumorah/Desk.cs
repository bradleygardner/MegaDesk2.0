using System;

namespace MegaDesk2._0___Team_Cumorah

{
    [Serializable]
    //Create an enum data type for the material outside of the class.
    public enum DesktopMaterial { Laminate, Oak, Pine, Rosewood, Veneer }

    //Create the Desk class
    [Serializable]
    public class Desk
    {
        //Create the contants
        public const int MINWIDTH = 24;

        public const int MAXWIDTH = 96;

        public const int MINDEPTH = 12;

        public const int MAXDEPTH = 48;


        //Create the private data members of the Desk Class
        public int Width { get; set; }

        public int Depth { get; set; }

        public int NumOfDrawers { get; set; }

        public DesktopMaterial SurfaceMaterials { get; set; }

        public double SurfaceArea { get; set; }


        /*********************METHODS OF THE DESK QUOTE CLASS*********************/



        //Set SurfaceMaterials
        public void SetSurfaceMaterials(string materials)

        {

            switch (materials)

            {

                case "Laminate":

                    SurfaceMaterials = DesktopMaterial.Laminate;

                    break;

                case "Oak":

                    SurfaceMaterials = DesktopMaterial.Oak;

                    break;

                case "Pine":

                    SurfaceMaterials = DesktopMaterial.Pine;

                    break;

                case "Rosewood":

                    SurfaceMaterials = DesktopMaterial.Rosewood;

                    break;

                case "Veneer":

                    SurfaceMaterials = DesktopMaterial.Veneer;

                    break;

                default:

                    break;

            }

        }



        /***********  OTHER METHODS  **********/


        //A method that calculates the surface area of a Desk.
        public void CalculateSurfaceArea()
        {
            SurfaceArea = Width * Depth;
        }

    }

}
