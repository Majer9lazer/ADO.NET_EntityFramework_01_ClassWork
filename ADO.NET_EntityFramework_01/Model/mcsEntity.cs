using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET_EntityFramework_01.Model
{
    public class mcsEntity : DbContext
    {
        public mcsEntity() : base("name = DefaultConnection")
        {

        }
        public DbSet<User> Users { get; set; }
    }
}
