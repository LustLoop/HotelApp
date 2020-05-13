using System.Collections.Generic;
using System.Linq;
using Hotel.Data;
using Hotel.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace Hotel.Services
{
    public class ClientService
    {
        private AppDbContext context;
        private ClientService clientService;

        public ClientService(AppDbContext context)
        {
            this.context = context;
        }

        public Client AddClient(string name, string surname, int passportData, string comment)
        {
            Client client = new Client 
            { 
                Name = name,
                Surname = surname,
                PassportData = passportData,
                Comment = comment
            };
            context.Clients.Add(client);
            context.SaveChanges();
            return client;
        }
        
    }
}