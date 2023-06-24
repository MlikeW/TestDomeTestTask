using System;
using System.Collections.Generic;
using System.Windows.Forms;
using log4net;
using log4net.Config;


namespace AmazonOrderPrice
{
    public partial class OrderDetailsForm : Form
    {

        private static readonly ILog log = LogManager.GetLogger(typeof(OrderDetailsForm));

        public OrderDetailsForm()
        {
            InitializeComponent();
        }

        private string GetCountry()
        {
            string country = GetTextBoxText(countryTextBox);
            log.Info($"Country: {country}");

            return country;
        }

        private string GetCategory()
        {
            string category = GetTextBoxText(categoryTextBox);
            log.Info($"Category: {category}");

            return category;
        }

        private string GetTextBoxText(TextBox textBox) => textBox.Text;

        private void sendButton_Click(object sender, EventArgs e)
        {
            categoryTextBoxError.Text = string.Empty;
            countryTextBoxError.Text = string.Empty;
            var category = GetCategory();
            var country = GetCountry();

            if (IsInputInvalid(category))
            {
                categoryTextBoxError.Text = "ERROR input is null of white spaces";
                resultLabel.Text = "Input error :(";
                return;
            }

            if (IsInputInvalid(country))
            {
                countryTextBoxError.Text = "ERROR input is null of white spaces";
                resultLabel.Text = "Input error :(";
                return;
            }

            resultLabel.Text = "processing ^.^";
            new SeleniumMethods().GetAmazonPrice(category, country, out string price);
            resultLabel.Text = price;
            log.Info($"Price: {price}");
        }

        private bool IsInputInvalid(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return true;
            }
            return false;
        }

        private void OrderDetailsForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
    }
}