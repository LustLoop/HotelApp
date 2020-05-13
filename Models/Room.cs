using System.Collections.Generic;

namespace Hotel.Models
{
    public class Room
    {
        public int RoomId { get; set; }
        public int Number { get; set; }
        public int PersonNumber { get; set; }
        public int ClassType { get; set; }
        public int Price { get; set; }

        public List<Settlement> Settlements { get; set; } 
    }
}