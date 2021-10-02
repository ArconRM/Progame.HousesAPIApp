using System;
using System.Collections.Generic;
using System.Text;

namespace Progame.HousesAPIApp.Common.Entities
{
    public class EstateAgent : UserDescription
    {
        public IEnumerable<House> Houses { get; set; }

        public int Experience { get; set; }
    }
}
