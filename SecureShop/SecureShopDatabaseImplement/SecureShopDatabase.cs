using SecureShopDatabaseImplement.Models;
using Microsoft.EntityFrameworkCore;

namespace SecureShopDatabaseImplement
{
	public class SecureShopDatabase : DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			if (optionsBuilder.IsConfigured == false)
			{
				optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=NameShopDatabase;Integrated Security=True;MultipleActiveResultSets=True;");
			}
			base.OnConfiguring(optionsBuilder);
		}

		public virtual DbSet<Device> Devices { set; get; }
		public virtual DbSet<Equipment> Equipments { set; get; }
		public virtual DbSet<EquipmentDevice> EquipmentDevices { set; get; }
		public virtual DbSet<Order> Orders { set; get; }
		public virtual DbSet<Client> Clients { set; get; }
	}
}
