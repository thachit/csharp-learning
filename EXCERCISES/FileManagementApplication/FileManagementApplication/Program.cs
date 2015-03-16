using System;
using System.IO;

namespace FileManagementApplication
{
    class Program
    {
        public void WritingFile()
        {
            // Create a program to ask the user for several sentences (until they just press Enter) and store them in a text file named "sentences.txt" 
            StreamWriter myFile;
            string path = "sentences.txt";
            

            if (File.Exists(path))
            {
                myFile = File.AppendText(path);
            }
            else
            {
                myFile = File.CreateText(path);
            }

            string sentence = "";
            do
            {
                Console.WriteLine("Input a sentence: ");
                sentence = Convert.ToString(Console.ReadLine());
                if(sentence.Length != 0)
                {
                    myFile.WriteLine(sentence);
                }
            }
            while (sentence.Length != 0);
            myFile.Close();
        }

        public void ReadFile()
        {
            string path = "sentences.txt";
            StreamReader myFile;

            myFile = File.OpenText(path);
            string line = "";
            do
            {
                line = myFile.ReadLine();
                if(line != null)
                {
                    Console.WriteLine(line);
                }
            }
            while (line != null);
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            p.WritingFile();
            Console.WriteLine("=======================");
            p.ReadFile();
            Console.ReadKey();
        }
    }
}
