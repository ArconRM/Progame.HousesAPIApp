using Progame.HousesAPIApp.Common.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Progame.HousesAPIApp.BLL.Interfaces
{
    public interface IHouseService
    {
        void Add(House house);

        void Delete(House house);

        IEnumerable<House> GetAll();

        void Update(House house);
    }
}
