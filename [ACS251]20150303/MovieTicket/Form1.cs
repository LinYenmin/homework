using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ticketing
{
    public partial class Form1 : Form
    {
        private List<string> resultList = new List<string>();
        //private string currentDir = Environment.CurrentDirectory;

        private double price = Properties.Settings.Default.TicketPrice;

        private string[] discountList = Properties.Settings.Default.DiscountList.Split(',');

        private double truePrice;
        private double totalPrice;

        public Form1()
        {
            InitializeComponent();
            DiscountComboBox.DataSource = discountList;
            DiscountComboBox.SelectedIndex = 0;
        }

        private void shbmitButton_Click(object sender, EventArgs e)
        {
            MovieTicket ticket = new MovieTicket() { Price = this.price };
            truePrice = ticket.SetDiscount(DiscountComboBox.SelectedIndex);

            resultList.Add(string.Format("{0}張{1}票，原價{2}元 特價{3}元,小計{4}元",
                ticketNumericUpDown.Value, DiscountComboBox.SelectedItem,
                price, truePrice, truePrice * (double)(ticketNumericUpDown.Value)));

            totalPrice += truePrice * (double)(ticketNumericUpDown.Value);
            resultRichTextBox.Text = string.Join(Environment.NewLine, resultList);
            resultRichTextBox.AppendText(string.Format("\n總計{0}元", totalPrice));
        }
    }
}