using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystemReadAndWrite.Models
{
    internal class ReadFile
    {
        //This class takes the path of the file in the constructor and stores in path Property
        //The File class Have a function called ReadAllText which reads every type of content 
        // and returns the content in the form of string
        public string Path {  get; set; }

        public ReadFile(string path) { 
            Path = path;
        }

        public string ReadFileContent()
        {
            if (File.Exists(Path))
            {
                string readContent = File.ReadAllText(Path);
                return readContent;
            }
            return "File doesn't exist";
        }
    }
}
