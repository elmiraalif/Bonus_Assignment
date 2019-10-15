using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace n01318198_Bonus_ElmiraAlif
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                Page.Validate();
                if (Page.IsValid)
                {
                    // Defining variables' type:
                    int X_Value = Convert.ToInt32(x_value.Text);
                    int Y_Value = Convert.ToInt32(y_value.Text);
                    //The code below checks if both numbers are positive, if so, they are on first quadrant!
                    if (X_Value > 0 && Y_Value > 0)
                    {
                        quadrant_result.InnerHtml = "The point (" + X_Value.ToString() + "," + Y_Value.ToString() + ") is on quadrant ONE.";
                    }
                    //If the X value of the point is negative and y value is positive, It is on second qudrant!
                    else if (X_Value < 0 && Y_Value > 0)
                    {
                        quadrant_result.InnerHtml = "The point(" + X_Value.ToString() + "," + Y_Value.ToString() + ") is on quadrant TWO.";
                    }
                    // X and Y value of the point are negative, so they are on third quadrant!
                    else if (X_Value < 0 && Y_Value < 0)
                    {
                        quadrant_result.InnerHtml = "The point(" + X_Value.ToString() + "," + Y_Value.ToString() + ") is on quadrant THREE.";
                    }
                    //The only condition left is when the point has a positive x and negative y!
                    else
                    {
                        quadrant_result.InnerHtml = "The point(" + X_Value.ToString() + "," + Y_Value.ToString() + ") is on quadrant FOUR.";
                    }
                }
            }
        }
    }
}