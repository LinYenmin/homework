using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace events
{
    public partial class Form1 : Form
    {
        public delegate string DD(int x);

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Words word = new Words();
            Dirty dirty = new Dirty();

            word.sentence += dirty.DirtyWord;
            MessageBox.Show("1." + dirty.SomeDirty + "\n");

            word.Speak();
            MessageBox.Show("2." + dirty.SomeDirty + "\n");

            word.Speak();
            MessageBox.Show("3." + dirty.SomeDirty + "\n");


            DD dd = new DD(RR);

            MessageBox.Show(dd(4));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("123");
        }

        string RR(int x)
        {
            return x.ToString();
        }
    }
}
