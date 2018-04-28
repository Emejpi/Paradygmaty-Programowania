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
            
            LinkListStack<int> stack = new LinkListStack<int>();
            LinkListQueue<char> queue = new LinkListQueue<char>();

            queue.Push('D');
            queue.Push('K');
            queue.Push('U');
            queue.Push('J');
            queue.Push('M');
            queue.Push('Y');
            queue.Push(' ');
            queue.Push('A');
            queue.Push(' ');
            queue.Push('U');
            queue.Push('W');
            queue.Push('A');

            stack.Push(3);
            stack.Push(6);
            stack.Push(2);
            stack.Push(3);
            stack.Push(3);
            stack.Push(1);
            stack.Push(2);

            Console.Write(queue.Pop());
            Console.Write(stack.Pop());
            Console.Write(stack.Pop());
            Console.Write(stack.Pop());
            Console.Write(queue.Pop());
            Console.Write(queue.Pop());
            Console.Write(queue.Pop());
            Console.Write(stack.Pop());
            Console.Write(queue.Pop());
            Console.Write(queue.Pop());
            Console.Write(queue.Pop());
            Console.Write(stack.Pop());
            Console.Write(queue.Pop());
            Console.Write(queue.Pop());
            Console.Write(queue.Pop());
            Console.Write(queue.Pop());
            Console.Write(queue.Pop());
            Console.Write(stack.Pop());
            Console.Write(stack.Pop());

            // Wywo³anie stosu:

            // stos.Push(10);
            // stos.Push(12);
            // stos.Push(40);
            // stos.Pop();
            // stos.Peek();
            // Console.ReadKey(true);

            // Wywo³anie kolejki:

            Console.ReadKey(true);
        }

    }
}