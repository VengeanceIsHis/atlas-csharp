using System;
using System.Collections.Generic;


class LList
{
    public static LinkedListNode<int> Insert(linkedList<int> myLList, int n)
    {
        int i = 0;
        LinkedListNode<int> current = myLList.First;
        LinkedListNode<int> new = new LinkedListNode<int>;
        new.Value = n;
        while (current != null)
        {
            if (current.Value < n)
            {
                if (current.Prev == null)
                {
                    
                }
            }
            i++;
            current = current.Next;
        }
    }
}