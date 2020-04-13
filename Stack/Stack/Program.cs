using Stack.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            var easyStack = new EasyStack<int>();

            easyStack.Push(1);
            easyStack.Push(2);
            easyStack.Push(3);
            easyStack.Push(4);
            easyStack.Push(5);
            Console.WriteLine("кількість елементів до операцій = "+easyStack.Count);
            var item = easyStack.Pop();
            var item2 = easyStack.Pop(); 
            var item3 = easyStack.Peek();
            Console.WriteLine("кількість елементів після операцій = "+easyStack.Count);
            
            Console.WriteLine(item);
            Console.WriteLine(item2);
            Console.WriteLine(item3);
            Console.ReadLine();
            
            Stack<double> stack = new Stack<double>();

            var linkedStack = new LinkedStack<int>();
            linkedStack.Push(10);
            linkedStack.Push(20);
            linkedStack.Push(30);


            Console.WriteLine(linkedStack.Peek());
            Console.WriteLine(linkedStack.Pop());
            Console.WriteLine(linkedStack.Pop());
            Console.WriteLine(linkedStack.Peek());
            Console.ReadLine();

            
            var arrayStack = new ArrayStack<int>(5);
            Console.WriteLine(arrayStack.Count);
            arrayStack.Push(100);
            Console.WriteLine(arrayStack.Count);
            arrayStack.Push(200);
            arrayStack.Push(300);
            arrayStack.Push(400);
            arrayStack.Push(500);

            Console.WriteLine(arrayStack.Peek());
            Console.WriteLine(arrayStack.Pop());
            Console.WriteLine(arrayStack.Pop());
            Console.WriteLine(arrayStack.Peek());

            Console.ReadLine();
        }
    }
}
