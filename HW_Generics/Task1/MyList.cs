using System;

namespace Task1
{
    public class MyList<T>
    {
        private T[] array;

        public int Length
        {
            get {
                if (array != null)
                {
                    return array.Length;
                }
                else
                {
                    return 0;
                }
            }
        }

        public T this[int index]
        {
            get
            {
                if (array != null && index < array.Length)
                {
                    return array[index];
                }
                else
                {
                    Console.WriteLine("No such element");
                    throw new IndexOutOfRangeException();
                }
            }
        }

        public void Add(T elem)
        {
            if (array == null)
            {
                array = new T[] { elem };
            }
            else
            {
                Array.Resize(ref array, array.Length + 1);
                array[array.Length - 1] = elem;
            }
        }
    }
}
