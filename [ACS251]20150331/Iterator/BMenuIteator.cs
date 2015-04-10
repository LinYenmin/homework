using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    internal class BMenuIteator : IEnumerator<MenuItem>
    {
        private MenuItem[] menuItems;
        private int index;

        public BMenuIteator(MenuItem[] menuItems)
        {
            this.menuItems = menuItems;
            index = -1;
        }

        public MenuItem Current
        {
            get { return menuItems[index]; }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        object System.Collections.IEnumerator.Current
        {
            get { throw new NotImplementedException(); }
        }

        public bool MoveNext()
        {
            if (++index < menuItems.Length)
                return true;
            else
                return false;
        }

        public void Reset()
        {
            index = -1;
        }
    }
}