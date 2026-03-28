using System.Collections;

namespace Collection
{
    class Program
    {
        static void Main(string[] args) 
        {
            int[] marks = new int[5];
            marks[0] = 90;
            marks[1] = 99;
            marks[2] = 98;
            marks[3] = 97;
            marks[4] = 95;
            Console.WriteLine("--------Array-------");
            foreach (int mark in marks)
            {
                Console.WriteLine("Marks: " + mark);
            }

            int[] numbers = { 10, 20, 30, 40, 50 };
            foreach (int number in numbers)
            {
                Console.WriteLine("Numbers: " + number);
            }
            Console.WriteLine("-------Array List------");
            ArrayList arr = new ArrayList();
            arr.Add("Kishore");
            arr.Add(1234);
            arr.Add('A');
            arr.Add(98.5);

            for (int i = 0; i < arr.Count; i++) 
            {
                Console.WriteLine(arr[i]);
            }

            Console.WriteLine("--------List<T>---------");
            List<int> empId = new List<int>();
            empId.Add(101);
            empId.Add(102);
            empId.Add(103);

            foreach (int id in empId)
            {
                Console.WriteLine("EmpId: " +  id);
            }

            Console.WriteLine("----Hash Table----");
            Hashtable hash = new Hashtable();
            hash.Add("Name", "Kishore");
            hash.Add("EmpId", 101);
            hash.Add("Mobile", "9876543210");
            hash.Add("email", "kishork200@gmail.com");

            foreach(var details in hash.Keys)
            {
                Console.WriteLine(hash[details]);
            }

            Console.WriteLine("-------Sorted List--------");
            SortedList sort = new SortedList();
            sort.Add(1, "123");
            sort.Add(2, "124");
            sort.Add(3, "125");
            sort.Add(4, "126");

            foreach (var id in sort.Keys) 
            {
                Console.WriteLine(sort[id]);
            }

            Console.WriteLine("--------Dictionary----------");
            Dictionary<int, String> dic = new Dictionary<int, String>();
            dic.Add(1, "101");
            dic.Add(2, "102");
            dic.Add(3, "103");

            foreach (var id in dic.Keys) { 
                Console.WriteLine(dic[id]);
            }

            Console.WriteLine("--------Stack------");
            Stack stack = new Stack();
            stack.Push("Kishore");
            stack.Push("Kumar");
            stack.Push("Ramesh");

            while (stack.Count > 0) { 
                Console.WriteLine(stack.Pop());
            }
            Console.WriteLine("-------Generic Stack-------");
            Stack<String> genericStack = new Stack<String>();
            genericStack.Push("Barath");
            genericStack.Push("Kumar");
            genericStack.Push("Ramesh");

            while (genericStack.Count > 0) { 
                Console.WriteLine(genericStack.Pop());
            }

            Console.WriteLine("--------Queue-------");
            Queue queue = new Queue();
            queue.Enqueue("Kishore");
            queue.Enqueue("Kumar");
            queue.Enqueue("Ramesh");

            while (queue.Count > 0)
            {
                Console.WriteLine(queue.Dequeue());
            }

            Console.WriteLine("---------Generic Queue----------");
            Queue<String> genericQueue = new Queue<String>();
            genericQueue.Enqueue("Barath");
            genericQueue.Enqueue("Kumar");
            genericQueue.Enqueue("Ramesh");

            while (genericQueue.Count > 0) { 
                Console.WriteLine(genericQueue.Dequeue());

            }
        }
    }
}