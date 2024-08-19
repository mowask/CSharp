using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace CS_L13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Stack stack = new Stack();
            //stack.Push(2.3);
            //stack.Push(55);
            //stack.Push("Hello");
            //stack.Push("world");
            //stack.Push("!");

            //Console.WriteLine("stack.Count = " + stack.Count);
            //Console.WriteLine("stack.Contains(2.3) = " + stack.Contains(2.3));
            //Console.WriteLine("stack.Contains(11) = " + stack.Contains(11));
            //Console.WriteLine("stack.Peek() = " + stack.Peek());

            //Console.WriteLine();
            //foreach (object o in stack)
            //{
            //    Console.WriteLine(o);
            //}
            //Console.WriteLine();
            //int count = stack.Count;
            //for (int i = 0; i < count; i++)
            //{
            //    Console.WriteLine(stack.Pop());
            //}
            //Console.WriteLine();
            //Console.WriteLine("stack.Count = " + stack.Count);

            //Console.WriteLine("\n=================================================================================\n");

            ////////////////////////////////////////////////////////////////////////////////  Queue

            //Queue queue = new Queue();
            //queue.Enqueue(2.3);
            //queue.Enqueue(55);
            //queue.Enqueue("Hello");
            //queue.Enqueue("world");
            //queue.Enqueue("!");

            //Console.WriteLine("stack.Count = " + queue.Count);
            //Console.WriteLine("stack.Contains(2.3) = " + queue.Contains(2.3));
            //Console.WriteLine("stack.Contains(11) = " + queue.Contains(11));
            //Console.WriteLine("stack.Peek() = " + queue.Peek());

            //Console.WriteLine();
            //foreach (object o in queue)
            //{
            //    Console.WriteLine(o);
            //}
            //Console.WriteLine();
            //int countQ = queue.Count;
            //for (int i = 0; i < countQ; i++)
            //{
            //    Console.WriteLine(queue.Dequeue());
            //}
            //Console.WriteLine();
            //Console.WriteLine("stack.Count = " + queue.Count);

            //Console.WriteLine("\n=================================================================================\n");

            ////////////////////////////////////////////////////////////////////////////////  Hashtable   = map c++  (ключ, значение)

            //Hashtable hashtable = new Hashtable();
            //hashtable.Add("001", 2.3);
            //hashtable[002] = 55;
            //hashtable.Add("003", "Hello");
            //hashtable.Add("004", "world");
            //hashtable.Add("005", "1");

            //foreach (object key in hashtable) 
            //{
            //    Console.WriteLine(key + " : " + hashtable[key]);
            //}
            //Console.WriteLine($"Существует ли элемент \"004\": {hashtable.ContainsKey("004")}") ;
            //hashtable.Remove("004");
            //Console.WriteLine($"Существует ли элемент \"004\": {hashtable.ContainsKey("004")}");

            //hashtable["002"] = 66;
            //Console.WriteLine(hashtable["002"]);

            //try
            //{
            //    hashtable.Add("003", "Hello");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}


            //Console.WriteLine("\n=================================================================================\n");

            ////////////////////////////////////////////////////////////////////////////////  SoertedList

            //SortedList sortedList = new SortedList();
            //sortedList["002"] = 55;
            //sortedList.Add("005", "!");
            //sortedList.Add("003", "Hello");
            //sortedList.Add("001", 2.3);
            //sortedList.Add("004", "world");

            //foreach (object key in sortedList.Keys)
            //{
            //    Console.WriteLine(key + " : " + sortedList[key]);
            //}

            //Console.WriteLine($"Существует ли элемент \"004\": {sortedList.ContainsKey("004")}");
            //sortedList.Remove("004");
            //Console.WriteLine($"Существует ли элемент \"004\": {sortedList.ContainsKey("004")}");

            //sortedList["002"] = 66;
            //Console.WriteLine(sortedList["002"]);

            //try
            //{
            //    sortedList.Add("003", "Hello");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //Console.WriteLine("\n=================================================================================\n");

            ////////////////////////////////////////////////////////////////////////////////  


            //Console.WriteLine($"Максимальное покколение: {GC.MaxGeneration}");

            //GarbageHelper hlp = new GarbageHelper();

            //Console.WriteLine($"Занято памяти (байт): {GC.GetTotalMemory(false)}");

            //Console.WriteLine("\nhlp.MakeGarbage()");
            //hlp.MakeGarbage(); // создает мусор

            //Console.WriteLine($"Поколение объекта: {GC.GetGeneration(hlp)}");
            //Console.WriteLine($"Занято памяти (байт): {GC.GetTotalMemory(false)}");

            //Console.WriteLine("\nGC.Collect(0)");
            //GC.Collect(0); //вызываем явный сбор мусора в поколении 0

            //Console.WriteLine($"Поколение объекта: {GC.GetGeneration(hlp)}");
            //Console.WriteLine($"Занято памяти (байт): {GC.GetTotalMemory(false)}");

            //Console.WriteLine("\nGC.Collect()");
            //GC.Collect();   //вызываем явный сбор мусора во всех поколениях

            //Console.WriteLine($"Поколение объекта: {GC.GetGeneration(hlp)}");
            //Console.WriteLine($"Занято памяти (байт): {GC.GetTotalMemory(false)}");


            //Console.WriteLine("\n=================================================================================\n");

            ////////////////////////////////////////////////////////////////////////////////

            //DisposeExample test1 = new DisposeExample();
            //test1.Dispose();

            //DisposeExample test2 = new DisposeExample();
            //Console.WriteLine();

            //DisposeExample test3 = new DisposeExample();
            //try
            //{
            //    test3.DoSomething();
            //}
            //finally 
            //{ 
            //    test1.Dispose(); 
            //}
            //Console.WriteLine();

            //using (DisposeExample test = new DisposeExample())
            //{
            //    test.DoSomething();
            //}


            //Console.WriteLine("\n=================================================================================\n");

            ////////////////////////////////////////////////////////////////////////////////
            ///

            List <int> listInt = new List<int>(); 

            Random random= new Random();
            for (int i = 0; i < 10; i++)
                listInt.Add(random.Next(10));

            listInt[0] = 11;
            Console.WriteLine("listInt[5]" + listInt[0]);

            Console.WriteLine("listInt.Contains(5)" + listInt.Contains(5));

            listInt.ForEach((int x) => Console.Write($"{x} "));
            Console.WriteLine();

            listInt.Remove(11);

            foreach (int i in listInt)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            //string str = "Test";
            //Console.WriteLine(str.StartsWith("T"));

            List<string> list = new List<string>(new string[]
            {
                "John",
                "Jane",
                "Tom",
                "Bill",
                "jack",
                "Sam"
            });

            

            foreach (string i in list)
            {
                if (i.StartsWith("j") || i.StartsWith("J"))
                    Console.WriteLine(i);
            }

            Console.WriteLine();


            list.Sort();
            var listJ = list.Where(s => s.ToUpper().StartsWith("J")).OrderBy(s => s); 
            foreach (var item in listJ)
                Console.WriteLine(item);

            Console.WriteLine("\n=================================================================================\n");

            List <Employee> listE = new List<Employee>(new Employee[]
            {
                new Employee ("John", 21),
                new Employee ("Jane", 32),
                new Employee ("Alex", 18),
                new Employee ("Tom", 19),
                new Employee ("jack", 19),
            });

            var listEJ = listE.Where(e => e.Name.ToUpper().StartsWith("J")).OrderBy(e => e.Age);
            foreach (var e in listEJ)
                Console.WriteLine(e.Name + " " + e.Age);


        }

        class Employee
        {
            public string Name { get; set; }    
            public int Age { get; set; }
            public Employee(string name, int age) 
            { 
                Age = age;
                Name = name;
            }
        }
    }
}
