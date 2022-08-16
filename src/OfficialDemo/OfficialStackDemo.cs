namespace CSharp_Self_Learning;

public class OfficialStack<T>
{
    Node? _top = null; // Entry of the Stack

    public void Push(T data)
    {
        _top = new Node(_top, data);
        // _top's next should always be the latter _top 
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
            throw new InvalidOperationException();
            // return;
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

    private class Node
    {
        public Node Next { get; set; }
        public T Data { get; set; }

        public Node(Node next, T data)
        {
            Next = next;
            Data = data;
        }
    }

    public static void IntExample()
    {
        OfficialStack<int>? UserStack = new(); // available

        for (int i = 0; i < 10; i++)
        {
            UserStack.Push(i);
        }
        UserStack.Echo();
        Console.WriteLine();

        for (int i = 0; i < 5; i++)
        {
            var Poped = UserStack.Pop();
            Console.WriteLine($"Poped => {Poped}");
        }
        Console.WriteLine();

        UserStack.Echo();
        Console.WriteLine();

    }
}