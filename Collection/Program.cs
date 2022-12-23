using System;
using System.Collections;
using System.Collections.Generic;

namespace Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            List();
            Stack();
            Queue();
            Set();
            Dictinory();

        }
        private static void List()
        {
            Console.WriteLine(" Names in List........");
            List<string> list = new List<string>();
            list.Add("Ram");
            list.Add("Shyam");
            list.Add("Ajay");
            list.Add("Vijay");
     
            foreach (var element in list)
            {
                Console.WriteLine(element);
            }
        }
        private static void Stack() 
        {
            Console.WriteLine("Names in Stack.......");
            Stack<string> stack= new Stack<string>();
            stack.Push("Neha");
            stack.Push("Riya");
            stack.Push("Tanvi");
            stack.Push("Shreya");
            string pop = stack.Pop();

            foreach (var element in stack) 
            {
            Console.WriteLine(element);
            }
            Console.WriteLine("Popped Element:" + pop);
        }

        private static void Queue()
        {
            Console.WriteLine("Names in Queue........");
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Raj");
            queue.Enqueue("Amit");
            queue.Enqueue("Shree");
            queue.Enqueue("Rohan");
            Console.WriteLine("Head" +queue.Peek());
            Console.WriteLine("Queue Elements are :");
             
            //Iterating Queue Elements
            foreach (var element in queue)
            {
             Console.WriteLine(element);
            }
            string dequeue=queue.Dequeue();
            Console.WriteLine("Dequeue elements:" + dequeue);
            Console.WriteLine("Queue elements after dequeue one element:");
            
        }
        private static void Set()
        {
            Console.WriteLine("Set...... ");
            var set = new HashSet<string>();
            set.Add("ajay");
            set.Add("Vijay");
            set.Add("Ravi");
            set.Add("Raj");

            HashSet<string>.Enumerator enumerator= set.GetEnumerator();
            while (enumerator.MoveNext()) 
            {
            Console.Write(enumerator.Current);
            }
        }

        private static void Dictinory()
        {
            Console.WriteLine("Dictionary.....");
            Dictionary<int, string> dictinory = new Dictionary<int, string>();
            dictinory.Add(100, "Amit");
            dictinory.Add(200, "Rahul");
            dictinory.Add(300, "Rohit");

            Console.WriteLine("Access value using key (key=100):" + dictinory[100]);
            Console.WriteLine("\nIterating Dictonary:");
            foreach(var element in dictinory) 
            {
            Console.WriteLine("Key="+element.Key+"&Value="+element.Value);
            }
        }



    }
}
