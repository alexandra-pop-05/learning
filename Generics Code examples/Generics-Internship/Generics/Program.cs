
using Generics;

//Generic class
var intDataStore = new GenericDataStore<int>();
intDataStore.Add(2);
intDataStore.Add(3);

var stringDataStore = new GenericDataStore<string>();
stringDataStore.Add("a");
stringDataStore.Add("b");

//Generic method
var intMax = GetMax(new List<int> { 1, 2, 3, 4 });
var doubleMax = GetMax(new List<double> { 1.2, 1.3, 1.4, 1.7 });
var stringMax = GetMax(new List<string> { "z", "b", "d" });
var personMax = GetMax(new List<Person> { 
   new Person("Ana", 21), 
   new Person("Mihai", 25), 
   new Person("Andrei", 18) 
});

Console.WriteLine($"int: {intMax}");  //4
Console.WriteLine($"double: {doubleMax}");  //1.7
Console.WriteLine($"string: {stringMax}");  //z
Console.WriteLine($"Person: {personMax.GetName()}");  //Mihai


T? GetMax<T>(List<T> list)
{
   if(list == null)
   {
       return default;
   }

   return list.Max();
}

class Person: IComparable<Person>
{
   private string name;
   private int age;

   public Person(string name, int age)
   {
       this.name = name;
       this.age = age;
   }
   public string GetName() => name;

   public int CompareTo(Person? other)
   {
       if (this.age > other.age)
       {
           return 1;
       }
       else if (this.age < other.age)
       {
           return -1;
       }
       else
       {
           return 0;
       }
   }
}



