using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StosKolejka
{
    class LinkListQueue
    {
        Node front;
        Node rear;

        public LinkListQueue()
        {
            this.front = this.rear = null;
        }

        public void Enqueue(int elem)
        {
            Node newNode = new Node(elem);

            if (this.rear == null)
            {
                this.front = this.rear = newNode;
            }
            else
            {
                this.rear.next = newNode;
                this.rear = newNode;
            }
            Console.WriteLine("{0} inserted into Queue", elem);
        }

        public void Dequeue()
        {
            if (front == null)
            {
                Console.WriteLine("The queue is empty.");
            }

            Node temp = this.front;
            this.front = this.front.next;

            if (this.front == null)
            {
                this.rear = null;
            }

            Console.WriteLine("Item deleted is {0}", temp.data);
        }

    }
}
