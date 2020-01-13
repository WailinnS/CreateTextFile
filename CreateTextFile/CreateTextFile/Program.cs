using System;
using System.IO;
namespace CreateTextFile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Create a file name.");
            string fileName = Console.ReadLine();

            string path = @$"\\GMRDC1\Folder Redirection\wailinn.saw\Desktop\{fileName}.txt";



            Console.WriteLine("Student name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Student GPA: ");
            float gpa = float.Parse(Console.ReadLine());
            Console.WriteLine("Current Grade: ");
            string grade = Console.ReadLine();


            if (File.Exists(path))
            {
                File.Delete(path);
            }
            try
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    //create a file to write to.
                    sw.WriteLine($"File Created: {DateTime.Now.ToString()}");
                    sw.WriteLine($"Name: {name}");
                    sw.WriteLine($"GPA: {gpa}");
                    sw.WriteLine($"Curent Grade: {grade}");

                }
                Console.WriteLine("File is created.");
            }  
            catch(Exception Ex)
            {
                Console.WriteLine("Error when creating file.");
                Console.WriteLine($"Error Code: {Ex.ToString()}");
            }

            Console.WriteLine("done");
            Console.Read();

            
        }
    }
}
