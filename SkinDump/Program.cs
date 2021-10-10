using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SkinDump
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\.minecraft\assets\skins";
            if (args.Length != 0)
            {
                path = args[0] + @"\assets\skins";
            }
            Directory.CreateDirectory(@"\skins");
            foreach (string dirPath in Directory.GetDirectories(path))
            {
                foreach (string skin in Directory.GetFiles(dirPath))
                {
                    try
                    {
                        File.Copy(skin, @"\skins\" + Path.GetFileName(skin) + ".png");
                    }
                    catch (Exception)
                    {

                    }
                }
            }
            System.Diagnostics.Process.Start(@"\skins");
        }
    }
}
