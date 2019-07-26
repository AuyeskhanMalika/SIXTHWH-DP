using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CARAPI.Models
{
    public class CARAPIContext : DbContext
    {
        public CARAPIContext (DbContextOptions<CARAPIContext> options)
            : base(options)
        {
        }

        public DbSet<CARAPI.Models.Car> Car { get; set; }
    }
}
