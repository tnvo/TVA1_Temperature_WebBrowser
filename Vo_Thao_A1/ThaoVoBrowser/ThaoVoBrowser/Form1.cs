using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThaoVoBrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.AcceptButton = btnGo;
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(txtURL.Text);   
        }

        private void encryptBtn_Click(object sender, EventArgs e)
        {
            EnDecryptService.ServiceClient myClient = new EnDecryptService.ServiceClient();
            encryptTxtResult.Text = myClient.Encrypt(textBox1.Text);
            myClient.Close();

        }

        private void checkStockBtn_Click(object sender, EventArgs e)
        {
            Stock.ServiceClient stockClient = new Stock.ServiceClient();
            stockResultLabel.Text = "$" + stockClient.getStockquote(stockTextBox.Text);
            stockClient.Close();

        }

    
    }
}
