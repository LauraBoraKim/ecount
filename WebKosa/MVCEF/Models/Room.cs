using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCEF.Models
{
    public class Room
    {
        public int RoomId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Speaker> Speakers { get; set; }
        
    }

    public class Speaker {
        public int SpeakerId { get; set; }
        public string Name { get; set; }
        public int RoomId { get; set; }

        public virtual Room Room { get; set; } 
    }
}