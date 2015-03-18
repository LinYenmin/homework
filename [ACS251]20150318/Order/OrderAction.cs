using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Order
{
    public class OrderAction
    {
        public Queue<string[]> orderQ = new Queue<string[]>();
        private Random rnd = new Random();

        List<string> Items = new FoodList().FoodMenu();
        int serialNum = 1;

        public Queue<string[]> Order()
        {
            int selectedNum = rnd.Next(1, Items.Count + 1);
            string[] selectedItems = new string[selectedNum + 1];
            int index = 1;
            string item = string.Empty;

            selectedItems[0] = string.Format("==序號{0}==",serialNum);

            do
            {
                item = Items[rnd.Next(0, Items.Count)];
                if (!selectedItems.Contains(item))
                {
                    selectedItems[index] = item;
                    index++;
                }

            } while (index <= selectedNum);

            orderQ.Enqueue(selectedItems);
            serialNum++;
            return orderQ;
        }

        public Queue<string[]> Ready()
        {
            if (orderQ.Count > 0)
                orderQ.Dequeue();

            return orderQ;
        }

    }
}
