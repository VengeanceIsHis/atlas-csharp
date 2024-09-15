using System;


public class Queue<T>
{
    public Node head { get; private set; }
    public Node tail { get; private set; }
    public int count { get; private set; }

    public Queue()
    {
        head = null;
        tail = null;
        count = 0;
    }

    public class Node
    {
        public T value = default(T);
        public Node next = null;

        public Node(T value)
        {
            this.value = value;
            this.next = null;
        }
    }
    public Type CheckType()
    {
        return typeof(T);
    }
    
    public void Enqueue(T value)
    {
        Node newNode = new Node(value);
        if (tail != null)
        {
            tail.next = newNode;
        }
        tail = newNode;

        if (head == null)
        {
            head = newNode;
        }
        count++;
    }

    public override int Count()
    {
        return this.count;
    }

}