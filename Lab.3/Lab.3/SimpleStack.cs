using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class SimpleStack<T> : SimpleList<T> where T : IComparable
    {
        public void Push(T elem)
        {
            Add(elem);
        }
        public T Pop()
        {
            T res = default(T); //!!
            if (this.Count == 0) return res;
            if (this.Count == 1)
            {
                res = this.first.data;
                this.first = null;
                this.last = null;
            }
            else
            {
                SimpleListItem<T> newLast = this.GetItem(this.Count - 2);
                res = newLast.next.data;
                this.last = newLast;
                newLast.next = null;
            }
            this.Count--;
            return res;
        }
    }
}