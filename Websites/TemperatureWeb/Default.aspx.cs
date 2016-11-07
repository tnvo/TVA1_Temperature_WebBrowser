using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void c2fButton_Click(object sender, EventArgs e)
    {
        try
        {
            TemperatureService.Service1Client c2fClient = new TemperatureService.Service1Client();
            int c = Convert.ToInt32(c2fText.Text);
            int result = c2fClient.c2f(c);
            c2fResult.Text = result.ToString() + " °F";
            c2fClient.Close();
        }
        catch (FormatException)
        {
            c2fResult.Text = "Please enter a valid number!";
        }
    }

    protected void f2cButton_Click(object sender, EventArgs e)
    {
        try
        {
            TemperatureService.Service1Client f2cClient = new TemperatureService.Service1Client();
            int f = Convert.ToInt32(f2cText.Text);
            int result = f2cClient.f2c(f);
            f2cResult.Text = result.ToString() + " °C";
            f2cClient.Close();
        }
        catch (FormatException)
        {
            f2cResult.Text = "Please enter a valid number!";
        }
    }
}