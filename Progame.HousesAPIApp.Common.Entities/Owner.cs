using System;
using System.Collections.Generic;
using System.Text;

namespace Progame.HousesAPIApp.Common.Entities
{
    public class Owner : UserDescription
    {

        public IEnumerable<House> Houses { get; set; }



    }
}
