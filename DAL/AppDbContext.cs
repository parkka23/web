using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DAL
{
    internal class AppDbContext : DbContext
    {
        public AppDbContext() : base()
        {

        }

        public DbSet<Student> Students;
         
    }
}
