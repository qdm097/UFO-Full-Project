using System;
using System.Collections.Generic;
using System.Text;

namespace UFO_Sightings_Console
{
    class UFO
    {

        int Sightings = 0;
        public string Name { get; set; }
        public double[] Location = new double[] { 0, 0 };
        public double Duration = 0;
       
        public void NewSighting(Sighting sighting)
        {
            Sightings++;
            double newRatio = 1d / Sightings;
            double oldRatio = (Sightings - 1d) / Sightings;

            Location[0] = (oldRatio * Location[0]) + (sighting.Location[0] * newRatio);
            Location[1] = (oldRatio * Location[0]) + (sighting.Location[1] * newRatio);
            Duration = (oldRatio * Duration) + (sighting.Duration * newRatio);
        }
        public UFO() { }
        public UFO(Sighting s)
        {
            Name = s.Name;
            Location = s.Location;
            Duration = s.Duration;
        }
        public override string ToString()
        {
            return "Averages for " + Name + "\n\tDuration: " + Math.Round(Duration, 2) + "\n\tLocation: (" + Math.Round(Location[0], 2) + ", " + Math.Round(Location[1], 2) + ")\n";
        }
    }
}
