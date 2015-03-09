using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicketDiscount;

namespace Ticketing
{
    public class MovieTicket
    {
        private double price;
        private Dictionary<int, string> discountClasses = new Dictionary<int, string>();

        private string dllPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location).ToString();
        private Assembly theAssembly;

        public MovieTicket()
        {
            int i = 0;
            string[] discountNames = Properties.Settings.Default.DiscountName.Split(',');

            foreach (string discountName in discountNames)
            {
                discountClasses.Add(i, discountName);
                i++;
            }

            dllPath += "\\Discount.dll";
            theAssembly = Assembly.LoadFile(@dllPath);
        }

        public double Price
        {
            get { return this.price; }
            set { this.price = value; }
        }

        public double SetDiscount(int index)
        {
            Type calcType = theAssembly.GetType("TicketDiscount." + discountClasses[index]);
            object calcInstance = Activator.CreateInstance(calcType);
            return (double)calcType.InvokeMember("Calculate",
                BindingFlags.InvokeMethod | BindingFlags.Instance | BindingFlags.Public,
                null, calcInstance, new object[] { this.price });
        }
    }
}