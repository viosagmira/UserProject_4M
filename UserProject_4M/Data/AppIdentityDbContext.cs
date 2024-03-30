using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using UserProject_4M.Models;

namespace UserProject_4M.Data
{
	public class AppIdentityDbContext : IdentityDbContext<AppUser>
	{
        public AppIdentityDbContext(DbContextOptions<AppIdentityDbContext> options) :
            base(options)
        { }
    }
}

