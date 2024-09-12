using System;
using System.Collections.Generic;
using System.Xml.XPath;


class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        LinkedListNode<int> current = myLList.First;
        LinkedListNode<int> result = null;

        if (current.Value >= n)
        {
            result = myLList.AddFirst(n);
            return result;
        }

        while (current != null)
        {
            if (current.Next == null || current.Next.Value > n)
            {
                result = myLList.AddAfter(current, n);
                break;
            }
            current = current.Next;

        }
        return result;
    }
}