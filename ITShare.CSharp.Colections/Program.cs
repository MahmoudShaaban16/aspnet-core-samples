using System.Collections;
using System.Collections.Generic;

namespace ITShare.CSharp.Colections
{
    internal class Student : IEnumerable
    {
        private string name;

        public Student(string v)
        {
            this.name = v;
        }
        public Student()
        {

        }
        public decimal[] degrees { get; set; }
        public int Degree { get; internal set; }

        public IEnumerator GetEnumerator()
        {
            return new StudentEnumerator();
        }
    }

    internal static class GenericListEx
    {
        public static List<int> SortDesc(this List<int> arr, string sortType)
        {
            arr.Sort();
            arr.Reverse();
            return arr;
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {

            StackQueueExample();
        }
         static void StackQueueExample()
        {
            //FIFO
            Queue<Student> myStudentsQueue = new Queue<Student>();
            myStudentsQueue.Enqueue(new Student("Mahmoud"));
            myStudentsQueue.Enqueue(new Student());
            myStudentsQueue.Enqueue(new Student());
            myStudentsQueue.Enqueue(new Student());

            Student mahmoud = myStudentsQueue.Dequeue();

            // LIFO

            Stack<Student> myStudentsStack = new Stack<Student>();
            myStudentsStack.Push(new Student("Mahmoud"));
            myStudentsStack.Push(new Student());
            myStudentsStack.Push(new Student());
            myStudentsStack.Push(new Student());

            myStudentsStack.Pop();
        }
        static void LinkedListExample()
        {
            LinkedList<Student> studentsList = new LinkedList<Student>();
            var linkedListNode = studentsList.AddFirst(new Student());
            var node2 = studentsList.AddAfter(linkedListNode, new Student());
            studentsList.AddAfter(linkedListNode, new Student());
        }

        private static void DictionaryExample()
        {
            Dictionary<string, int> myDictionary = new Dictionary<string, int>();
            myDictionary.Add("ahmed", 20);
            myDictionary.Add("mahmoud", 20);
            int sumOfDegrees = 0;
            foreach (KeyValuePair<string, int> keyVal in myDictionary)
            {
                sumOfDegrees += keyVal.Value;
            }
        }

        private static void HashTableExample()
        {
            Hashtable myHashtable = new Hashtable();
            myHashtable.Add("mahmoud", new Student() { Degree = 20 });
            myHashtable.Add("ahmed", new Student());

            foreach (string name in myHashtable.Keys)
            {
                // we have a casting issue and lost the strongly typing feature
                Student s = myHashtable[name] as Student;
            }
        }

        private static void GenericListExample()
        {
            List<int> numberList = new List<int>();
            numberList.Add(4);
            numberList.Add(5);
            numberList.Add(20);
            numberList.Sort();
        }

        private static void arrayListExample()
        {
            ArrayList numberArray = new ArrayList(3);
            numberArray.Add(3);
            numberArray.Add("mahmoud");

            foreach (object el in numberArray)
            {
                if (el.GetType() == typeof(int))
                {
                }
                else if (el is string)
                {
                }
            }
        }

        private static void sortArray()
        {
            int[] numbers = new int[4];
            numbers[0] = 4;
            numbers[1] = 3;
            numbers[2] = 20;
            numbers[3] = 10;

            int sum = 0;

            for (int j = numbers.Length - 1; j >= 0; j--)
            {
                int max = 0;
                int maxIndex = 0;
                for (int x = 0; x <= j; x++)
                {
                    if (numbers[x] > max)
                    {
                        max = numbers[x];
                        maxIndex = x;
                    }
                }
                var val = numbers[j];
                numbers[j] = max;
                numbers[maxIndex] = val;
            }
            var average = sum / numbers.Length;
        }
    }
}