using Progame.HousesAPIApp.Common.Entities;
using Progame.HousesAPIApp.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Progame.HousesAPIApp.DAL
{
    public class EstateAgentDAL : IEstateAgentDAL
    {
        public void Add(EstateAgent estateAgent)
        {
            using (HousesAPIContext db = new HousesAPIContext())
            {
                db.EstateAgents.Add(estateAgent);
                db.SaveChanges();
            }
        }

        public void Delete(EstateAgent estateAgent)
        {
            using (HousesAPIContext db = new HousesAPIContext())
            {
                db.EstateAgents.Remove(estateAgent);
                db.SaveChanges();
            }
        }

        public IEnumerable<EstateAgent> GetAll()
        {
            using (HousesAPIContext db = new HousesAPIContext())
            {
                return db.EstateAgents.ToList();
            }
        }

        public void Update(EstateAgent estateAgent)
        {
            using (HousesAPIContext db = new HousesAPIContext())
            {
                var userToChange = db.EstateAgents.Where(o => o.Id == estateAgent.Id).FirstOrDefault();
                db.EstateAgents.Remove(userToChange);
                db.EstateAgents.Add(estateAgent);
                db.SaveChanges();
            }
        }
    }
}
