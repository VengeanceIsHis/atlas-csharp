using System;
using System.Collections.Generic;


class LList
{
    public static int FindNode(LinkedList<int> myLList, int value)
    {
        LinkedListNode<int> current = myLList.First;
        int position = 0;
        foreach (int obj in myLList)
        {
            if (current.Value == value)
            {
                return position;
            }
            current = current.Next;
            position++;
        }
        return -1;
    }
}