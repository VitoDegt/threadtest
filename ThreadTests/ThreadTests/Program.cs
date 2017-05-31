using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ThreadTests
{
    

    class FileWatcher
    {


        private string _path;
        private string source;
        private bool isOperation = true;

        public FileWatcher(string path)
        {
            path = _path;
        }
        public void CheckFile(string path)
        {
            if (isOperation)
            {
                File.GetLastWriteTime(_path); 
            }
        }


    }


    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
