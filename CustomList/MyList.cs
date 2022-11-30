
using System.Collections;

namespace CustomList
{
    public class MyList<T>
    {
        public int Capacity { get; set; }
        public T[] list;
        static int Count;

        public MyList(int capacity)
        {
            Capacity = capacity;
            list = new T[capacity];
        }

        public void Add(T item)
        {
            if (Capacity == 0)
            {
                Capacity = 2;
                Array.Resize<T>(ref list, Capacity);
                list[0] = item;
                Count++;
                return;

            }
            if (Capacity == Count)
            {
                Capacity *= 2;
                Array.Resize<T>(ref list, Capacity);
                list[Capacity / 2] = item;
                Count++;
                return;
            }
            list[Count ] = item;
            Count++;

        }
        public bool Exsist(Predicate<T> fumc)
        {
            for (int i = 0; i < list.Length; i++)
            {
                if (fumc(list[i]))
                {
                    return true;
                }
            }
            return false;
        }

      public T this[int index]
        {
            get { return list[index]; }
            set { list[index] = value; }    
        }
    }
}
