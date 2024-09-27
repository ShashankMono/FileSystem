using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FileSystemReadAndWrite.Models
{
    internal class WriteFile
    {
        //This Class Writes the content in the file same class File is used to make manupulation to the file
        //There is a function in class File called WriteAllText / useing stramWrite for all files which will change the whole content of the file 
        // SO I'm using AppentAllText which will add the new content to the file
        // The construct take Path and Content
        public string Path { get; set; }
        public string NewConstent { get; set; }

        public WriteFile(string path,string content)
        {
            Path = path;
            NewConstent = content + Environment.NewLine;
        }

        public string WriteFileContent()
        {
            if (File.Exists(Path))
            {
                File.AppendAllText(Path,NewConstent);
                return "Text added succesfully";
            }
            return "File doesn't exist";
        }
    }
}
