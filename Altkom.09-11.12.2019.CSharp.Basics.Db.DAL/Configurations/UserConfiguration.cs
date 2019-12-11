using Altkom._09_11._12._2019.CSharp.Basics.Db.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._09_11._12._2019.CSharp.Basics.Db.DAL.Configurations
{
    class UserConfiguration : EntityTypeConfiguration<User>
    {
        public UserConfiguration()
        {
            Property(x => x.Username).HasMaxLength(128);
            Property(x => x.Password).HasMaxLength(60).IsRequired();
            Property(x => x.Email).HasMaxLength(254).IsRequired();
        }
    }
}
