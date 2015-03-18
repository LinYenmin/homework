using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Order
{
    public partial class Form1 : Form
    {
        List<string> Items;
        FoodList foodlist;
        RichTextBox[] richTextBoxes;
        Random rnd;
        Queue<string[]> orderQQ;
        OrderAction orderAction;

        public Form1()
        {
            InitializeComponent();
            richTextBoxes = new RichTextBox[]
                                  {this.OrderRichTextBox1, this.OrderRichTextBox2, 
                                   this.OrderRichTextBox3, this.OrderRichTextBox4,
                                   this.OrderRichTextBox5, this.OrderRichTextBox6};

            foodlist = new FoodList();
            Items = foodlist.FoodMenu();

            rnd = new Random();
            //orderQQ = new Queue<string[]>();
            orderAction = new OrderAction();
        }

        private void OrderButton_Click(object sender, EventArgs e)
        {
            UpdateUI(orderAction.Order());
        }

        private void ReadyButton_Click(object sender, EventArgs e)
        {
            orderQQ = orderAction.Ready();
            if (orderQQ.Count > 0)
            {
                UpdateUI(orderQQ);
            }
            else
            {
                UpdateUI(orderQQ);
                MessageBox.Show("沒訂單了~可以休息了");
            }
        }


        private void UpdateUI(Queue<string[]> queue)
        {
            this.toGoLabel.Text = queue.Count.ToString();
            for (int i = 0; i < richTextBoxes.Length; i++)
            {
                richTextBoxes[i].Text = String.Empty;
            }
            
            for (int i = 0; i < richTextBoxes.Length; i++)
            {
                if (i < queue.Count)
                    richTextBoxes[i].Text = String.Join("\n",queue.ElementAt(i));
                else
                    break;
            }
            this.Refresh();
             
        }

        
    }
}
