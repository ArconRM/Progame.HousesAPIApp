using Progame.HousesAPIApp.Common.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Progame.HousesAPIApp.BLL.Interfaces
{
    public interface IEstateAgentService
    {
        void Add(EstateAgent estateAgent);

        void Delete(EstateAgent estateAgent);

        IEnumerable<EstateAgent> GetAll();

        void Update(EstateAgent estateAgent);
    }
}
