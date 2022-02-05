using Challenge_Backend_API.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Challenge_Backend_API.Data
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options)
        : base(options)
        {

        }

        public DbSet<Personaje> Personaje { get; set; }
        public DbSet<Pelicula_o_serie> Pelicula_o_serie { get; set; }
        public DbSet<Genero> Genero { get; set; }
        public DbSet<User> User { get; set; }

    }
}
