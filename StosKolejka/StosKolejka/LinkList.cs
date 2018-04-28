using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StosKolejka
{
    class LinkList<T>
    {
        protected Node<T> top;

        public T Pop()
        {
            if (top == null)
            {
                //Console.WriteLine("Stack Underflow. Deletion not possi");
                return default(T);
            }
                //Console.WriteLine("Item poped is {0}", top.data);
                T output = top.data;
                top = top.next;
                return output;
        }

        public bool IsEmpty()
        {
            return top != null;
        }

        public void Peek()
        {
            if (top == null)
            {
                Console.WriteLine("no data");
                return;
            }

            Console.WriteLine("{0} is first to go", this.top.data);
        }
    }
}
