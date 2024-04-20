namespace CustomListConsole;
class Program
{
    static void Main(string[] args)
    {
        CustomList list = new CustomList();
        list.Add(1);
        list.Add(2);
        list.Add(3);
        Console.WriteLine(list.Count());
        list.Remove(1);
        list.PrintAllElement();
    }
}
