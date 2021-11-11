using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EssentialLesson10Task3
{
    class MyDictionary<TKey, TValue> 
    {

        TKey[] keyArr = new TKey[0];
        TValue[] valueArr = new TValue[0];

        public int Count => keyArr.Length;
        public (TKey, TValue) this[int index] => (index > keyArr.Length || index < 0) ? throw new IndexOutOfRangeException($"Impossible to get value by index {index}") :
                                                                                        (keyArr[index], valueArr[index]);

        public void Add(TKey key, TValue value)
        {
            if (key == null || value == null) throw new NullReferenceException("Incoming parameter cant be NULL");

            for (int i = 0; i < keyArr.Length; i++)
            {
                if (key.Equals(keyArr[i]))
                {
                    valueArr[i] = value;
                    return;
                }
            }

            Array.Resize(ref keyArr, keyArr.Length + 1);
            Array.Resize(ref valueArr, valueArr.Length + 1);
            keyArr[keyArr.Length - 1] = key;
            valueArr[valueArr.Length - 1] = value;
        }

        public (TKey, TValue) GetPairByValue(TValue value)
        {
            TKey retKey = default;
            TValue retValue = default;

            if (value == null) throw new NullReferenceException("Incoming value was null");

            for (int i = 0; i < valueArr.Length; i++)
            {
                if (value.Equals(valueArr[i]))
                {
                    retKey = keyArr[i];
                    retValue = valueArr[i];
                    break;
                }
                else
                {
                    throw new Exception("COllection doesnt have this value");
                }
            }
            return (retKey, retValue);
        }

        public (TKey, TValue) GetPairByKey(TKey key)
        {
            TKey retKey = default;
            TValue retValue = default;

            if (key == null) throw new NullReferenceException("Incoming value was null");

            for (int i = 0; i < keyArr.Length; i++)
            {
                if (key.Equals(keyArr[i]))
                {
                    retKey = keyArr[i];
                    retValue = valueArr[i];
                    break;
                }
                else
                {
                    throw new Exception("COllection doesnt have this value");
                }
            }
            return (retKey, retValue);
        }

        public void DeleteByKey(TKey key)
        {
            int temp = default;

            if (key == null) throw new NullReferenceException("Incoming value was null");

            for (int i = 0; i < keyArr.Length; i++)
            {
                if (i == keyArr.Length - 1)
                {
                    break;
                }
                else if (key.Equals(keyArr[i]))
                {
                    temp = i;
                    break;
                }
                else
                {
                    throw new Exception("COllection doesnt have this key");
                }
            }

            for (int i = temp; i < keyArr.Length; i++)
            {
                if (i == keyArr.Length - 1)
                {
                    break;
                }
                keyArr[i] = keyArr[i + 1];
                valueArr[i] = valueArr[i + 1];
            }

            Array.Resize(ref keyArr, keyArr.Length - 1);
            Array.Resize(ref valueArr, valueArr.Length - 1);

        }

    }
}
