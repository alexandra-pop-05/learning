namespace Generics
{
    internal class Program
    {
        /*public class GenericDataStore<T>
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

            }*/


        /* T? GetMax<T>(List<T?> list) where T : struct
         {
             if (list == null || list.Count == 0)
             {
                 return default;
             }

             return list.Max();
         }*/




        /*T GetMaxValue<T>(List<T> list) where T : IComparable<T>
        {
            if (list == null || list.Count == 0)
            {
                throw new ArgumentException("List is null or empty.");
            }

            T max = list[0];
            for (int i = 1; i < list.Count; i++)
            {
                if (list[i].CompareTo(max) > 0)
                {
                    max = list[i];
                }
            }

            return max;
        }*/

        class Student { }
        class Employee { }

        class Manager : Employee { }

        class GenericClass<T> where T : Employee { }


       /* static void Main(string[] args)
        {
            *//*var intDataStore = new GenericDataStore<int>();
            intDataStore.Add(1);
            intDataStore.Add(2);
            intDataStore.Add(3);
            intDataStore.Add(4);

            Console.WriteLine(intDataStore.ToString());

            var stringDataStore = new GenericDataStore<string>();
            stringDataStore.Add("a");
            stringDataStore.Add("b");

            Console.WriteLine(stringDataStore.ToString());

            *//* var intMax = GetMaxValue<int>(new List<int> { 1, 2, 3, 4, 5 });
             Console.WriteLine($"Max int value: {intMax}");

             var stringMax = GetMaxValue<string>(new List<string> { "apple", "orange", "banana" });
             Console.WriteLine($"Max string value: {stringMax}");*//*


            //constraints
            var manager = new GenericClass<Manager>();
           // var student = new GenericClass<Student>(); // error because Student class is not related to Employee
           var employee = new GenericClass<Employee>();*//*

        }*/
    }
}
