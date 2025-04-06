using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;


namespace Mammooth.Data.Entities
{
    public class User : IdentityUser
    {
        public required string FirstName { get; set; }
        public required string LastName { get; set; }

        [StringLength(10)]
        public required string CitizenId { get; set; }
        public ICollection<RentalRequest> RentalRequests { get; set; }
    }
}