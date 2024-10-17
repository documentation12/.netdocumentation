using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._3
{
    public class MyCollection<T>
    {
        List<T> list = new List<T>();

        public void AddItem(T item)
        {
            list.Add(item);
        }

        public T Getstring(int index)
        {
            return list[index];
        }
    }
}
