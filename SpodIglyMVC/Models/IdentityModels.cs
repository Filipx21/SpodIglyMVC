using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace SpodIglyMVC.Models
{
    public class ApplicationUser : IdentityUser
    {
        public virtual ICollection<Order> Orders { get; set; }

        public UserData UserData { get; set; }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            return userIdentity;
        }
    }
}