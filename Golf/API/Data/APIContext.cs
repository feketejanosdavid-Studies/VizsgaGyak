using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using API.Models;

namespace API.Data
{
    public class APIContext : DbContext
    {
        public APIContext (DbContextOptions<APIContext> options)
            : base(options)
        {
        }

        public APIContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=APIContext-062ff31e-6b0c-4538-886e-e4860a1b8a07;Trusted_Connection=True;MultipleActiveResultSets=true");
        }

        public DbSet<API.Models.Result> Result { get; set; } = default!;
        public DbSet<API.Models.Player> Player { get; set; } = default!;
    }
}
