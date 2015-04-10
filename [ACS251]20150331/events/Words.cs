using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace events
{
    public class Words
    {
        //public event EventHandler<Args> sentence;
        public event EventHandler sentence;

        /*
        private Args args;
        
        public void Speak(EventArgs e)
        {
            if (e is Args)
            {
                this.args = e as Args;
                this.sentence(this, this.args);
            }
        }
         */ 

        public void Speak()
        {
          this.sentence(this, new EventArgs());
        }

    }
}
