using System.Diagnostics;

namespace GenericsCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<T>
            var list = new List<int>();
            for (int i = 0; i < 100000; i++)
            {
                list.Add(i);
            }
            MeasureExecutionTime(() =>
            {
                int sum = 0;
                foreach (int num in list)
                {
                    sum += num;
                }
            }, "List");


            // LinkedList<T>
            var linkedList = new LinkedList<int>();
            for (int i = 0; i < 100000; i++)
            {
                linkedList.AddLast(i);
            }
            MeasureExecutionTime(() =>
            {
                int sum = 0;
                foreach (int num in linkedList)
                {
                    sum += num;
                }
            }, "LinkedList");

            // HashSet<T>
            var hashSet = new HashSet<int>();
            for (int i = 0; i < 100000; i++)
            {
                hashSet.Add(i);
            }
            MeasureExecutionTime(() =>
            {
                int sum = 0;
                foreach (int num in hashSet)
                {
                    sum += num;
                }
            }, "HashSet");

            //SortedSet<T>
            var sortedSet = new SortedSet<int>();
            for (int i = 0; i < 100000; i++)
            {
                sortedSet.Add(i);
            }
            MeasureExecutionTime(() =>
            {
                int sum = 0;
                foreach (int num in sortedSet)
                {
                    sum += num;
                }
            }, "SortedSet");

            //Queue<T>
            var queue = new Queue<int>();
            for (int i = 0; i < 100000; i++)
            {
                queue.Enqueue(i);
            }
            MeasureExecutionTime(() =>
            {
                int sum = 0;
                foreach (int num in queue)
                {
                    sum += num;
                }
            }, "Queue");

            //Stack<T>
            var stack = new Stack<int>();
            for (int i = 0; i < 100000; i++)
            {
                stack.Push(i);
            }
            MeasureExecutionTime(() =>
            {
                int sum = 0;
                foreach (int num in stack)
                {
                    sum += num;
                }
            }, "Stack");

            // Dictionary<TKey, TValue>
            var dictionary = new Dictionary<int, string>();
            for (int i = 0; i < 100000; i++)
            {
                dictionary.Add(i, $"Value {i}");
            }
            MeasureExecutionTime(() =>
            {
                foreach (var item in dictionary)
                {
                    int key = item.Key;
                    string value = item.Value;
                }
            }, "Dictionary");

            //SortedList<TKey, TValue>
            var sortedList = new SortedList<int, string>();
            for (int i = 0; i < 100000; i++)
            {
                sortedList.Add(i, $"Value {i}");
            }
            MeasureExecutionTime(() =>
            {
                foreach (var item in sortedList)
                {
                    int key = item.Key;
                    string value = item.Value;
                }
            }, "SortedList");

            // SortedDictionary<TKey, TValue>
            var sortedDictionary = new SortedDictionary<int, string>();
            for (int i = 0; i < 100000; i++)
            {
                sortedDictionary.Add(i, $"Value {i}");
            }
            MeasureExecutionTime(() =>
            {
                foreach (var item in sortedDictionary)
                {
                    int key = item.Key;
                    string value = item.Value;
                }
            }, "SortedDictionary");
        }

        static void MeasureExecutionTime(Action action, string collectionName)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            action.Invoke();

            stopwatch.Stop();
            Console.WriteLine($"{collectionName} Execution time is: {stopwatch.Elapsed}");
        }
    }
}