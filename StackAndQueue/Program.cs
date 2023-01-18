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
            Console.ReadLine();
        }
    }
}
