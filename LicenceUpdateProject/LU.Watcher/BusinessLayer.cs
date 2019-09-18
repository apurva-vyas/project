using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace LU.BusinessLayer

{
    public class BusinessComponent
    {
        static Dictionary<string,string> G_format = null;
        static string useriName = null;

        public void MonitorDirectory(string path, Dictionary<string,string> dict,string username)

        {
            useriName = username;
            G_format = dict;
            G_format["Owner"] = useriName;
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

        private void FileSystemWatcher_Created(object sender, FileSystemEventArgs e)

        {

            try
            {
                
                
               // G_format["FileName"] = e.Name;
                G_format["Last Modified By"] = useriName;
                G_format["Last Modified Date and Time"] = DateTime.Now.ToString();
                using (var writer = new StreamWriter(e.FullPath))
                { writer.WriteLine("/*");
                    foreach (var i in G_format)
                    {
                        writer.WriteLine(i.Key + ":" + i.Value + "\n");
                    }
                    writer.WriteLine("*/");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void FileSystemWatcher_Renamed(object sender, FileSystemEventArgs e)

        {

            throw new Exception("file renamed");

        }

        private static void FileSystemWatcher_Deleted(object sender, FileSystemEventArgs e)

        {

           throw new Exception("file deleted");

        }
        private static void FileSystemWatcher_Changed(object sender, FileSystemEventArgs e)
        {
            try
            {

                G_format["Last Modified By"] = useriName;
                G_format["Last Modified Date and Time"] = DateTime.Now.ToString();
                string str = "/*";

                foreach (var kv_pair in G_format)
                {
                     str = str + "\n" + kv_pair.Key + ":" + kv_pair.Value;
                }
                str = str + "*/";
                if (File.Exists(e.FullPath))
                {
                    string contents = File.ReadAllText(e.FullPath);

                    int pos1 = contents.IndexOf("/*");
                    int pos2 = contents.IndexOf("*/");
                    contents = contents.Remove(pos1, pos2 + 2);

                    var tempfile = Path.GetTempFileName();
                    using (var writer = new StreamWriter(tempfile))
                    using (var reader = new StreamReader(e.FullPath))
                    {
                        writer.WriteLine(str + contents);
                    }
                    File.Copy(tempfile, e.FullPath, true);
                    File.Delete(tempfile);
                }
                else
                {
                    throw new Exception("file doesn't exist");
                }
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }
        }

    }

}
