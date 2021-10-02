//using Microsoft.EntityFrameworkCore;
using Progame.HousesAPIApp.Common.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace Progame.HousesAPIApp.DAL
{
     public class HousesAPIContext: DbContext
    {
         public HousesAPIContext():base("Data Source=DESKTOP-VI9VTAG;Initial Catalog=HouseApiDatabase;Integrated Security=True")
	    {
            
	    }

        public DbSet<House> Houses { get; set; }

        public DbSet<Buyer> Buyers { get; set; }

        public DbSet<Owner> Owners { get; set; }

        public DbSet<EstateAgent> EstateAgents { get; set; }
    }
}
