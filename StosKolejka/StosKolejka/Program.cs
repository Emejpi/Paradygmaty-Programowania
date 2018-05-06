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

            Console.WriteLine("Stack");
            stack.Show();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Show();
            stack.Pop();
            stack.Show();
            stack.Clear();
            stack.Show();
            Console.WriteLine(stack.Pop());

            Console.WriteLine("");

            Console.WriteLine("Queue");
            queue.Show();
            queue.Push('A');
            queue.Push('B');
            queue.Push('C');
            queue.Show();
            queue.Pop();
            queue.Show();

            char charContainer;
            while(queue.Pop(out charContainer))
            {
                Console.WriteLine("container: " + charContainer);
            }
            queue.Show();

            Console.ReadKey(true);
        }

    }
}