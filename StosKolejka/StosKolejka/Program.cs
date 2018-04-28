using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StosKolejka
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Node node = new Node(10);
            LinkListStack stos = new LinkListStack();
            LinkListQueue queue = new LinkListQueue();

            // Wywo³anie stosu:

            // stos.Push(10);
            // stos.Push(12);
            // stos.Push(40);
            // stos.Pop();
            // stos.Peek();
            // Console.ReadKey(true);

            // Wywo³anie kolejki:

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);
            queue.Enqueue(6);

            queue.Dequeue();
            Console.ReadKey(true);
        }

    }
}