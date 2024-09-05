using System;
using System.Collections.Generic;


class Mystack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        Console.WriteLine("Number of items: " + aStack.Count);
        if (aStack.Count == 0)
        {
            Console.WriteLine("Stack is empty")
        }
        Console.WriteLine("Top item: " + aStack[aStack.Count]);

    }
}