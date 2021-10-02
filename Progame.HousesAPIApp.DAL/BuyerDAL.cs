using Progame.HousesAPIApp.Common.Entities;
using Progame.HousesAPIApp.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Progame.HousesAPIApp.DAL
{
    public class BuyerDAL : IBuyerDAL
    {
        public void Add(Buyer buyer)
        {
            using (HousesAPIContext db = new HousesAPIContext())
            {
                db.Buyers.Add(buyer);
                db.SaveChanges();
            }
        }

        public void Delete(Buyer buyer)
        {
            using (HousesAPIContext db = new HousesAPIContext())
            {
                db.Buyers.Remove(buyer);
                db.SaveChanges();
            }
        }

        public IEnumerable<Buyer> GetAll()
        {
            using (HousesAPIContext db = new HousesAPIContext())
            {
                return db.Buyers.ToList();
            }
        }

        public void Update(Buyer buyer)
        {
            using (HousesAPIContext db = new HousesAPIContext())
            {
                var userToChange = db.Buyers.Where(o => o.Id == buyer.Id).FirstOrDefault();
                db.Buyers.Remove(userToChange);
                db.Buyers.Add(buyer);
                db.SaveChanges();
            }
        }
    }
}
