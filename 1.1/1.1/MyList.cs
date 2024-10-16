using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1
{
    public class MyList<T>
    {
        List<T> list = new List<T>();

       
        public void Add(T value)
        {
            list.Add(value);
        }

        public T Get(int index)
        {
            return list[index];
        }
    }
}
