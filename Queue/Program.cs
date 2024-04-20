namespace Queue;
class Program
{
    static void Main(string[] args)
    {
        MyQueue queue = new MyQueue();
        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);
        Console.WriteLine("Count: " + queue.Count());
        Console.WriteLine("Dequeue: " + queue.Dequeue());
        Console.WriteLine("Count after dequeue: " + queue.Count());
        Console.WriteLine("Front: " + queue.Front());
        queue.Reset();
        Console.WriteLine("Count: " + queue.Count());
    }
}
