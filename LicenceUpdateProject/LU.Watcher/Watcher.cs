using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LU.Watcher
{
    public class Watcher
    {
        public static void MonitorDirectory(string path)

        {

            FileSystemWatcher fileSystemWatcher = new FileSystemWatcher();

            fileSystemWatcher.Path = path;

            fileSystemWatcher.Created += FileSystemWatcher_Created;

            fileSystemWatcher.Renamed += FileSystemWatcher_Renamed;

            fileSystemWatcher.Deleted += FileSystemWatcher_Deleted;

            fileSystemWatcher.Changed += FileSystemWatcher_Changed;

            fileSystemWatcher.EnableRaisingEvents = true;
            // Watch both files and subdirectories.
            fileSystemWatcher.IncludeSubdirectories = true;

            fileSystemWatcher.NotifyFilter =
            NotifyFilters.Attributes |
            NotifyFilters.CreationTime |
            NotifyFilters.DirectoryName |
            NotifyFilters.FileName |
            NotifyFilters.LastAccess |
            NotifyFilters.LastWrite |
            NotifyFilters.Security |
            NotifyFilters.Size;

        }

        private static void FileSystemWatcher_Created(object sender, FileSystemEventArgs e)

        {
            Console.WriteLine("File created: {0}", e.Name);
            //string str = "/*\n @Company Name:Siemens Technology Services Ltd \n //@Version: \n //@Author: \n //@Date Created:" + DateTime.Now + " \n //@Date Modified:" + File.SetLastWriteTime(e.FullPath) +"\n */";

            string str = "/*\n @Company Name:Siemens Technology Services Ltd \n //@Version: \n //@Author: \n //@Date Created:" + DateTime.Now + " \n //@Date Modified:\n */";
            var tempfile = Path.GetTempFileName();
            using (var writer = new StreamWriter(tempfile))
            using (var reader = new StreamReader(e.FullPath))
            {
                Console.WriteLine("Inside Create File");
                writer.WriteLine(str);
                while (!reader.EndOfStream)
                    writer.WriteLine(reader.ReadLine());
            }
            File.Copy(tempfile, e.FullPath, true);
            File.Delete(tempfile);
        }

        private static void FileSystemWatcher_Renamed(object sender, FileSystemEventArgs e)

        {

            Console.WriteLine("File renamed: {0}", e.Name);

        }

        private static void FileSystemWatcher_Deleted(object sender, FileSystemEventArgs e)

        {

            Console.WriteLine("File deleted: {0}", e.Name);

        }
        private static void FileSystemWatcher_Changed(object sender, FileSystemEventArgs e)
        {

            Console.WriteLine($"File changed: \n " + e.FullPath + "\n " + e.ChangeType + "\n" + e.Name);
            string str = "/*\n @Company Name:Siemens Technology Services Ltd \n //@Version: \n //@Author: \n //@Date Modified:" + DateTime.Now + " \n */";
            if (File.Exists(e.FullPath))
            {
                string contents = File.ReadAllText(e.FullPath);
                DateTime dt1 = File.GetCreationTime(e.FullPath);
                Console.WriteLine("The last create time for this file was" + dt1);
                DateTime dt2 = File.GetLastAccessTime(e.FullPath);
                Console.WriteLine("The last access time for this file was" + dt2);
                DateTime dt3 = File.GetLastWriteTime(e.FullPath);
                Console.WriteLine("The last write time for this file was" + dt3);



                if (contents.Contains("@Company") && contents.Contains("@Version")
                    && contents.Contains("@Author") && contents.Contains("@Date Modified"))
                {
                    Console.WriteLine("File exist");
                    // contents = contents.Replace("Technology", "tecf");
                    // System.IO.File.WriteAllText(e.FullPath, contents);//write text to file
                    //StreamReader file = new StreamReader(e.FullPath);
                    //String line;

                    //while ((line = file.ReadLine()) != null)
                    //{
                    //    if (line.Contains("//@Date Modified:"))
                    //    {
                    //        Console.WriteLine(line);
                    //        line.Replace("Date", "Time");
                    //        File.WriteAllLines(e.FullPath, line);
                    //        Console.WriteLine(line);
                    //        break;


                    //    }
                    //}

                    /*  File.SetLastWriteTime(e.FullPath, new DateTime) */

                }
                else
                {
                    Console.WriteLine("File exist but no header");
                    var tempfile = Path.GetTempFileName();
                    using (var writer = new StreamWriter(tempfile))
                    using (var reader = new StreamReader(e.FullPath))
                    {
                        Console.WriteLine("Inside update File");
                        writer.WriteLine(str);
                        while (!reader.EndOfStream)
                            writer.WriteLine(reader.ReadLine());
                    }
                    File.Copy(tempfile, e.FullPath, true);
                    File.Delete(tempfile);
                }

            }
            else
            {
                Console.WriteLine("File doesnot exist");
            }


        }

    }
}
