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

        public T Get()
        {
            if (top == null)
            {
                return default(T);
            }
            return top.data;
        }

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

        public bool Pop(out T value)
        {
            if (top == null)
            {
                value = default(T);
                return false;
            }
            value = top.data;
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
                Console.WriteLine("no data");
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
