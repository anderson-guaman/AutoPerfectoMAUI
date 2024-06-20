using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Microsoft.AspNetCore.Mvc;

namespace ClasesCompartidas.Models
{
    public class Auto
    {
        [Key]
        public int Id { get; set; }

        
        public bool Vendido { get; set; }
        [Required]
        public string Marca { get; set; }
        [Required]
        public string Modelo { get; set; }
        [Required]
        public int AnioFabricacion { get; set; }
        [Required]
        public string Color { get; set; }
        [Required]
        public int KmActual { get; set; }
        [Required]
        public string TipoAuto { get; set; }
        [Required]
        public string Transmision { get; set; }
        [Required]
        public string TipoCombustible { get; set; }
        [Required]
        public float Cilindraje { get; set; }
        [Required]
        public int Potencia { get; set; }
    }
}
