using Challenge_Backend_API.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Challenge_Backend_API.Entities
{
    public class Genero : IEntity
    {
        [Key]
        public int Id { get; set; }
        public string Imagen { get; set; }
        public ICollection<Pelicula_o_serie> Pelicula_o_Serie { get; set; }
    }
}
