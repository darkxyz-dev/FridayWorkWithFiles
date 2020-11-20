using System;
using System.IO;

namespace FridayWorkWithFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What file you would like to move fruit folder?");
            string UserInput = Console.ReadLine();
            MoveFileFruits(UserInput);
            Console.WriteLine("What file you would like to move vegetables folder?");
            string userInput = Console.ReadLine();
            MoveFileVegetables(userInput);
            FileDelete();
        }



        public static void MoveFileFruits(string fileName)
        {
            string sourceDirectory = @"C:\Users\opilane\samples\LOGITpe20-Week12-WorkingWithFiles-Task";
            string destinationPath = @"C:\Users\opilane\samples\LOGITpe20-Week12-WorkingWithFiles-Task\fruit";
            File.Move(Path.Combine(sourceDirectory, fileName), Path.Combine(destinationPath, fileName));
        }
        public static void MoveFileVegetables(string fileName)
        {
            string sourceDirectory = @"C:\Users\opilane\samples\LOGITpe20-Week12-WorkingWithFiles-Task";
            string destinationPath = @"C:\Users\opilane\samples\LOGITpe20-Week12-WorkingWithFiles-Task\vegetables";
            File.Move(Path.Combine(sourceDirectory, fileName), Path.Combine(destinationPath, fileName));


        }
        public static void FileDelete()
        {
            string rootPath = @"C:\Users\opilane\samples\LOGITpe20-Week12-WorkingWithFiles-Task\fruit";
            string fileName = "toiletPaper.txt";


            if (File.Exists(Path.Combine(rootPath, fileName)))
            {
                File.Delete(Path.Combine(rootPath, fileName));
                Console.WriteLine("File deleted.");
            }
            else
            {
                Console.WriteLine("File not found");
            }
            string rootPath2 = @"C:\Users\opilane\samples\LOGITpe20-Week12-WorkingWithFiles-Task\vegetables";
            string fileName2 = "cheese.txt";


            if (File.Exists(Path.Combine(rootPath2, fileName2)))
            {
                File.Delete(Path.Combine(rootPath2, fileName2));
                Console.WriteLine("File deleted.");
            }
            else
            {
                Console.WriteLine("File not found");
            }
        }
    }
}
