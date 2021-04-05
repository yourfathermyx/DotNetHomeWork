using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //整型list
            GenericList<int> genericList = new GenericList<int>();
            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                genericList.Add(random.Next(0, 10));
            }
            //show
            genericList.ForEach(Console.WriteLine);
            //求和
            int sum = 0;
            genericList.ForEach(x => sum += x);

            //求max
            int max = genericList.Head.Data;
            genericList.ForEach(
                x =>
                {
                    if (max < x)
                        max = x;
                }
            );

            //求min
            int min = genericList.Head.Data;
            genericList.ForEach(
                x =>
                {
                    if (x < min) min = x;
                }
            );

            Console.WriteLine($"sum:{sum}");
            Console.WriteLine($"max:{max}");
            Console.WriteLine($"min:{min}");

        }
    }

    public class GenericList<T> where T : IComparable
    {
        private Node<T> head;
        private Node<T> tail;

        public GenericList()
        {
            tail = head = null;
        }

        public Node<T> Head { get => head; }

        public void Add(T t)
        {
            Node<T> node = new Node<T>(t);
            if (tail == null)
            {
                head = tail = node;
            }
            else
            {
                tail.Next = node;
                tail = node;
            }
        }

        public void ForEach(Action<T> action)
        {
            Node<T> node = head;
            while (node != null)
            {
                action(node.Data);
                node = node.Next;
            }

        }

    }

    public class GenericList<T> where T : IComparable
    {
        private Node<T> head;
        private Node<T> tail;

        public GenericList()
        {
            tail = head = null;
        }

        public Node<T> Head { get => head; }

        public void Add(T t)
        {
            Node<T> node = new Node<T>(t);
            if (tail == null)
            {
                head = tail = node;
            }
            else
            {
                tail.Next = node;
                tail = node;
            }
        }

        public void ForEach(Action<T> action)
        {
            Node<T> node = head;
            while (node != null)
            {
                action(node.Data);
                node = node.Next;
            }

        }

    }
}
