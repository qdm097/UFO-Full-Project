using System;
using System.Collections.Generic;
using System.Text;

namespace UFO_Sightings_Console
{
    class Sighting
    {
        public string Date { get; set; }
        public string Time { get; set; }
        public string Name { get; set; }
        public double[] Location { get; set; }
        public double Duration { get; set; }
        public Sighting() { }
        public Sighting(string name, string date, string time, double[] location, double duration)
        {
            Name = name; Date = date; Time = time; Location = location; Duration = duration;
        }
        public override string ToString()
        {
            return "\n\tWhen: " + Date + " " + Time + "\n\tShape:" + Name + "\n\tWhere: (" + Math.Round(Location[0], 2) + ", " + Math.Round(Location[1], 2) + ")\n\n";
        }
    }
}
