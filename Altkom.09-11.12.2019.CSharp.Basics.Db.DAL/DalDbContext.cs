using Altkom._09_11._12._2019.CSharp.Basics.Db.DAL.Configurations;
using Altkom._09_11._12._2019.CSharp.Basics.Db.DAL.Migrations;
using Altkom._09_11._12._2019.CSharp.Basics.Db.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._09_11._12._2019.CSharp.Basics.Db.DAL
{
    public class DalDbContext : DbContext
    {
        public DalDbContext() : base("Data Source=(local)\\SQLEXPRESS;Database=CSharpBasics;Integrated Security=true;")
        {
            Configuration.LazyLoadingEnabled = false;

            Database.SetInitializer(new MigrateDatabaseToLatestVersion<DalDbContext, Configuration>(true));
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UserConfiguration());
            modelBuilder.Configurations.Add(new PersonConfiguration());

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<User> Users { get; set; }

    }
}
