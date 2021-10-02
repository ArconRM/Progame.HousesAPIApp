using Progame.HousesAPIApp.Common.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Progame.HousesAPIApp.DAL.Interfaces
{
    public interface IEstateAgentDAL
    {
        void Add(EstateAgent estateAgent);

        void Delete(EstateAgent estateAgent);

        IEnumerable<EstateAgent> GetAll();

        void Update(EstateAgent estateAgent);
    }
}
