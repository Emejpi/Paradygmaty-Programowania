using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StosKolejka
{
    class LinkListQueue<T> : LinkList<T>
    {
        Node<T> bottom;

        public LinkListQueue()
        {
            top = bottom = null;
        }

        public void Push(T elem)
        {
            Node<T> newNode = new Node<T>(elem);

            if (bottom == null)
            {
                top = bottom = newNode;
            }
            else
            {
                bottom.next = newNode;
                bottom = newNode;
            }
        }

       
    }
}
