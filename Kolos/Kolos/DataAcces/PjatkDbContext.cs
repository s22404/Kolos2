using Kolos.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kolos.DataAcces
{
    public class PjatkDbContext : DbContext
    {
        public PjatkDbContext()
        {

        }
        public PjatkDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Musician> Musician { get; set; }
        public DbSet<Album> Album { get; set; }
        public DbSet<Track> Track { get; set; }
        public DbSet<MusicLabel> MusicLabel { get; set; }
    }
}
