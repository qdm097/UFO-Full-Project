using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace UFO_Sightings_Console
{
    static class Reader
    {
        private static string filepath = Directory.GetCurrentDirectory() + "\\Dataset.txt";
        public static List<string> ReadAll()
        {
            //I love this clean data, no verification needed!
            using (StreamReader sr = new StreamReader(new FileStream(filepath, FileMode.Open)))
            {
                var all = new List<string>();
                var length = int.Parse(sr.ReadLine());
                for (int i = 0; i < length; i++)
                {
                    all.Add(sr.ReadLine());
                }
                return all;
            }
        }
    }
}
