using System;
using System.Collections.Generic;
using System.Text;

namespace Progame.HousesAPIApp.Common.Entities
{
    
    public class UserDescription
    {
        public long Id { get; set; }

        public string FullName { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public int Age { get; set; }
    }
}
