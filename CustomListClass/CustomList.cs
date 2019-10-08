using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClass
{
    public class CustomListClass<T>
    {
        private T[] items;

        public CustomListClass()
        {
            items = new T[4];
        }

        public void Add(T itemToAdd)
        {

        }
    }
}
