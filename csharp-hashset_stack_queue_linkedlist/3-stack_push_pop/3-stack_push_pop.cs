using System;
using System.Collections.Generic;


class Mystack
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

        if (aStack.Contains("search"))
        {
            for (int i = 0; i < aStack.Count; i++)
            {
                string item = aStack.Pop();
                if (item == "search")
                {
                    break;
                }
            }
        }
        astack.push(newItem);

        return Astack;
    }
}