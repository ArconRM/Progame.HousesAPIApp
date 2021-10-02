using Progame.HousesAPIApp.Common.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Progame.HousesAPIApp.BLL.Interfaces
{
    public interface IBuyerService
    {
        void Add(Buyer buyer);

        void Delete(Buyer buyer);

        IEnumerable<Buyer> GetAll();

        void Update(Buyer buyer);
    }
}
