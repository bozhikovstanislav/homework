using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace _3DPoints
{
    public static class PathStorage
    {

        public static void SavePathList(List<Points3D> paths)
        {
            string filepath=@"..\..\storage\pathstorage.dat";

            if (!File.Exists(filepath))
            {
                using (StreamWriter wr = File.CreateText(filepath))
                {
                    for (int i = 0; i < paths.Count; i++)
                    {

                        wr.WriteLine(paths[i].ToString());
                    }
                }
            }
            else
            {
               
                    using (StreamWriter wr = File.CreateText(filepath))
                    {
                        for (int i = 0; i < paths.Count; i++)
                        {

                            wr.WriteLine(paths[i].ToString());
                        }
                    }
            }
        }
        public static void loadePathList(string paths)
        {
            try
            {
                string filepath = @"..\..\storage\pathstorage.dat";
                using (StreamReader sr = File.OpenText(filepath))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                }
            }
            catch (Exception)
            {

                throw  new EntryPointNotFoundException();
            }
          

        }
    }
}
