using Challenge_Backend_API.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Challenge_Backend_API.Entities
{
    public class Pelicula_o_serie : IEntity
    {
        [Key]
        public int Id { get; set; }
        public string Imagen { get; set; }
        public string Titulo { get; set; }
        public float FechaCreación { get; set; }
        public float Calificación { get; set; }
        public string Historia { get; set; }
        public Personaje Personaje { get; set; }
    }
}
