using System;
using System.Collections.Generic;

namespace UFO_Sightings_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var UFOs = new Dictionary<string, UFO>();
            Sighting longest = new Sighting() { Duration = 0 };
            Sighting shortest = new Sighting() { Duration = 99999 };
            List<string> sightings = Reader.ReadAll();
            for (int i = 0; i < sightings.Count; i++)
            {
                var temp = sightings[i].Split(' ');
                var sighting = new Sighting(temp[2], temp[0], temp[1], new double[] { double.Parse(temp[4]), double.Parse(temp[5]) }, double.Parse(temp[3]));
                
                //If a known UFO
                if (UFOs.ContainsKey(sighting.Name))
                {
                    UFOs[sighting.Name].NewSighting(sighting);
                }
                else
                {
                    UFOs.Add(sighting.Name, new UFO(sighting));
                }

                //If a record-breaking sighting
                if (sighting.Duration >= longest.Duration) { longest = sighting; }
                if (sighting.Duration <= shortest.Duration) { shortest = sighting; }
            }
            Console.Write("Longest sighting:" + longest.ToString());
            Console.Write("Shortest sighting:" + shortest.ToString());
            foreach (UFO ufo in UFOs.Values) { Console.WriteLine(ufo.ToString()); }

            Console.ReadLine();
        }
    }
}
