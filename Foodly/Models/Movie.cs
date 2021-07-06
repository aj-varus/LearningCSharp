
using Microsoft.EntityFrameworkCore;


namespace Foodly.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public bool IsHighRated { get; set; }

        public MembershipType MembershipType { get; set; }

        public byte MembershipTypeId { get; set; }
    }
}
