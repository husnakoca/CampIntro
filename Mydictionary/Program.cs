using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mydictionary
{
    class MyDictionary<T1>
    {
        T1[] items;
        public MyDictionary()
        {
            items = new T1[0];
            items = new T1[1];

        }

        public void Add(T1 item)
        {
            T1[] tempArray = items;
            items = new T1[items.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            items[items.Length - 1] = item;
        }
    }
}
