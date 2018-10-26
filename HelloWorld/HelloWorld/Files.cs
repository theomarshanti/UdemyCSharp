using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace HelloWorld
{
    class Files
    {
        public void FilesDemo()
        {
            var path = @"c:\somefile.jpg";
            File.Copy(@"c:\temp\myfile.jpg", @"d:\temp\myfile.jpg", true);
            File.Delete(path);
            if (File.Exists(path))
            {

            }
            var content = File.ReadAllText(path);

            var fileInfo = new FileInfo(path);
            fileInfo.CopyTo("...");
            fileInfo.Delete();
            if (fileInfo.Exists)
            {

            }
        }

        public void DirDemo()
        {
            Directory.CreateDirectory(@"c:\temp\folder1");
            Directory.GetFiles(@"c:\projects\CSharpFundamentals", "*.*", SearchOption.AllDirectories);

            var directories = Directory.GetDirectories(@"c:\projects\CSHarpFundamentals", "*",
                SearchOption.AllDirectories);
            foreach (var directory in directories)
            {
                Console.WriteLine(directory);
            }
            Directory.Exists("...");
        }

        public void PathDemo()
        {
            var path = @"C:\projects\CSharpFun\HelloWorld\HelloWorld.sln";

            //Option1 to get extension
            var dotIndex = path.IndexOf('.');
            var extension = path.Substring(dotIndex);
            //Option2
            Console.WriteLine("Extension: " + Path.GetExtension(path));
            //Additionally
            Console.WriteLine("FileName: " + Path.GetFileName(path));
            Console.WriteLine("FileNameWithoutExtension: " + Path.GetFileNameWithoutExtension(path));
        }

        //None of the above directories apply to our case however.
        //We for example would replace them with: C:/Users/Omar Shanti/Desktop/Udemy-dot-net
    }
}
