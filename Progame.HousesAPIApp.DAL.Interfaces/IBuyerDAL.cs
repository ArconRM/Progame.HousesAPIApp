using Progame.HousesAPIApp.Common.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Progame.HousesAPIApp.DAL.Interfaces
{
    public interface IBuyerDAL
    {
        void Add(Buyer buyer);

        void Delete(Buyer buyer);

        IEnumerable<Buyer> GetAll();

        void Update(Buyer buyer);
    }
}
