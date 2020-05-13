using System;
using System.Linq;
using Hotel.Data;
using Hotel.Models;
using Hotel.Services;

namespace Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new AppDbContext())
            {
                ClientService clientService = new ClientService(context);
                RoomService roomService = new RoomService(context);
                SettlementService settlementService = new SettlementService(context);

                clientService.AddClient("abc", "def", 123, "jerk");
                roomService.AddRoom(123, 1, 2, 123);
                settlementService.AddSettlement(23, 25, 1, 1);

                Client client = context.Clients
                    .OrderBy(b => b.Name)
                    .First();

                Room room = context.Rooms
                    .OrderBy(b => b.PersonNumber)
                    .First();

                Settlement settlements = context.Settlements
                    .OrderBy(b => b.SettingDate)
                    .First();

                Console.WriteLine(client.Name);

                context.Remove(client);
                context.Remove(room);
                context.Remove(settlements);

                context.SaveChanges();
            }
        }
    }
}