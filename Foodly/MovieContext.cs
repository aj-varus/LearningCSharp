using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Foodly.Models;
using Microsoft.EntityFrameworkCore;

namespace Foodly
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options) : base(options)
        {
        }

        public virtual DbSet<Movie> Movie { get; set; }
    }
}
