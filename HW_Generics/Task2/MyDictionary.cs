using System;
using System.Collections.Generic;

namespace Task2
{
    class MyDictionary<TKey, TValue>
    {
        private Pair[] pairsArray;

        public int Length
        {
            get {
                if (pairsArray != null)
                {
                    return pairsArray.Length;
                }
                else
                {
                    return 0;
                }
            }
        }

        public TValue this[TKey index]
        {
            get
            {
                for (int i = 0; i < pairsArray.Length; i++)
                {
                    if (pairsArray[i].Key.Equals(index))
                    {
                        return pairsArray[i].Value;
                    }
                }
                Console.WriteLine("Element pair with such key is not found");
                throw new KeyNotFoundException();
            }
        }

        public void Add(TKey key, TValue value){
            Pair pair = new Pair(key, value);

            if (pairsArray == null)
            {
                pairsArray = new Pair[] { pair };
            }
            else
            {
                for (int i = 0; i < pairsArray.Length; i++)
                {
                    if (pairsArray[i].Key.Equals(key))
                    {
                        Console.WriteLine("Element pair with such key already exists");
                        return;
                    }
                }
                Array.Resize(ref pairsArray, pairsArray.Length + 1);
                pairsArray[pairsArray.Length - 1] = pair;
            }
        }

        class Pair
        {
            private TKey key;
            private TValue value;

            public Pair(TKey key, TValue value){
                this.key = key;
                this.value = value;
            }

            public TKey Key
            {
                get { return key; }
            }

            public TValue Value
            {
                get { return value; }
            }
        }
    }
}
