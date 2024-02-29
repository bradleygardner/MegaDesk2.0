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

    public partial class MainMenu : Form

    {

        public MainMenu()

        {

            InitializeComponent();

        }


        private void AddNewQuoteButton_Click(object sender, EventArgs e)

        {

            AddQuote viewAddQuoteForm = new AddQuote();

            viewAddQuoteForm.Tag = this;

            this.Hide();
            
            if (viewAddQuoteForm.ShowDialog(this) == DialogResult.Cancel)
            {
                this.Show();
            } else
            {
                this.Hide();
            }
            
            this.Show();

        }

        private void ViewQuotesButton_Click(object sender, EventArgs e)

        {

            ViewAllQuotes viewAllQuotesForm = new ViewAllQuotes();
            
            viewAllQuotesForm.Tag = this;
            
            this.Hide();
           
            if (viewAllQuotesForm.ShowDialog(this) == DialogResult.Cancel)
            {
                this.Show();
            } else
            {
                this.Hide();
            }

            this.Show();

        }

        private void SearchQuotesButton_Click(object sender, EventArgs e)

        {

            SearchQuote viewSearchQuotesForm = new SearchQuote();

            viewSearchQuotesForm.Tag = this;

            this.Hide();

            if (viewSearchQuotesForm.ShowDialog(this) == DialogResult.Cancel)
            {
                this.Show();
            } else
            {
                this.Hide();
            }
            this.Show();

        }


        private void ExitButton_Click(object sender, EventArgs e)

        {

            Application.Exit();

        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }
    }

}

