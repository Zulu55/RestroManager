﻿using System.ComponentModel.DataAnnotations;

namespace Restromanager.Backend.Domain.Entities
{
    public class State
    {
        public int Id { get; set; }

        [Display(Name = "Departamento")]
        [MaxLength(255, ErrorMessage = "El campo {0} no puede tener más de {1} caracteres.")]
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        public string Name { get; set; } = null!;
        public int CountryId { get; set; }
        public Country? Country {get; set;}
        public ICollection<City>? Cities { get; set; }
        [Display(Name = "Ciudades")]
        public int CitiesNumber => Cities == null? 0 : Cities.Count;
    }
}
