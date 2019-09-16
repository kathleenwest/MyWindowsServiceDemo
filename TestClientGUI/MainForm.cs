using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestClientGUI.MyAffirmServiceRef;

namespace TestClientGUI
{
    public partial class frmMainScreen : Form
    {
        public frmMainScreen()
        {
            InitializeComponent();
        }

        private void btnAffirmMe_Click(object sender, EventArgs e)
        {
            string response = "";

            // Try to Connect to the service
            try
            {
                AffirmationServiceClient proxy = new AffirmationServiceClient();
                // Check to See if Name is Available          
                if (!String.IsNullOrEmpty(txtName.Text))
                {
                    // Call the Service with No parameter for Name
                    response = proxy.AffirmMe(txtName.Text);
                }
                else
                {
                    // Call Service without the Name Parameter
                    response = proxy.AffirmMe("Stranger");
                }
            }
            catch (Exception)
            {
                response = "Sorry, but the service is unavailable.";
            }

            // Load the affirmation
            txtMessage.Text = response;

        } // end of method

    } // end of class
} // end of namespace
