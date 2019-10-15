using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace n01318198_Bonus_ElmiraAlif
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //using post-back technique
            if (Page.IsPostBack)
            {
                Page.Validate();
                if (Page.IsValid)
                {

                    //get the value of the user input
                    //foreach
                    foreach (ListItem weekdays in weekdays.Items)
                    {


                        // the loop below displays the entire calendar
                        for (int i = 1; i <= 30; i++)
                        {
                            if (weekdays.Selected == true)
                            {

                                if (i == 1 | i == 8 | i == 15 | i == 22)
                                {
                                    october_calendar.InnerHtml += "Oct " + i + " is a Tuesday!<br>";
                                    if (weekdays.Value == "tuesday")
                                    {
                                        october_calendar.InnerHtml += "work work work<br>";

                                    }
                                }
                                else if (i == 2 | i == 9 | i == 16 | i == 23)
                                {
                                    october_calendar.InnerHtml += " <br> Oct " + i + " is a Wednesaday!";
                                    if (weekdays.Value == "wednesday")
                                    {
                                        october_calendar.InnerHtml += "work work work<br>";

                                    }

                                }
                                else if (i == 3 | i == 10 | i == 17 | i == 24)
                                {
                                    october_calendar.InnerHtml += "Oct " + i + " is a Thursday!<br>";
                                    if (weekdays.Value == "thursday")
                                    {
                                        october_calendar.InnerHtml += "work work work<br>";

                                    }

                                }
                                else if (i == 4 | i == 11 | i == 18 | i == 25)
                                {
                                    october_calendar.InnerHtml += "Oct " + i + " is a Friday!";
                                    if (weekdays.Value == "friday")
                                    {
                                        october_calendar.InnerHtml += "work work work<br>";

                                    }

                                }
                                else if (i == 5 | i == 12 | i == 19 | i == 26)
                                {
                                    october_calendar.InnerHtml += "Oct " + i + " is a Saturday!<br>";
                                    if (weekdays.Value == "saturday")
                                    {
                                        october_calendar.InnerHtml += "work work work<br>";

                                    }

                                }
                                else if (i == 6 | i == 13 | i == 20 | i == 27)
                                {
                                    october_calendar.InnerHtml += "Oct " + i + " is a Sunday!";
                                    if (weekdays.Value == "sunday")
                                    {
                                        october_calendar.InnerHtml += "work work work<br>";

                                    }

                                }
                                else
                                {
                                    october_calendar.InnerHtml += "Oct " + i + " is a Monday!<br>";
                                    if (weekdays.Value == "monday")
                                    {
                                        october_calendar.InnerHtml += "work work work<br>";

                                    }

                                }
                            }// what user selected 
                        }  //end of for loop which counts the days from Oct 1 to Oct 30!  */
                    }//end of foreach loop
                }
            }
        }
    }
}