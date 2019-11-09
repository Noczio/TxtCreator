using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ExtLibraries
{
    public class Txt_Creator
    {
        string pth, fln;
        public string path { get { return pth; } set { pth = value; } }
        public string file_name { get { return fln; } set { fln = value; } }

        public Txt_Creator()
        {
            path = @"C:\Logs";
            file_name = @"\log.txt";
        }

        public Txt_Creator(string @_path, string @_file_name)
        {
            path = _path;
            file_name = @"\" + _file_name + ".txt";
        }

        ~Txt_Creator()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        public void Create_Hidden_Directory()
        {
            Directory.CreateDirectory(path);
            File.SetAttributes(path, FileAttributes.Hidden);
        }
        public void Create_Directory() { Directory.CreateDirectory(path); }
    }
}
