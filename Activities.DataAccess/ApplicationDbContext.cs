using System;
using Activities.Model;
using Microsoft.EntityFrameworkCore;

namespace DataAccess {
	public class ApplicationDbContext : DbContext {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {
        }

        public DbSet<Activity> Activities { get; set; }
	}
}

