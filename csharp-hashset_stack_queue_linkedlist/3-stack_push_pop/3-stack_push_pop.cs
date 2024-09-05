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
            Console.WriteLine($"Stack contains\"{search}\": True");
            while (aStack.Count > 0)
            {
                string item = aStack.Pop();
                if (item == search)
                {
                    break;
                }
            }
        }
        else
        {
            Console.WriteLine($"Stack contains\"{search}\": False");
        }
        aStack.Push(newItem);

        return aStack;
    }
}