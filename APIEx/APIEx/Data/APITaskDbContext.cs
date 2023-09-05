using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using APIEx.Models;

namespace APIEx.Data
{
    public class APITaskDbContext : DbContext
    {
        public APITaskDbContext (DbContextOptions<APITaskDbContext> options)
            : base(options)
        {
        }

        public DbSet<APIEx.Models.Task> Task { get; set; } = default!;
    }
}
