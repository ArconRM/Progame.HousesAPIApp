using Progame.HousesAPIApp.BLL.Interfaces;
using Progame.HousesAPIApp.Common.Entities;
using Progame.HousesAPIApp.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Progame.HousesAPIApp.BLL
{
    public class OwnerService : IOwnerService
    {

        private readonly IOwnerDAL _ownerDAL;

        public OwnerService(IOwnerDAL ownerDAL)
        {
            _ownerDAL = ownerDAL;
        }
        public void Add(Owner owner)
        {
            _ownerDAL.Add(owner);
        }

        public void Delete(Owner owner)
        {
            _ownerDAL.Delete(owner);
        }

        public IEnumerable<Owner> GetAll()
        {
            return _ownerDAL.GetAll();
        }

        public void Update(Owner owner)
        {
            _ownerDAL.Update(owner);
        }
    }
}
