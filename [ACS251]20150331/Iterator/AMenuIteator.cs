using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    class AMenuIteator : IEnumerator<MenuItem>
    {
        private int curIndex;
        private ArrayList curArrayList;

        public AMenuIteator(ArrayList arrayList)
        {
            this.curArrayList = arrayList;
            curIndex = -1;
        }

        public MenuItem Current
        {
            get { return (MenuItem)curArrayList[curIndex]; }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        object IEnumerator.Current
        {
            get { throw new NotImplementedException(); }
        }

        public bool MoveNext()
        {
            if (++curIndex < curArrayList.Count)
            {
                return true;
            }
            else
                return false;
        }

        public void Reset()
        {
            curIndex = -1;
        }
    }
}
