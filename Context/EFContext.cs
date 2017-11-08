using Context.Tables;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Context
{
    public class EFContext : DbContext
    {
        public EFContext() : base("connect")
        { }
        public DbSet<User> user { get; set; }
        public DbSet<InfoBook> info { get; set; }
        public DbSet<librarian> libra { get; set; }
    }
}
