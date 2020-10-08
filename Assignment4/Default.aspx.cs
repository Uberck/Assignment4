using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment4
{
    public partial class Default : System.Web.UI.Page
    {
        // Function to take input from two fields and add them
        private int AddNumbers(int fieldOne, int fieldTwo)
        {
            return fieldOne + fieldTwo;
        }
        // Function to take input from two fields and subtract them
        private int SubtractNumbers(int fieldOne, int fieldTwo)
        {
            return fieldOne - fieldTwo;
        }
        // Function to take input from two fields and multiply them
        private int MultiplyNumbers(int fieldOne, int fieldTwo)
        {
            return fieldOne * fieldTwo;
        }
        // Function to take input from two fields and multiply them
        private int DivideNumbers(int fieldOne, int fieldTwo)
        {
            return fieldOne / fieldTwo;
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        // btnAdd OnClick
        protected void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Get values from text boxes
                int fieldOne = Convert.ToInt32(txtNumerator.Text);
                int fieldTwo = Convert.ToInt32(txtDenominator.Text);
                // Call the AddNumbers method & print the result in the Result textbox
                txtResult.Text = AddNumbers(fieldOne, fieldTwo) + "";
            }
            catch (Exception)
            {
                // Catch invalid input popup
                ClientScript.RegisterStartupScript(this.GetType(), "Alert", "alert('" + "Please enter a valid number." + "');", true);
            }
        }

        // btnSubtract OnClick
        protected void btnSubtract_Click(object sender, EventArgs e)
        {
            try
            {
                // Get values from text boxes
                int fieldOne = Convert.ToInt32(txtNumerator.Text);
                int fieldTwo = Convert.ToInt32(txtDenominator.Text);
                // Call the SubtractNumbers method & print the result in the Result textbox
                txtResult.Text = SubtractNumbers(fieldOne, fieldTwo) + "";
            }
            catch (Exception)
            {
                // Catch invalid input popup
                ClientScript.RegisterStartupScript(this.GetType(), "Alert", "alert('" + "Please enter a valid number." + "');", true);
            }
        }

        // btnMultiply OnClick
        protected void btnMultiply_Click(object sender, EventArgs e)
        {
            try
            {
                // Get values from text boxes
                int fieldOne = Convert.ToInt32(txtNumerator.Text);
                int fieldTwo = Convert.ToInt32(txtDenominator.Text);
                // Call the SubtractNumbers method & print the result in the Result textbox
                txtResult.Text = MultiplyNumbers(fieldOne, fieldTwo) + "";
            }
            catch (Exception)
            {
                // Catch invalid input popup
                ClientScript.RegisterStartupScript(this.GetType(), "Alert", "alert('" + "Please enter a valid number." + "');", true);
            }
        }

        // btnDivide OnClick
        protected void btnDivide_Click(object sender, EventArgs e)
        {
            try
            {
                // Get values from text boxes
                int fieldOne = Convert.ToInt32(txtNumerator.Text);
                int fieldTwo = Convert.ToInt32(txtDenominator.Text);
                // Call the SubtractNumbers method & print the result in the Result textbox
                txtResult.Text = DivideNumbers(fieldOne, fieldTwo) + "";
            }
            catch (Exception)
            {
                // Catch invalid input popup
                ClientScript.RegisterStartupScript(this.GetType(), "Alert", "alert('" + "Please enter a valid number." + "');", true);
            }
        }

        // btnClear OnClick
        protected void btnClear_Click(object sender, EventArgs e)
        {
            txtNumerator.Text = "";
            txtDenominator.Text = "";
            txtResult.Text = "";
        }
    }
}