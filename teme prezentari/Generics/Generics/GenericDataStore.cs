using System;
using System.Collections.Generic;

namespace Generics
{
    internal class GenericDataStore
    {
        public class GenericStore<T>
        {
            private List<T> _list = new List<T>();

            public void Add(T item)
            {
                _list.Add(item);
            }

            public List<T> GetList()
            {
                return _list;
            }

            public override string ToString()
            {
                return string.Join(", ", _list);
            }

        }


       /* static void Main(string[] args)
        {
            var intDataStore = new GenericStore<int>();
            intDataStore.Add(2);
            intDataStore.Add(3);

            Console.WriteLine(intDataStore.ToString());

            var stringDataStore = new GenericStore<string>();
            stringDataStore.Add("e");
            stringDataStore.Add("f");

            Console.WriteLine(stringDataStore.ToString());
        }*/

    }
}
