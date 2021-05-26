using SecureShopDatabaseImplement.Models;
using Microsoft.EntityFrameworkCore;

namespace SecureShopDatabaseImplement
{
	public class SecureShopDatabase : DbContext
	{
		/*public SecureShopDatabase()
		{
			*//*Database.EnsureDeleted();   // удаляем бд со старой схемой
			Database.EnsureCreated();   // создаем бд с новой схемой*//*
			
			using (var context = new SecureShopDatabase())
			{
				context.Clients.RemoveRange(context.Clients);
				context.SaveChanges();
			}
		}*/
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			if (optionsBuilder.IsConfigured == false)
			{
				optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SecureShopDatabase;Integrated Security=True;MultipleActiveResultSets=True;");
			}
			base.OnConfiguring(optionsBuilder);
		}

		public virtual DbSet<Device> Devices { set; get; }
		public virtual DbSet<Equipment> Equipments { set; get; }
		public virtual DbSet<EquipmentDevice> EquipmentDevices { set; get; }
		public virtual DbSet<Order> Orders { set; get; }
		public virtual DbSet<Client> Clients { set; get; }
		public virtual DbSet<Implementer> Implementers { set; get; }
		public virtual DbSet<MessageInfo> Messages { set; get; }
	}
}