using Progame.HousesAPIApp.Common.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Progame.HousesAPIApp.BLL.Interfaces
{
    public interface IOwnerService
    {
        void Add(Owner owner);

        void Delete(Owner owner);

        IEnumerable<Owner> GetAll();

        void Update(Owner owner);
    }
}
