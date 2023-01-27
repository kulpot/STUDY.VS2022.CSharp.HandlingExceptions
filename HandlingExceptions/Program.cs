/*using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HandlingExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
           string content = File.ReadAllText(@"C:\Users\sunny\Desktop\Lesson22\Example.txt");
            Console.WriteLine(content);
            Console.ReadLine();
           /* try
            {
                string content = File.ReadAllText(@"C:\Lesson22\Example.txt");
                Console.WriteLine(content);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("The file was not found: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
           
        }
    }
}*/