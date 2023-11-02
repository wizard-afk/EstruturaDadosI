using System;
using System.Collections.Generic;
using System.Threading;

namespace QueueClass
{
    public class CustomQueue
    {
        private Queue<string> queue = new Queue<string>();

        public void Enqueue(string data)
        {
            queue.Enqueue(data);
        }

        public string Dequeue()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Fila Vazia");
                return null;
            }

            return queue.Dequeue();
        }

        public string Peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Fila Vazia");
                return null;
            }

            return queue.Peek();
        }

        public bool IsEmpty()
        {
            return queue.Count == 0;
        }

        public void PrintQueue()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Fila Vazia");
                return;
            }

            Console.WriteLine("Elementos na fila:");
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            CustomQueue fila = new CustomQueue();

            fila.Enqueue("Chamada 1");
            fila.Enqueue("Chamada 2");
            fila.Enqueue("Chamada 3");
            fila.Enqueue("Chamada 4");

            fila.PrintQueue();

            Console.WriteLine("Elemento na frente da fila: " + fila.Peek());

            Console.WriteLine("Removendo elemento da frente da fila: " + fila.Dequeue());

            fila.PrintQueue();
        }
    }
}