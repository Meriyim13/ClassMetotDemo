using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyList<T,V>
    {
        T[] _key;
        V[] _value;
        T[] _tempKey;
        V[] _tempValue;
        public MyList()
        {
            _key = new T[0];
            _value = new V[0];
        }
        public void Add(T key, V value)
        {
            _tempKey = _key;
            _tempValue = _value;
            _key = new T[_key.Length + 1];
            _value = new V[_value.Length + 1];

            for (int i = 0; i <_tempKey.Length; i++)
            {
                _key[i] = _tempKey[i];
            }
            for (int a = 0; a < _tempValue.Length; a++)
            {
                _value[a] = _tempValue[a];
            }
        }
    

        public int Count
        {
            get;       

        }

    }
}
