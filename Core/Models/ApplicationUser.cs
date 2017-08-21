using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace App.Core.Models
{
  public class ApplicationUser : IdentityUser
  {
    public ApplicationUser() {}

    public ApplicationUser(string userName) 
        : base(userName) {}
  }
}