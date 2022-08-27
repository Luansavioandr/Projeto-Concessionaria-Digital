using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CD.Models
{
    [Table("Vendas")]
    public class Vendas
    {
        [Key]
        public int Id { get; set; }
        public int EstoqueId { get; set; }
        public int ClienteId { get; set; }
        public int FuncionarioId { get; set; }
        public DateTime DataVenda { get; set; }
        public decimal ValorVenda { get; set; }
        public string FormaPagamento { get; set; }
        public decimal Lucro { get; set; }
    }
}
