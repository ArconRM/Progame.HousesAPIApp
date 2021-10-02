using System;
using System.Collections.Generic;
using System.Text;

namespace Progame.HousesAPIApp.Common.Entities
{
    public enum HouseType
    {
        Flat,
        PrivateHouse
    }

    public class House
    {

      
        public long Id { get; set; }
        public decimal Price { get; set; }

        public double Square { get; set; }

        public IEnumerable<Owner> Owners { get; set; }

        public string Description { get; set; }

        public HouseType HouseType { get; set; }

        public EstateAgent EstateAgent { get; set; }

        public bool IsSoldOut { get; set; }

    }
}
