using System;
using System.Collections.Generic;


class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        Stack<int> tempStack = new Stack<int>();

        Console.WriteLine("Number of items: " + aStack.Count);
        if (aStack.Count == 0)
        {
            Console.WriteLine("Stack is empty");
        }
        Console.WriteLine("Top item: " + aStack.Peek());

        if (aStack.Contains(search))
        {
            Console.WriteLine("Stack contains " + search + ": True");
            for (int i = 0; i < aStack.Count; i++)
            { 
                if (item == search)
                {
                    string item = aStack.Pop();
                    break;
                }
                string item = aStack.Pop();
            }
        }
        else
        {
            Console.Write("Stack contains " + search + ": False");
        }
        aStack.Push(newItem);

        return aStack;
    }
}