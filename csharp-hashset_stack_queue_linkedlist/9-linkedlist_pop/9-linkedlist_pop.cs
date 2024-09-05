using System;
using System.Collections.Generic;


class LList
{
    public static int Pop(LinkedList<int> myLList)
    {
        LinkedListNode<int> current = myLList.First;
        int value = current.Value;
        myLList.Remove(current);
        return value;
    }
    
}