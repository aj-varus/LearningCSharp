using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Foodly.Models
{
    public class MembershipType
    {
        public byte Id { get; set; }
        public string SubscriptionType { get; set; }
        public short SignUpFee { get; set; }

        public byte Discount { get; set; }
    }
}
