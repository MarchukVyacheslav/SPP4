using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace TestsGenerator
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string FolderPath = "E:\\Documents\\University\\Марчук 951004\\3 курс\\5 семестр\\СПП\\Лабораторные работы\\SPP4\\res";

            List<string> FilesPath = new List<string>() 
            {
                "E:\\Documents\\University\\Марчук 951004\\3 курс\\5 семестр\\СПП\\Лабораторные работы\\SPP3\\AssemblyBrowser\\AssemblyBrowserLib\\AssemblyBrowser.cs"
            };

            Pipeline p = new Pipeline(new PipelineConfiguration(1, 1, 1));
            await p.Execute(FilesPath, FolderPath);
        }
    }
}
