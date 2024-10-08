using System;
using System.Collections.Generic;


class LList
{
    public static void Delete(LinkedList<int> myLList, int index)
    {
        LinkedListNode<int> current = myLList.First;

        for (int i = 0; i < index; i++)
        {
            if (current == null || index < 0)
            {
                break;
            }
            current = current.Next;
        }
        if (index < 0 || current == null)
        {
            return;
        }
        else
        {
            myLList.Remove(current);
        }
    }
}