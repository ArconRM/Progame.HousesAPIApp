using Progame.HousesAPIApp.Common.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Progame.HousesAPIApp.DAL.Interfaces
{
    public interface IHouseDAL
    {
        void Add(House house);

        void Delete(House house);

        IEnumerable<House> GetAll();

        void Update(House house);
    }
}
