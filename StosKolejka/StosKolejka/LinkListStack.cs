using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StosKolejka
{
    class LinkListStack<T> : LinkList<T>
    {
        public LinkListStack()
        {
            top = null;
        }

        public void Push(T value)
        {
            Node<T> newNode = new Node<T>(value);
            if (top == null)
            {
                newNode.next = null;
            }else
            {
                newNode.next = top;
            }
            top = newNode;
            //Console.WriteLine("{0} pushed to stack", value);
        }
    }
}
