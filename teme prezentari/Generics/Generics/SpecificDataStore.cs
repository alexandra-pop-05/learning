using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Generics.GenericDataStore;

namespace Generics
{
    internal class SpecificDataStore
    {
        public class IntDataStore
        {
            private List<int> _intList = new List<int>();
            public void Add (int value) { 
                _intList.Add (value);
            }

            public List<int> GetList()
            {
                return _intList;
            }
            public override string ToString()
            {
                return string.Join(", ", _intList);
            }
        }

        public class StringDataStore
        {
            private List<string> _stringList = new List<string>();
            public void Add(string value)
            {
                _stringList.Add(value);
            }

            public List<string> GetList()
            {
                return _stringList;
            }

            public override string ToString()
            {
                return string.Join(", ", _stringList);
            }
        }


        static void Main(string[] args)
        {
            var intDataStore = new IntDataStore();
            intDataStore.Add(2);
            intDataStore.Add(3);

            Console.WriteLine(intDataStore.ToString());

            var stringDataStore = new StringDataStore();
            stringDataStore.Add("e");
            stringDataStore.Add("f");

            Console.WriteLine(stringDataStore.ToString());
        }
    }
}
