using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileWatcherTest
{
    class Program
    {
        static void Main(string[] args)
        {
            FileSystemWatcher watcher = new FileSystemWatcher();

            watcher.Path =AppDomain.CurrentDomain.BaseDirectory;

            watcher.NotifyFilter = NotifyFilters.Attributes | NotifyFilters.CreationTime | NotifyFilters.DirectoryName | NotifyFilters.FileName | NotifyFilters.LastAccess | NotifyFilters.LastWrite | NotifyFilters.Security | NotifyFilters.Size;

            watcher.Filter = "*.json";

            watcher.Changed += new FileSystemEventHandler(Watcher_Changed);
            watcher.Created += new FileSystemEventHandler(Watcher_Created);
            watcher.Deleted += new FileSystemEventHandler( Watcher_Deleted);
            watcher.Renamed += new RenamedEventHandler( Watcher_Renamed);

            watcher.EnableRaisingEvents = true;

            while (Console.Read() != 'q') ;
        }

        private static void Watcher_Renamed(object sender, RenamedEventArgs e)
        {
            Console.WriteLine("Renamed");
        }

        private static void Watcher_Deleted(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine("Deleted");
        }

        private static void Watcher_Created(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine("Created");
        }

        private static void Watcher_Changed(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine("Changed");
        }
    }
}
