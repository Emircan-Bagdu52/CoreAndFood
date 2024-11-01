using Microsoft.EntityFrameworkCore;

namespace CoreAndFood.Data.Models
{
	public class Context : DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("server=DESKTOP-UOIJ6R2\\SQLEXPRESSS;database=DbCoreFoodd; integrated security=true");
		}
		public DbSet<Food> Foods { get; set; }
		public DbSet<Category> Categories { get; set; }
	}
}
