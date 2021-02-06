using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsMyDictionary
{
    class MyDictionary<TKey,TValue>
    {
        TKey[] keys;
        TValue[] values;
        public MyDictionary()
        {
            keys = new TKey[0];
            values = new TValue[0];
        }
        public void Add(TKey key,TValue value)
        {
            TKey[] tempKeys = keys;
            TValue[] tempValues = values;

            keys = new TKey[keys.Length + 1];
            values = new TValue[values.Length + 1];
            for (int i = 0; i < tempKeys.Length; i++)
            {
                values[i] = tempValues[i];
                keys[i] = tempKeys[i];
            }
            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;
        }
        public void List()
        {
            for (int i = 0; i < keys.Length; i++)
            {
                Console.WriteLine("Id:" + keys[i] + " İsim:" + values[i]);
            }
            
        }
    }
}
