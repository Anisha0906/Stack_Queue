using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
     class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            stack.Push(70);
            stack.Push(30);
            stack.Push(56);
            Console.WriteLine("Stack Structure- ");
            stack.Display();
            stack.IsEmpty();
            stack.Display();
            Queue queue = new Queue();
            queue.Enqueue(56);
            queue.Enqueue(30);
            queue.Enqueue(70);
            Console.WriteLine("Queue Structure- ");
            queue.Display();
            queue.Dequeue();
            Console.WriteLine("New Queue Structure- ");
            queue.Display();
            Console.ReadLine();
        }
    }
}
