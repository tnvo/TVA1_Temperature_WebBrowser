using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemperatureApp
{
    public partial class TemperatureForm : Form
    {
        public TemperatureForm()
        {
            InitializeComponent();
        }

        private void c2fButton_Click(object sender, EventArgs e)
        {
            try
            {
                TemperatureService.Service1Client c2fClient = new TemperatureService.Service1Client();
                int c = Convert.ToInt32(c2fText.Text);
                int result = c2fClient.c2f(c);
                c2fResultLabel.Text = result.ToString() + " °F";
                c2fClient.Close();
            }
            catch (FormatException)
            {
                c2fResultLabel.Text = "Please enter a valid number!";
            }
        }

        private void f2cButton_Click(object sender, EventArgs e)
        {
            try
            { 
                TemperatureService.Service1Client f2cClient = new TemperatureService.Service1Client();
                int f = Convert.ToInt32(f2cText.Text);
                int result = f2cClient.f2c(f);
                f2cResultLabel.Text = result.ToString() + " °C";
                f2cClient.Close();
            }

            catch (FormatException)
            {
                f2cResultLabel.Text = "Please enter a valid number!";
            }
        }
    }
}
