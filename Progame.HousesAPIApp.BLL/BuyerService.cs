using Progame.HousesAPIApp.BLL.Interfaces;
using Progame.HousesAPIApp.Common.Entities;
using Progame.HousesAPIApp.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Progame.HousesAPIApp.BLL
{
    public class BuyerService : IBuyerService
    {
        private readonly IBuyerDAL _buyerDAL;

        public BuyerService(IBuyerDAL buyerDAL)
        {
            _buyerDAL = buyerDAL;
        }
        public void Add(Buyer buyer)
        {
            _buyerDAL.Add(buyer);
        }

        public void Delete(Buyer buyer)
        {
            _buyerDAL.Delete(buyer);
        }

        public IEnumerable<Buyer> GetAll()
        {
            return _buyerDAL.GetAll();
        }

        public void Update(Buyer buyer)
        {
            _buyerDAL.Update(buyer);
        }
    }
}
