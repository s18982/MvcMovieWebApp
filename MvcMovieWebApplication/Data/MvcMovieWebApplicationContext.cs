using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcMovieWebApplication.Models;

namespace MvcMovieWebApplication.Data
{
    public class MvcMovieWebApplicationContext : DbContext
    {
        public MvcMovieWebApplicationContext (DbContextOptions<MvcMovieWebApplicationContext> options)
            : base(options)
        {
        }

        public DbSet<MvcMovieWebApplication.Models.Movie> Movie { get; set; }
    }
}
