using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksAndQueues
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> myList = new List<int>();
            Queue<int> myQueue = new Queue<int>();
            Stack<int> myStack = new Stack<int>();

            myStack.Push(1);
            myStack.Push(14);
            myStack.Push(28);
            int topOfStack = myStack.Pop();
            Console.WriteLine(topOfStack);
            myStack.Push(90);
            Console.WriteLine("================");
            foreach(int data in myStack)
            {
                Console.WriteLine(data);
            }

            myQueue.Enqueue(8);
            myQueue.Enqueue(4);
            myQueue.Enqueue(2);
            int beginningOfQ = myQueue.Dequeue();
            Console.WriteLine(beginningOfQ);
            Console.ReadLine();
        }

    }
}
