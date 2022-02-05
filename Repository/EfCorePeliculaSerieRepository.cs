using Challenge_Backend_API.Data;
using Challenge_Backend_API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Challenge_Backend_API.Repository
{
    public class EfCorePeliculaSerieRepository : EfCoreRepository<Pelicula_o_serie, MovieContext>
    {
        public EfCorePeliculaSerieRepository(MovieContext context) : base(context)
        {

        }
    }
}
