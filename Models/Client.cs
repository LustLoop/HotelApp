using System.Collections.Generic;

namespace Hotel.Models
{
    public class Client
    {
        public int ClientId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int PassportData { get; set; }
        public string Comment { get; set; }
        public List<Settlement> Settlements { get; set; } 
    }
}