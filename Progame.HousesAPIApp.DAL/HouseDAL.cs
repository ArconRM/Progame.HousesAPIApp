using Progame.HousesAPIApp.Common.Entities;
using Progame.HousesAPIApp.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Progame.HousesAPIApp.DAL
{
    public class HouseDAL : IHouseDAL
    {
        public void Add(House house)
        {
            using (HousesAPIContext db = new HousesAPIContext())
            {
                db.Houses.Add(house);
                db.SaveChanges();
            }
        }

        public void Delete(House house)
        {
            using (HousesAPIContext db = new HousesAPIContext())
            {
                db.Houses.Remove(house);
                db.SaveChanges();
            }
        }

        public IEnumerable<House> GetAll()
        {
            using (HousesAPIContext db = new HousesAPIContext())
            {
                return db.Houses.ToList();
            }
        }

        public void Update(House house)
        {
            using (HousesAPIContext db = new HousesAPIContext())
            {
                var userToChange = db.Houses.Where(o => o.Id == house.Id).FirstOrDefault();
                db.Houses.Remove(userToChange);
                db.Houses.Add(house);
                db.SaveChanges();
            }
        }
    }
}
