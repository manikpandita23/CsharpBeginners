using System;

class Program
{
    static void Main(string[] args)
    {
        Stack<int> myStack = new Stack<int>();

        // Push elements onto the stack
        myStack.Push(10);
        myStack.Push(20);
        myStack.Push(30);

        // Pop elements from the stack
        Console.WriteLine($"Popped element: {myStack.Pop()}");
        Console.WriteLine($"Popped element: {myStack.Pop()}");

        // Display the top element
        Console.WriteLine($"Top element: {myStack.Peek()}");

        // Wait for user input before exiting
        Console.ReadKey();
    }
}

class Stack<T>
{
    private T[] items;
    private int top;

    public Stack()
    {
        items = new T[10]; // Set stack size
        top = -1; // Initialize top index
    }

    public void Push(T item)
    {
        if (top < items.Length - 1)
            items[++top] = item;
        else
            Console.WriteLine("Stack is full!");
    }

    public T Pop()
    {
        if (top >= 0)
            return items[top--];
        else
        {
            Console.WriteLine("Stack is empty!");
            return default(T);
        }
    }

    public T Peek()
    {
        if (top >= 0)
            return items[top];
        else
        {
            Console.WriteLine("Stack is empty!");
            return default(T);
        }
    }
}
