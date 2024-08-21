using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace CS_L14_Files
{

    class TestAttribute : Attribute
    {
        public int X { get; }
        public TestAttribute (int x) 
        { 
            X = x;
        }
    }

    [TestAttribute(15)]

    public class Test { }




    internal class Program
    {


        static void Main(string[] args)
        {

            //Type type= typeof(Test);
            //object[] attributes = type.GetCustomAttributes(false);
            //foreach (object attr in attributes) 
            //{
            //    if ( attr is TestAttribute)
            //    {
            //        Console.WriteLine((attr as TestAttribute).X);
            //    }
            //}

            //Console.WriteLine("\n==================================================================================\n");


            Company microsoft = new Company() { Name = "Mcirosoft"};
            Person person = new Person("Tom", 29, microsoft);

            // создаем объект BinaryFormatter
            BinaryFormatter formatter = new BinaryFormatter();
            //
            using (FileStream fs = new FileStream ("people.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, person);
                Console.WriteLine("Объект сериализован");
            }
            Console.WriteLine();


            using (FileStream fs = new FileStream("people.dat", FileMode.OpenOrCreate))
            {
                try
                {
                    Person newPerson = (Person)formatter.Deserialize(fs);

                    Console.WriteLine("Объект Десериализован");
                    Console.WriteLine(newPerson);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            Console.WriteLine();
            Console.WriteLine();

            Company apple = new Company() { Name = "Apple" };
            Person[] people = new Person[]
            {
                new Person ("Tom", 29, microsoft),
                new Person ("Jane", 24, microsoft),
                new Person ("Bill", 25, apple)
            };

            using (FileStream fs = new FileStream("people.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, people);
                Console.WriteLine("Объект сериализован");
            }
            Console.WriteLine();

            using (FileStream fs = new FileStream("people.dat", FileMode.OpenOrCreate))
            {
                try
                {
                    Person[] newPeople = (Person[])formatter.Deserialize(fs);

                   foreach (Person p in newPeople)
                    {
                        Console.WriteLine(p);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            Console.WriteLine("\n==================================================================================\n");


            XmlSerializer serializer = new XmlSerializer(typeof(Person[]));
            using (FileStream fs = new FileStream("people.xml", FileMode.OpenOrCreate))
            {
                serializer.Serialize(fs, people);
                Console.WriteLine("xml");
            }
            Console.WriteLine();


            using (FileStream fs = new FileStream("people.xml", FileMode.OpenOrCreate))
            {
                try
                {
                    Person[] newPeople = (Person[])serializer.Deserialize(fs);
                    if (newPeople != null)
                    {
                        foreach (Person p in newPeople)
                        {
                            Console.WriteLine(p);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }





            Console.WriteLine("\n==================================================================================\n");



            const double byteToGB = 1024 * 1024 * 1024;
            DriveInfo[] drives = DriveInfo.GetDrives();

            foreach (DriveInfo drive in drives)
            {
                Console.WriteLine($"Название: {drive.Name}");
                Console.WriteLine($"Тип: {drive.DriveType}");
                if (drive.IsReady)
                {
                    Console.WriteLine($"Объем диска: {drive.TotalSize / byteToGB:0.00} GB");
                    Console.WriteLine($"Свободное пространство: {drive.TotalFreeSpace / byteToGB:0.00} GB");
                    Console.WriteLine($"Метка диска: {drive.VolumeLabel}");
                }
                Console.WriteLine();
            }


            string path = Directory.GetCurrentDirectory();
            Console.WriteLine(path); // Debug
            Console.WriteLine();

            DirectoryInfo current = new DirectoryInfo(path);
            Console.WriteLine(current.FullName);    // путь к ехе файлу
            Console.WriteLine(current.Name);        // название папки
            Console.WriteLine();

            DirectoryInfo parent = current.Parent;
            Console.WriteLine(parent.FullName);
            Console.WriteLine(parent.Name);
            Console.WriteLine();

            DirectoryInfo parentParent = parent.Parent;
            Console.WriteLine(parentParent.FullName);
            Console.WriteLine(parentParent.Name);
            Console.WriteLine();

            Console.WriteLine("==================================================================================");

            //                                  показываем все папки внутри дирректории
            DirectoryInfo[] dirs = parentParent.GetDirectories();
            foreach (var dir in dirs)
            {
                Console.WriteLine(dir.Name);
            }
            Console.WriteLine();
            //                                  показываем все файлы внутри дирректории
            FileInfo[] files = parentParent.GetFiles();
            foreach (var file in files)
            {
                Console.WriteLine(file.Name);
            }

            //                                  создаем папки
            DirectoryInfo dirTest = Directory.CreateDirectory("Test");                     //  новая папка в текщей
            DirectoryInfo dirTest2 = Directory.CreateDirectory(@"C:\Test2");                //  новая папка на с:
            DirectoryInfo dirTest3 = Directory.CreateDirectory(@"C:\Test2\test");
            Console.WriteLine();

            Console.WriteLine(Directory.Exists(@"C:\Test2\test"));                          // проверка существует ли папка

            Console.WriteLine("==================================================================================");

            //string text = "Hello World!";
            //Console.WriteLine(text);
            //byte[] bytes= Encoding.Default.GetBytes(text);
            //for(int i = 0; i< text.Length; i++)
            //{
            //    Console.WriteLine(text[i] + " : "  + bytes[i]);
            //}
            //Console.WriteLine(Encoding.Default.GetString(bytes));

            Console.WriteLine("==================================================================================\n");

            string text = "Hello World!";
            string filePath = "text.bin";

            WriteToFile(filePath, text);
            ReadFromFile(filePath, text);

            Console.WriteLine("\n==================================================================================\n");

            string[] textArr = { "One", "Two", "Tree" };
            string filePath1 = "text.txt";

            using (StreamWriter sw = new StreamWriter(filePath1, false))     // true/false      разрешает/запрещает  перезапись
            {
                foreach (string txt in textArr)
                {
                    sw.WriteLine(txt);
                }
            }

            using (StreamReader sr = new StreamReader(filePath1))
            {
                string line = sr.ReadLine();
                while (line != null)
                {
                    Console.WriteLine(line);
                    line = sr.ReadLine();
                }
            }




            Console.ReadKey();
        }




        static void WriteToFile(string filePath, string text)
        {
            using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                //  преобразуем строку в массив байт
                byte[] bytes = Encoding.Default.GetBytes(text);
                //  записываем данные в файл
                fs.Write(bytes, 0, bytes.Length);                 //       (массив, позиция, длина(кол-во символов) )
            }   
        }

        static void ReadFromFile(string filePath, string text)
        {
            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                //  преобразуем строку в массив байт
                byte[] readBytes = new byte[(int)fs.Length];
                //  Считываем данные из файл
                fs.Read(readBytes, 0, readBytes.Length);            //      (массив, позиция, длина(кол-во символов)  )
                // преобразуем байты в сторку
                string readText = Encoding.Default.GetString(readBytes);
                Console.WriteLine(readText);
            }
        }
    }
}
