namespace CustomListConsole
{
    public class CustomList
    {
        private int[] items;
        private int count;

        public CustomList()
        {
            items = new int[10];
            count = 0;
        }

        public CustomList(int size)
        {
            items = new int[size];
            count = 0;
        }

        public void Add(int item)
        {
            if (count == items.Length)
            {
                Array.Resize(ref items, items.Length * 2); // Double the capacity if full
            }
            items[count++] = item;
        }

        public void Remove(int item)
        {
            if (count == 0)
            {
                throw new ArgumentException("List is empty");
            }
            for (int i = 0; i < count; i++) // Search for the item 
            {
                if (items[i] == item)
                {
                    RemoveAt(i);
                    return;
                }
            }
        }

        public void RemoveAt(int index)
        {
            if (index >= 0 && index < count)
            {
                --count;
                for (int i = index; i < count; i++) // Shift items to the left by 1
                {
                    items[i] = items[i + 1];
                }
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }

        public bool Contains(int item)
        {
            for (int i = 0; i < count; ++i)
            {
                if (items[i] == item)
                {
                    return true;
                }
            }
            return false;
        }

        public int Count()
        {
            return count;
        }

        public void Clear()
        {
            count = 0;
        }

        public int Get(int index)
        {
            if (index >= 0 && index < count) return items[index];
            throw new IndexOutOfRangeException();
        }

        public void PrintAllElement()
        {
            if (count > 0)
            {
                Console.WriteLine("-----");
                string result = "";
                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine(items[i]);
                }
                Console.WriteLine("-----");
            }
            else
            {
                Console.WriteLine("List is empty");
            }
        }
    }
}