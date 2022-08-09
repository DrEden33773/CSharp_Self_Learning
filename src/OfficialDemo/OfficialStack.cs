using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp_Self_Learning.src
{
    public class OfficialStack<T>
    {
        Entry? _top; // Entry of the Stack

        public void Push(T data)
        {
            _top = new Entry(_top, data);
        }

        public T Pop()
        {
            if (_top == null)
            {
                throw new InvalidOperationException();
            }
            T result = _top.Data;
            _top = _top.Next;

            return result;
        }

        public void Echo()
        {
            if (_top == null)
            {
                Console.WriteLine("Stack is empty.");
                return;
            }
            var current = _top;
            while (current != null)
            {
                Console.Write($"{current.Data} ");
                current = current.Next;
            }
            Console.Write("\b \b");
            Console.WriteLine();
        }

        class Entry
        {
            public Entry Next { get; set; }
            public T Data { get; set; }

            public Entry(Entry next, T data)
            {
                Next = next;
                Data = data;
            }
        }

        public static void IntExample()
        {
            OfficialStack<int>? UserStack = new OfficialStack<int>();

            for (int i = 0; i < 10; i++)
            {
                UserStack.Push(data: i);
            }
            UserStack.Echo();

            for (int i = 0; i < 5; i++)
            {
                UserStack.Pop();
            }
            UserStack.Echo();
        }
    }
}