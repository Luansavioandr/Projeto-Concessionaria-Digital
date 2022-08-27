using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CD.Models
{
    [Table("Estoque")]
    public class Estoque
    {
        [Key]
        public int Id { get; set; }
        public DateTime DataEntrada { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Cor { get; set; }
        public string Ano { get; set; }
        public string Placa { get; set; }
        public string Cambio { get; set; }
        public decimal ValorEntrada { get; set; }
        public bool Vendido { get; set; }

    }
}
