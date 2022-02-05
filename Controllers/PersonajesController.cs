using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Challenge_Backend_API.Data;
using Challenge_Backend_API.Entities;
using Challenge_Backend_API.Repository;

namespace Challenge_Backend_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonajesController : MovieContextController<Genero, EfCoreGeneroRepository>
    {
        public PersonajesController(EfCoreGeneroRepository repository) : base(repository)
        {

        }
    }

}
