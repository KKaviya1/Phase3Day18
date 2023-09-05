using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MoviesAPI.Models;

namespace MoviesAPI.Data
{
    public class MoviesAssDbContext : DbContext
    {
        public MoviesAssDbContext (DbContextOptions<MoviesAssDbContext> options)
            : base(options)
        {
        }

        public DbSet<MoviesAPI.Models.Movie> Movie { get; set; } = default!;
    }
}
