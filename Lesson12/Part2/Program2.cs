using System;
using System.IO;
using System.IO.Compression;

namespace Part2
{
    class Program2
    {
        public static void Main()
        {
            List<Part1.Info> infoList = new System.Collections.Generic.List<Part1.Info>();
            string path = "";
            List<string> archiveContents = new List<string>();

            try
            {
                using (StreamReader sr = File.OpenText("D:\\SmartGit\\Homeworks\\Lesson12\\Lesson12Homework.txt"))

                {
                    path = sr.ReadLine();
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Не найден файл: D:\\SmartGit\\Homeworks\\Lesson12\\Lesson12Homework.txt\nЗапустите Program1 и только после этого Program2");
                return;
            }
            
            try
            {
                using (StreamReader sr1 = File.OpenText(path))
                {
                    archiveContents = File.ReadAllLines(path).ToList<string>();
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine($"Не найден файл: {path}\nЗапустите Program1 для создания файла");
                return;
            }
            catch (IOException)
            {
                Console.WriteLine("Файл занят. Закройте файл в проводнике и запустите Program2");
                return;
            }        

            foreach (string n in archiveContents)
                        {
                            var lineInfo = n.Split("\t");
                            infoList.Add(new Part1.Info(lineInfo[0], lineInfo[1], DateTime.Parse(lineInfo[2])));
                        }


                        infoList.Sort(delegate (Part1.Info x, Part1.Info y)
                        {
                            return x.Date.CompareTo(y.Date);
                        });


                        foreach (Part1.Info n in infoList)
                        {
                            n.DisplayInfo();
                        }              
                  
            File.Delete("D:\\SmartGit\\Homeworks\\Lesson12\\Lesson12Homework.txt");
            Console.ReadLine();
        }
    }
}