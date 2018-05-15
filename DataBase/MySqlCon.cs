using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.Entity;
using BussinesEnitites;
using System.Data.Entity;
namespace DataBase
{

    public class MySqlCon : DbContext
    {
        public MySqlCon() : base(nameOrConnectionString: "myConnectionString") { }


        public DbSet<CatMasters> CategoriesMasters { get; set; }
        public DbSet<MenuItems> MenuItems { get; set; }
        //public DbSet<User> Users { get; set; }
       
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<CatMasters>().ToTable("CategoriesMasters").HasKey(C => C.CatId);
            modelBuilder.Entity<MenuItems>().ToTable("MenuItems").HasKey(m => m.ItemId);
           // modelBuilder.Entity<User>().ToTable("Users").HasKey(u => u.UserId);

        }

    }
}