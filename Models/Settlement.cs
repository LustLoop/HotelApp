using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Hotel.Models
{
    public class Settlement
    {
        public int SettlementId { get; set; }
        public int LeavingDate { get; set; }
        public int SettingDate { get; set; }
        
        public int RoomId { get; set; }
        public Room Room { get; set; }

        public int ClientId { get; set; }
        public Client Client { get; set; }
    }
}