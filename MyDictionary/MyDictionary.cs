using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    class MyDictionary<T, A>
    {
        T[] keys;
        A[] values;
        T[] tempKeys;
        A[] tempValues;

        public MyDictionary()
        {
            keys = new T[0];
            values = new A[0];
        }

        public void Add(T key, A value)
        {
            tempKeys = keys;
            keys = new T[keys.Length + 1];
            tempValues = values;
            values = new A[values.Length + 1];

            for (int i = 0; i < tempKeys.Length; i++)
            {
                keys[i] = tempKeys[i];
            }
            keys[keys.Length - 1] = key;

            for (int j = 0; j < tempValues.Length; j++)
            {
                values[j] = tempValues[j];
            }
            values[values.Length - 1] = value;

        }

        public int Count
        {
            get { return keys.Length; }

        }
        public void Show()
        {
            for (int i = 0; i < keys.Length; i++)
            {
                Console.WriteLine("Ders Kodu: " + keys[i] + " Ders Adı: " + values[i]);
            }
        }
    }
}
