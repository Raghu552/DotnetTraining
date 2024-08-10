using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP_Assignment
{
    public partial class Validations : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              
        }

        protected void btn_Click(object sender, EventArgs e)
        {
            string address = Txtadd.Text;
            string city = Txtc.Text;
            string zipcode = Txtzc.Text;
            bool isValid = true;
            string errorMessage = "";

            if (address.Length < 2)
            {
                errorMessage += "Address must be at least 2 letters. ";
                isValid = false;
            }
            if (city.Length < 2)
            {
                errorMessage += "City must be at least 2 letters";
                isValid = false;
            }
            if (zipcode.Length < 5)
            {
                errorMessage += "Zip Code must be at least 5 digits";
                isValid = false;
            }
            if (isValid)
            {
                Response.Redirect("Welcome.html");
            }
        }
    }
}