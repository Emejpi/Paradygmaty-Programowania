using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StosKolejka
{
    class LinkListStack
    {
        Node top;

        public LinkListStack()
        {
            this.top = null;
        }

        public void Push(int value)
        {
            Node newNode = new Node(value);
            if (top == null)
            {
                newNode.next = null;
            }else
            {
                newNode.next = top;
            }
            top = newNode;
            Console.WriteLine("{0} pushed to stack", value);
        }

        public void Pop()
        {
            if (top == null)
            {
                Console.WriteLine("Stack Underflow. Deletion not possi");
                return;
            }

            Console.WriteLine("Item poped is {0}", top.data);
            top = top.next;
        }

        public void Peek()
        {
            if (top == null)
            {
                Console.WriteLine("Stack Underflow.");
                return;
            }

            Console.WriteLine("{0} is on the top of Stack", this.top.data);
        }
    }
}
