using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS02
{
    class CD
    {
        public string Name { get; set; }
        public string Artist { get; set; }
        public List<Track> Tracks = new List<Track>();

        public void AddTrack(string name, string length)
        {
            Tracks.Add(new Track { Name = name, Length = length });
        }

        public override string ToString()
        {
            string Songs = "";
            foreach (Track item in Tracks)
            {
                Songs = Songs + item.ToString() + "\n";
            }
            return "- Name:" + Name + "\n- Artist" + Artist + "\n- Songs:\n" + Songs;
        }
    }
}
