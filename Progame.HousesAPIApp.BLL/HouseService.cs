using Progame.HousesAPIApp.BLL.Interfaces;
using Progame.HousesAPIApp.Common.Entities;
using Progame.HousesAPIApp.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Progame.HousesAPIApp.BLL
{
    public class HouseService : IHouseService
    {

        private readonly IHouseDAL _houseDAL;

        public HouseService(IHouseDAL houseDAL)
        {
            _houseDAL = houseDAL;
        }

        public void Add(House house)
        {
            _houseDAL.Add(house);
        }

        public void Delete(House house)
        {
            _houseDAL.Delete(house);
        }

        public IEnumerable<House> GetAll()
        {
            return _houseDAL.GetAll();
        }

        public void Update(House house)
        {
            _houseDAL.Update(house);
        }
    }
}
