using Task1;

namespace Task3
{
    static class MyListExtender
    {
        public static T[] GetArray<T>(this MyList<T> list)
        {
            T[] array = new T[list.Length];

            for (int i = 0; i < list.Length; i++)
            {
                array[i] = list[i];
            }

            return array;
        }
    }
}
