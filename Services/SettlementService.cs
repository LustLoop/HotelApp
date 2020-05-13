using System.Collections.Generic;
using System.Linq;
using Hotel.Data;
using Hotel.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace Hotel.Services
{
    public class SettlementService
    {
        private AppDbContext context;
        private SettlementService settlementService;

        public SettlementService(AppDbContext context)
        {
            this.context = context;
        }

        public Settlement AddSettlement(int leavingDate, int settingDate, int roomId, int clientId)
        {
            Settlement settlement = new Settlement 
            { 
                LeavingDate = leavingDate,
                SettingDate = settingDate,
                RoomId = roomId,
                ClientId = clientId,
                Room = context.Rooms
                    .Where(r => r.RoomId == roomId) 
                    .FirstOrDefault(),
                Client = context.Clients
                    .Where(c => c.ClientId == clientId) 
                    .FirstOrDefault(),
            };
            context.Settlements.Add(settlement);
            context.SaveChanges();
            return settlement;
        }
    }
}