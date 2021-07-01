using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class FileFactory
    {
        public static IFile GetFile()
        {
            if (true)
            {
                return new LocalFile();
            }
            else
            {
                return new AzureFile();
            }
        }
    }
}
