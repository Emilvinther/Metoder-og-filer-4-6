using System;
using System.IO;

namespace Metoder_og_filer_4_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CreateFolder();
            CreateFile();
            string contents = ReadFile();
            //Console.WriteLine(contents);
            //DeleteFolder();
            string [] file = Enumration();

            Console.ReadKey();
        }

        public static void CreateFolder()
        {
            Directory.CreateDirectory(@".\Droids");
        }

        public static void CreateFile()
        {
            File.WriteAllText(@".\Droids\R2D2.txt", "beep boop");
        }

        public static string ReadFile()
        {
           string contents = File.ReadAllText(@".\Droids\R2D2.txt");

            return contents;
        }

        public static void DeleteFolder()
        {
            Directory.Delete(@".\Droids", true);
        }

        public static string[] Enumration()
        {
            Directory.CreateDirectory(@".\Droids\Astromech");
            Directory.CreateDirectory(@".\Droids\Protocol");
            File.WriteAllText(@".\Droids\Astromech\R2D2.txt", "beep boop");
            File.WriteAllText(@".\Droids\Protocol\C3P0.txt", "sir!");

            string [] contents = Directory.GetFiles(@".\Droids", "*.txt", SearchOption.AllDirectories);

            foreach (string i in contents)
            {
                Console.WriteLine(i);
            }

            return contents;
        }


    }
}
