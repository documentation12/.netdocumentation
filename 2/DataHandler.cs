using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz2
{
    public class DataHandler<T>
    {
        private List<T> dList = new List<T>();

        public void AddData(T item)
        {
            dList.Add(item);
        }

        public T RetrieveData(int index)
        {
            return dList[index];
        }
    }
}