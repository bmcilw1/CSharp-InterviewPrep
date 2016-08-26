// Brian McIlwain
// This is to practice using standard stacks and queue
// Problem: Implement a queue using only two stacks

using System;
using System.Collections.Generic;

public class MyQueue<T>
{
    private Stack<T> OutputStack = new Stack<T>();
    private Stack<T> InputStack = new Stack<T>();

    public int Count = 0;

    public T Dequeue()
    {
        if (OutputStack.Count == 0)
        {
            while (InputStack.Count > 0)
            {
                OutputStack.Push(InputStack.Pop());
            }
        }

        if (OutputStack.Count > 0)
        {
            Count--;
            return OutputStack.Pop();
        }
        else
        {
            return default (T);
        }
    }

    public void Enqueue(T item)
    {
        InputStack.Push(item);
        Count++;
    }
}

public class TestMyQueue
{
    public static void Main()
    {
        MyQueue<int> mq = new MyQueue<int>();

        mq.Enqueue(1);
        mq.Enqueue(2);

        Console.WriteLine("Inline: " + mq.Dequeue());

        mq.Enqueue(3);
        mq.Enqueue(4);

        Console.WriteLine("Inline: " + mq.Dequeue());

        mq.Enqueue(5);

        while (mq.Count > 0)
        {
            Console.WriteLine(mq.Dequeue());
        }
    }
}
