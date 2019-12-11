using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._09_11._12._2019.CSharp.Basics.Db.DAL.Migrations
{
    public class Configuration : DbMigrationsConfiguration<DalDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = typeof(DalDbContext).Name;
        }

        protected override void Seed(DalDbContext context)
        {
            context.Users.AddOrUpdate(x => x.Username, new Models.User { Username = "Admin", Password = "$2y$12$S462VL9ku/gl07vk9rYJwOl06oJYU.5PgJ.XNBuZO5eyWMkTLtCRG", Email = "my@mail.com" });

            base.Seed(context);
        }
    }
}
