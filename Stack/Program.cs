namespace Stack;
class Program
{
    static void Main(string[] args)
    {
        Stack<int> stack = new Stack<int>();
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);
        Console.WriteLine("Count: " + stack.Count());
        Console.WriteLine(stack.Pop());
        Console.WriteLine("Count after pop: " + stack.Count());
        Console.WriteLine(stack.Peek());
        Console.WriteLine("Count after peak: " + stack.Count());

    }
}
