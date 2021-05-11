using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExample
{
    class MyList<K, V>
    {
        K[] keys;
        K[] keysArray;
        V[] values;
        V[] valuesArray;



        public MyList()
        {
            keys = new K[0];
            values = new V[0];
        }

        public void Add(K key, V value)
        {
            keysArray = keys;
            keys = new K[keys.Length + 1];
            for (int i = 0; i < keysArray.Length; i++)
            {
                keys[i] = keysArray[i];
            }
            keys[keys.Length - 1] = key;

            valuesArray = values;
            values = new V[values.Length + 1];
            for (int i = 0; i < valuesArray.Length; i++)
            {
                values[i] = valuesArray[i];
            }
            values[values.Length - 1] = value;
        }

        public int KLength
        {
            get { return keys.Length; }
        }
        public K[] key
        { 
            get { return keys; }
        }

        public int VLength
        {
            get { return values.Length; }
        }
        public K[] value
        {
            get { return value; }
        }
    }
}
