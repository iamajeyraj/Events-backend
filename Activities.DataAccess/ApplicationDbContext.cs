using System;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using Model;

namespace DataAccess {
	public class ApplicationDbContext : DbContext {
		public DbSet<Activity> Activities { get; set; }
	}
}

