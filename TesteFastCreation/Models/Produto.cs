using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TesteFastCreation.Models
{
    public class Produto
    {
        [Key]
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Codigo { get; set; }
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }
    }
}
