using System;
using System.IO;
using System.Security;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace catalogs
{

    public class Program

    {

        public static void Main(string[] args)
        {   //path to catalog
            String catalog = "c:\\";

            //object class DirectoryInfo 
            DirectoryInfo di;

            try
            {
                //initialization witch parameter
                //parameter is catalog's path
                di = new DirectoryInfo(catalog);
            }
            catch (Exception)
            {
                //there can be case, when catalog in this path doesn't exist
                Console.WriteLine("Error");
                //we need return to escape from exception
                return;
            }

            //new array of FileSystemInfo type to get all files in catalog
            //to load files infos to array we need methon called GetFileSystemInfos() from DirectoryInfo class
            FileSystemInfo[] fsi = di.GetFileSystemInfos();


            //foreach loop to show all files in array
            foreach (FileSystemInfo f in fsi)
            {
                //property Name of FileSystemInfo class show a names of files
                Console.WriteLine(f.Name);
            }



            Console.ReadKey();
        }

    }
}

