using Progame.HousesAPIApp.BLL.Interfaces;
using Progame.HousesAPIApp.Common.Entities;
using Progame.HousesAPIApp.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Progame.HousesAPIApp.BLL
{
    public class EstateAgentService : IEstateAgentService
    {

        private readonly IEstateAgentDAL _estateAgentDAL;

        public EstateAgentService(IEstateAgentDAL estateAgent)
        {
            _estateAgentDAL = estateAgent;
        }

        public void Add(EstateAgent estateAgent)
        {
            _estateAgentDAL.Add(estateAgent);
        }

        public void Delete(EstateAgent estateAgent)
        {
            _estateAgentDAL.Delete(estateAgent);
        }

        public IEnumerable<EstateAgent> GetAll()
        {
            return _estateAgentDAL.GetAll();
        }

        public void Update(EstateAgent estateAgent)
        {
            _estateAgentDAL.Update(estateAgent);
        }
    }
}
