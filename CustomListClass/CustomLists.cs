using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClass
{
    public class CustomLists<T>
    {
        private T[] items;

        public CustomLists()
        {
            items = new T[4];
        }

        public void Add(T itemToAdd)
        {

        }
    }
}
