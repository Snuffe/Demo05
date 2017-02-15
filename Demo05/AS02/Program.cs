using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS02
{
    class Program
    {
        static void Main(string[] args)
        {
            CD cd = new AS02.CD();
            cd.Name = "Endless forms Most Beautiful";
            cd.Artist = "Nightwish";
            cd.AddTrack("Shudder Before the Beautiful", "6:29");
            cd.AddTrack("Weak Fantasy", "5:23");
            cd.AddTrack("Elan", "4:45");
            cd.AddTrack("Yours Is an Empty Hope", "5:34");
            cd.AddTrack("Our Decades in the Sun", "6:37");
            cd.AddTrack("My Walden", "4:38");
            cd.AddTrack("Endless Forms Most Beautiful", "5:07");
            cd.AddTrack("Edema Ruh", "5:15");
            cd.AddTrack("Alpenglow", "4:45");
            cd.AddTrack("The Eyes of Sharbat Gula", "6:03");
            cd.AddTrack("The Greatest Show on Earth", "24:00");
            Console.WriteLine(cd.ToString());
        }
    }
}
