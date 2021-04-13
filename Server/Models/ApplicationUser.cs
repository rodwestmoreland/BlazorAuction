using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace BlazorAuction.Server.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FullName
        {
            get { return _fullName; }
            set { _fullName = LastName + ", " + FirstName; }
        }
        private string _fullName;
        //[Required]
        [MaxLength(50), MinLength(1)]
        public string FirstName { get; set; }
        //[Required]
        [MaxLength(50), MinLength(1)]
        public string LastName { get; set; }
        //[Required]
        //[MaxLength(50), MinLength(2)]
        //public string StreetAddress { get; set; }
        //[Required]
        //[MaxLength(50), MinLength(2)]
        //public string City { get; set; }
        //[Required]
        //[MaxLength(2), MinLength(2)]
        //public string State { get; set; }
        //[Required]
        //[MaxLength(5), MinLength(5)]
        //public string zip { get; set; }

        public bool IsAdmin { get; set; } = false;
    }
}
