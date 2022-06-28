using System;
using System.IO;
using System.IO.Compression;

namespace Part1
{
    class Program1
    {
        public static void Main()
        {
            var fileInfo = new List<Info>();
            var directoryInfo = new List<Info>();
            Directory.CreateDirectory("D:\\SmartGit\\Homeworks\\Lesson12\\unzipArchive");

            try
            {
                ZipFile.ExtractToDirectory("D:\\SmartGit\\ArchiveLesson12.zip", "D:\\SmartGit\\Homeworks\\Lesson12\\unzipArchive");
            }
            catch(FileNotFoundException)
            {
                Console.WriteLine("Файл архива не найден по пути: D:\\SmartGit\\ArchiveLesson12.zip", "D:\\SmartGit\\Homeworks\\Lesson12\\unzipArchive");
            }
            catch(InvalidDataException)
            {
                Console.WriteLine("Файл архива был создан с расширением отличным от .zip\tСоздайте архив .zip");
            }

            var fileList = Directory.GetFiles("D:\\SmartGit\\Homeworks\\Lesson12\\unzipArchive");
            var directoryList = Directory.GetDirectories("D:\\SmartGit\\Homeworks\\Lesson12\\unzipArchive");
            var archiveContents = new FileInfo("D:\\SmartGit\\Homeworks\\ArchiveContents.csv");
            using (StreamWriter sw = archiveContents.CreateText())
            {                
                foreach (string d in directoryList)
                {
                    var directory = new DirectoryInfo(d);
                    var name = directory.Name;
                    var date = directory.LastWriteTime;
                    directoryInfo.Add(new Info("Directory", name, date));
                    sw.WriteLine($"Directory\t{name}\t{date}");
                }

                foreach (string f in fileList)
                {                    
                    var file = new FileInfo(f);
                    var name = file.Name;
                    var date = file.LastWriteTime;
                    fileInfo.Add(new Info("File",name,date));
                    sw.WriteLine($"File\t{name}\t{date}");
                }                
            }
            Directory.Delete("D:\\SmartGit\\Homeworks\\Lesson12\\unzipArchive", true);

            using (StreamWriter sw = File.CreateText("D:\\SmartGit\\Homeworks\\Lesson12\\Lesson12Homework.txt"))
            {
                sw.WriteLine(archiveContents.FullName);
            }
            
        }
    }
}

