using System;
using System.Collections.Generic;


class LList
{
    public static int GetNode(LinkedList<int> myLList, int n)
    {
        int i = 0;
        LinkedListNode<int> current = myLList.First;
        while (current.Next != null)
        {
            if (i == n)
            {
                return current.Value;
            }
            Console.Write(current.Value)
            current = current.Next;
        }
        return 0;
    }
}