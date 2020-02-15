using System;
using System.IO;

namespace working_files
{
    class Program
    {
        static void Main(string[] args)
        {
            if (File.Exists("settings/mytextfile.txt")) ;
            
                
            
            FileInfo info = new FileInfo("settings/mytextfile.txt");
            Console.WriteLine(info.Directory);
            Console.WriteLine(info.Extension);
            Console.WriteLine(info.IsReadOnly);
            Console.WriteLine(info.LastAccessTimeUtc);
            Console.WriteLine(info.LastWriteTime);
            Console.WriteLine(info.Length);

             

    
        
        









        }
    }
}
