using Progame.HousesAPIApp.Common.Entities;
using Progame.HousesAPIApp.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Progame.HousesAPIApp.DAL
{
    public class OwnerDAL : IOwnerDAL
    {
        public void Add(Owner owner)
        {
            using(HousesAPIContext db = new HousesAPIContext())
            {
                db.Owners.Add(owner);
                db.SaveChanges();
            }
        }

        public void Delete(Owner owner)
        {
            using (HousesAPIContext db = new HousesAPIContext())
            {
                db.Owners.Remove(owner);
                db.SaveChanges();
            }
        }

        public IEnumerable<Owner> GetAll()
        {
            using (HousesAPIContext db = new HousesAPIContext())
            {
                return db.Owners.ToList();
            }
        }

        public void Update(Owner owner)
        {
            using (HousesAPIContext db = new HousesAPIContext())
            {
                var userToChange = db.Owners.Where(o => o.Id == owner.Id).FirstOrDefault();
                db.Owners.Remove(userToChange);
                db.Owners.Add(owner);
                db.SaveChanges();
            }
        }
    }
}
