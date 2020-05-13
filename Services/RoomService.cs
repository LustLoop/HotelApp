using System.Collections.Generic;
using System.Linq;
using Hotel.Data;
using Hotel.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace Hotel.Services
{
    public class RoomService
    {
        private AppDbContext context;
        private RoomService roomService;

        public RoomService(AppDbContext context)
        {
            this.context = context;
        }

        public Room AddRoom(int number, int personNumber, int classType, int price)
        {
            Room room = new Room 
            { 
                Number = number,
                PersonNumber = personNumber,
                ClassType = classType,
                Price = price
            };
            context.Rooms.Add(room);
            context.SaveChanges();
            return room;
        }
    }
}