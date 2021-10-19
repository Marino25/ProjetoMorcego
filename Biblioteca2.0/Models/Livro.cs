using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteca2._0.Models
{
    public class Livro
    {
        public Guid Id { get; set; }
        [Required]
        public string Genero { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public int Ano { get; set; }
        [Required]
        public int Valor { get; set; }
        [Required]
        public string LinkImg { get; set; }

        public Livro()
        {
            Id = Guid.NewGuid();
        }
    }
}

  