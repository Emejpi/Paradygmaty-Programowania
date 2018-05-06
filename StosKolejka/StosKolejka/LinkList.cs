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
                return default(T);
            }
                T output = top.data;
                top = top.next;
                return output;
        }

        public bool Pop(out T valueContainer)
        {
            if (top == null)
            {
                valueContainer = default(T);
                return false;
            }
            valueContainer = top.data;
            top = top.next;
            return true;
        }

        public bool IsEmpty()
        {
            return top == null;
        }

        public void Clear()
        {
            while(!IsEmpty())
            {
                Pop();
            }
        }

        public void Show()
        {
            if (top == null)
            {
                Console.WriteLine("data: empty");
                return;
            }
            Console.Write("data: ");
            Node<T> currentNode = top;
            while (currentNode != null)
            {
                Console.Write(currentNode.data);
                currentNode = currentNode.next;
            }
            Console.WriteLine("");
        }
    }
}
