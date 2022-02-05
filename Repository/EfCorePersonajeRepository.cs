using Challenge_Backend_API.Data;
using Challenge_Backend_API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Challenge_Backend_API.Repository
{
    public class EfCorePersonajeRepository : EfCoreRepository<Personaje, MovieContext>
    {
        public EfCorePersonajeRepository(MovieContext context) : base(context)
        {

        }
    }
}
