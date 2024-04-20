namespace Stack
{
    public class Stack<T>
    {
        private T[] items;
        private int count;
        public Stack()
        {
            items = new T[100];
            count = 0;
        }

        public Stack(int size)
        {
            items = new T[size];
            count = 0;
        }

        public void Push(T item)
        {
            items[count++] = item;
        }

        public T Pop()
        {
            if (count == 0)
            {
                throw new InvalidOperationException("Stack is empty");
            }
            return items[--count];
        }

        public T Peek()
        {
            if (count == 0)
            {
                throw new InvalidOperationException("Stack is empty");
            }
            return items[count - 1];
        }

        public int Count()
        {
            return count;
        }
    }
}