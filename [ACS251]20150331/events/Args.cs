using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace events
{
    public class Args:EventArgs
    {
        private string text;

        public string Text
        {
            get { return text; }
            set { text = value; }
        }
    }
}
