namespace Queue;
public class MyQueue
{
    private int[] items;

    private int Head;
    private int Tail;

    public MyQueue()
    {
        items = new int[10];
        Head = -1;
        Tail = -1;
    }

    public MyQueue(int size)
    {
        items = new int[size];
        Head = -1;
        Tail = -1;
    }

    public void Enqueue(int item)
    {
        if (Head == -1)
        {
            Head = 0;
        }
        items[++Tail] = item;
    }

    public void Reset()
    {
        Head = -1;
        Tail = -1;
        items = new int[10];
    }

    public int Dequeue()
    {
        if (Tail == -1)
        {
            throw new Exception("Queue is empty");
        }
        int item = items[Head];
        if (Head == Tail)
        {
            Reset();
        }
        else
        {
            ++Head;
        }
        return item;
    }

    public int Front()
    {
        if (Head == -1)
        {
            throw new Exception("Queue is empty");
        }
        return items[Head];
    }

    public int Count()
    {
        if (Head == -1) return 0;
        return Tail - Head + 1;
    }

}