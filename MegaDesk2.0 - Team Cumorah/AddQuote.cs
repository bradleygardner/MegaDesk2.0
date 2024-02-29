using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MegaDesk2._0___Team_Cumorah
{
    public partial class AddQuote : Form

    {
        private List<DesktopMaterial> Materials;

        //This method instantiates an instance of the Add Quote View/Form
        public AddQuote()
        {
            InitializeComponent();
             
            // Added list of Desktop Materials 
           Materials = Enum.GetValues(typeof(DesktopMaterial)).Cast<DesktopMaterial>().ToList();

           SurfaceMaterialSelection.DataSource = Materials;
        }

       
        //Establish data members of the class
        public string CustomerName { get; set; }
        public int DeskWidth { get; set; }
        public int DeskDepth { get; set; }
        public int DeskDrawers { get; set; }
        public string SelectedMaterial { get; set; }
        public int RushOrderOption { get; set; }

        /**************METHODS THAT HANDLE NAVIGATION BETWEEN FORMS**************/
        
        //This method opens up the Display Quote form when the submit button is pushed.
        private void SubmitQuoteInputButton_Click(object sender, EventArgs e)
        
        {
            //Show message box to prompt user to complete selections ... do not allow submission of the data unless all fields are complete.
            if (CustomerName == null || DeskWidth == 0 || DeskDepth == 0 || SelectedMaterial == null || RushOrderOption == 0)
           
            {
            
                MessageBox.Show("Please complete selections.");

            }
            
            else
           
            {
                //Set properties of the DeskQuote instance
                DeskQuote quote = new DeskQuote();
                
                quote.CustomerName = CustomerName;
                
                quote.QuoteDate = DateTime.Now.ToString("MMMM dd, yyyy");

                quote.Desk.Width = DeskWidth;
                
                quote.Desk.Depth = DeskDepth;
                
                quote.Desk.NumOfDrawers = DeskDrawers;
                
                quote.Desk.SetSurfaceMaterials(SelectedMaterial);
                
                quote.Shipping = RushOrderOption;
                
                quote.CalculateDeskQuotePrice();

                DataStorage.AddQuote(quote);

                //Navigate to the DisplayQuote View and pass the quote object with it
                DisplayQuote displayQuoteForm = new DisplayQuote(quote);
                
                displayQuoteForm.Tag = this;
                
                this.Hide();


                if (displayQuoteForm.ShowDialog(this) == DialogResult.Cancel)
                
                {
                
                    this.Close();
                
                }
                
                this.Close();
            
            }

        }

        //This method returns to the main menu when the cancel button is clicked.
        private void AddQuoteForm_FormClosed(object sender, FormClosedEventArgs e)
        
        {
        
            DialogResult = DialogResult.Cancel;
        
        }



        
        /***********************  METHODS THAT VALIDATE THE USER INPUT FOR NAME  ***************************/
        
        //This method is validating the user's input for name.
        private void FullName_Validating(object sender, CancelEventArgs e)
        
        {
           //Set a string variable to hold an error message
            string errorMsg;

            // Call the ValidfullName method to validate the name
            if (!ValidfullName(FullName.Text, out errorMsg))
            
            {
                
                e.Cancel = true;
                
                FullName.Select(0, FullName.Text.Length);
                
                this.errorProvider1.SetError(this, errorMsg);
                
                MessageBox.Show(errorMsg);
            
            }

            //Call setDeskWidth() method to set Width class member to value of Width
            SetCustomerName(FullName.Text);
        
        }


        //This method clears the Error Provider
        private void FullName_Validated_1(object sender, EventArgs e)
        
        {
            //If all conditions have been met, clear the Error Provider of errors.
            errorProvider1.SetError(FullName, "");
        
        }
        
        
        //This method checks the user input for full name and returns an error message if it is empty.
        public bool ValidfullName(string fullName, out string errorMessage)
        
        {
        
            if (fullName.Length == 0)
        
            {
            
                errorMessage = "Please enter your first and last name.";
                
                return false;
            
            }
            
            errorMessage = "";
            
            return true;
        
        }
        

        //Set the validated customer name to the CustomerName property of this class instance.
        public void SetCustomerName(string name)
        
        {
        
            this.CustomerName = name;
        
        }




        /************************  METHODS THAT VALIDATE THE USER INPUT FOR WIDTH  ************************/
        
        //This method checks the user input for the Width and returns an error message if it is wrong.
        private void WidthTextBox_Validating(object sender, CancelEventArgs e)
        
        {
        
            string errorMsg;

            if (!Validwidth(WidthTextBox.Text, out errorMsg))
            
            {
                
                e.Cancel = true;
                
                WidthTextBox.Select(0, WidthTextBox.Text.Length);
                
                this.errorProvider1.SetError(this, errorMsg);
                
                MessageBox.Show(errorMsg);
            
            }
            
            else
            
            {

                //Once validated call validated method to clear error message
                WidthTextBox_Validated(sender, e);
            
            }
            
            //Call setDeskWidth() method to set Width class member to value of Width
            SetDeskWidth(WidthTextBox.Text);
        
        }
        
        
        //This method clears the Error Provider
        private void WidthTextBox_Validated(object sender, EventArgs e)
        {
            //If all conditions have been met, clear the Error Provider of errors.
            errorProvider1.SetError(FullName, "");

        }
        
        
        //This method checks the user input for Width and returns an error message if it is empty.
        public bool Validwidth(string width, out string errorMessage)
        
        {

            try
        
            {
            
                int w = Convert.ToInt32(width);
                
                //make sure that we have a valid number in the text box with no other characters       
                //loop through the string, examining each character
                
                for (int i = 0; i < width.Length; i++)
                
                {

                    //Check each character from the input to make sure it is a number         
                    if (!char.IsDigit(width[i]))
                
                    {
                    
                        errorMessage = "Please enter a valid number.";
                        
                        return false;
                    
                    }
                
                }
                
                if (width.Length == 0)
                
                {
                
                    errorMessage = "Please enter a valid Width between 24 and 96 inches.";
                    
                    return false;
                
                } 
                
                else if (w < 24 || w > 96)
                
                {
                    
                    errorMessage = "The number you entered is not between 24 and 96. Please try again.";
                    
                    return false;
                
                }
            
            }
            
            catch (Exception e)
            
            {
                
                errorMessage = e.Message;
                
                WidthTextBox.Clear();
                
                return false;
            
            }

            errorMessage = "";
            
            return true;
        
        }
        
        //After validating the Width, set the DeskWidth to the user's input.
        public void SetDeskWidth(string width)
        
        {
        
            try
            
            {
            
                this.DeskWidth = Convert.ToInt32(width);
            
            }
            
            catch (Exception)
            
            {
            
            }
        
        }



        /*********************  METHODS THAT VALIDATE THE USER INPUT FOR DEPTH  *********************/
        
        //A method that uses the keypress event to monitor user input into the DepthTextBox input field.
        private void DepthTextBox_KeyPress(object sender, KeyPressEventArgs e)
        
        {
            
            if (!char.IsDigit(e.KeyChar))
            
            {
            
                MessageBox.Show("Please enter a number.");
                
                DepthTextBox.Clear();
                
                e.Handled = true;

            }
            
            else if (char.IsControl(e.KeyChar))
            
            {
            
                MessageBox.Show("That is not a valid entry. Please enter a number.");
                
                DepthTextBox.Clear();
                
                e.Handled = true;

            }
        
        }
        

        //A method that validates the user input from the depthTextBox
        private void DepthTextBox_Validating(object sender, CancelEventArgs e)
        
        {

        
            if (!ValidDepth(DepthTextBox.Text, out string errorMsg))
            
            {
            
                e.Cancel = true;
                
                DepthTextBox.Select(0, WidthTextBox.Text.Length);
                
                this.errorProvider1.SetError(this, errorMsg);
                
                MessageBox.Show(errorMsg);
            
            }
            
            else
            
            {
                
                //Once validated call validated method to clear error message
                DepthTextBox_Validated(sender, e);
            
            }
            
            //Call setDeskWidth() method to set Width class member to value of Width
            SetDeskDepth(DepthTextBox.Text);
       
        }
        
        
        //This method clears the Error Provider
        private void DepthTextBox_Validated(object sender, EventArgs e)
        
        {
        
            //If all conditions have been met, clear the Error Provider of errors.
            errorProvider1.SetError(FullName, "");
        
        }
        
        
        //This method checks the user input for Depth and returns an error message if it is empty
        public bool ValidDepth(string depth, out string errorMessage)
        
        {

            try
            
            {
            
                int d = Convert.ToInt32(depth);
                
                //make sure that we have a valid number in the text box with no other characters       
                if (depth.Length == 0)
                
                {
                
                    errorMessage = "Please enter a valid Depth between 12 and 48 inches.";
                    
                    return false;
                
                }
                
                else if (d < 12 || d > 48)
                
                {
                
                    errorMessage = "The number you entered is not between 12 and 48. Please try again.";
                    
                    return false;
                
                }
            
            }
            
            catch (Exception e)
            
            {
            
                errorMessage = e.Message;
                
                DepthTextBox.Clear();
                
                return false;
            
            }

            errorMessage = "";
            
            return true;
        
        }
        

        //After validating the Depth, set the DeskDepth to the user's input.
        public void SetDeskDepth(string depth)
        
        {
        
            try
            
            {
            
                this.DeskDepth = Convert.ToInt32(depth);
            
            }
            
            catch (Exception)
            
            {
            
            }
        
        }



        /*********************  METHODS THAT VALIDATE THE USER INPUT FOR DRAWERS  *********************/
        private void NumberOfDrawersInput_ValueChanged(object sender, EventArgs e)
        
        {
        
            //Get value of numberOfDrawersInput and save it to DeskDrawers
            this.DeskDrawers = (int)NumberOfDrawersInput.Value;
        
        }



        /************************  METHODS THAT VALIDATE THE USER INPUT FOR SURFACE MATERIAL  ************************/
        
        //Event to monitor which selection the user submits
        private void SurfaceMaterialSelection_SelectedIndexChanged(object sender, EventArgs e)
        
        {
        
            switch (SurfaceMaterialSelection.Text)
            
            {
            
                case "Laminate":
                
                    if (SurfaceMaterialSelection.SelectedIndex == 0)
                    
                    {
                    
                        this.SelectedMaterial = SurfaceMaterialSelection.Text;
                    
                    }

                    break;
                
                case "Oak":
                
                    if (SurfaceMaterialSelection.SelectedIndex == 1)
                    
                    {
                    
                        this.SelectedMaterial = SurfaceMaterialSelection.Text;
                    
                    }
                    
                    break;
                
                case "Pine":
                
                    if (SurfaceMaterialSelection.SelectedIndex == 2)
                    
                    {
                    
                        this.SelectedMaterial = SurfaceMaterialSelection.Text;
                    
                    }

                    break;
                
                case "Rosewood":
                
                    if (SurfaceMaterialSelection.SelectedIndex == 3)
                    
                    {
                    
                        this.SelectedMaterial = SurfaceMaterialSelection.Text;
                    
                    }
                    
                    break;
                
                case "Veneer":
                
                    if (SurfaceMaterialSelection.SelectedIndex == 4)
                    
                    {
                    
                        this.SelectedMaterial = SurfaceMaterialSelection.Text;
                    
                    }
                    
                    break;
                
                default:
                    
                    MessageBox.Show("Something went wrong. Please try your selection again.");
                    
                    break;
            
            }

            //Show the user what they selected.
            materialSelectionMessage.Text = "You selected " + SelectedMaterial;
        
        }



        /************************  METHODS THAT VALIDATE THE USER INPUT FOR RUSH ORDER OPTIONS  ************************/
        
        //Event for 3 day selection
        private void Day3Rush_CheckedChanged(object sender, EventArgs e)
        
        {
        
            this.RushOrderOption = 3;

            //Show the user what they selected.
            rushOrderMessage.Text = "You selected " + RushOrderOption + " day Shipping.";

        }

        //Event for 5 day selection
        private void Day5Rush_CheckedChanged(object sender, EventArgs e)

        {

            this.RushOrderOption = 5;

            //Show the user what they selected.
            rushOrderMessage.Text = "You selected " + RushOrderOption + " day Shipping.";

        }

        //Event for 7 day selection
        private void Day7Rush_CheckedChanged(object sender, EventArgs e)

        {

            this.RushOrderOption = 7;

            //Show the user what they selected.
            rushOrderMessage.Text = "You selected " + RushOrderOption + " day Shipping.";

        }

        //Event for 14 day selection
        private void NoRushOrder_CheckedChanged(object sender, EventArgs e)

        {

            this.RushOrderOption = 14;

            //Show the user what they selected.
            rushOrderMessage.Text = "You selected " + RushOrderOption + " day Shipping.";

        }

        private void AddQuote_Load(object sender, EventArgs e)
        {

        }
    }
}

