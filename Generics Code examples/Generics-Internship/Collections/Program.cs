using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;

//Non generic collections
var arrayList = new ArrayList();

arrayList.Add(2); //boxing -> convert value type to reference type -> integer to object
arrayList.Add(3);

//unboxing -> convert object to integer because ArrayList stores item as object type
foreach (int item in arrayList)
{
   Console.WriteLine(item);
}


var hashtable = new Hashtable();
hashtable.Add(1, 1);
hashtable.Add(2, 2);
hashtable.Add(3, "3");
hashtable.Add("3", "3");

foreach (DictionaryEntry entry in hashtable)
{
   Console.WriteLine($"{entry.Key} - {entry.Value}");
}

//Lists
var persons = new List<Person>();

//add items in the list
persons.Add(new Person("Ana", 18));
persons.Add(new Person("Maria", 22));
persons.Add(new Person("Andrei", 26));

//inserts a new item at position 2
persons.Insert(2, new Person("Ioana", 20));

//remove item at index 3
persons.RemoveAt(3);

foreach (var person in persons)
{
   Console.WriteLine(person.GetName());
}

class Person
{
   private string name;
   private int age;

   public Person(string name, int age)
   {
       this.name = name;
       this.age = age;
   }

   public string GetName() => name;
}

//Queues
Queue<int> queue = new Queue<int>();
queue.Enqueue(1);
queue.Enqueue(2);
queue.Enqueue(3);

while(queue.Count > 0)
{
   var item = queue.Dequeue();
   Console.Write(item);
}

//Output: 1 2 3

//Concurrent dictionary
//Dictionary<int, string> dictionary = new ConcurrenDictionary<int, string>();
ConcurrentDictionary<int, string> dictionary = new ConcurrentDictionary<int, string>();

Thread t1 = new Thread(AddToDictionary1);
Thread t2 = new Thread(AddToDictionary2);

t1.Start();
t2.Start();

t1.Join();
t2.Join();

foreach (KeyValuePair<int, string> item in dictionary)
{
    Console.WriteLine($"Key:{item.Key}, Value:{item.Value}");
}

void AddToDictionary1()
{
    for (int i = 0; i < 10; i++)
    {
        //dictionary.Add(i, "Added by AddToDictionary1 " + i);
        dictionary.TryAdd(i, "Added by AddToDictionary1 " + i);
        Thread.Sleep(100);
    }
}

void AddToDictionary2()
{
    for (int i = 0; i < 10; i++)
    {
        //dictionary.Add(i, "Added by AddToDictionary2 " + i);
        dictionary.TryAdd(i, "Added by AddToDictionary2 " + i);
        Thread.Sleep(100);
    }
}




