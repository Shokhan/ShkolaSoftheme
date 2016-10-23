using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Concrete
{
    public class EFDBContext : DbContext
    {
        public DbSet<Spare> Spares { get; set; }
    }
}
