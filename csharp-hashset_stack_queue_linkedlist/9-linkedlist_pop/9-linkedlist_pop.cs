using System;
using System.Collections.Generic;


class LList
{
    public static int Pop(LinkedList<int> myLList)
    {
        LinkedListNode<int> current = myLList.First;
        myLList.Remove(current);
    }
}