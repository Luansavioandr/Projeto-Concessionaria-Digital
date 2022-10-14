using CD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CD.Business.Interfaces
{
    public interface IVendasNegocio
    {
        List<Vendas> PesquisarTodosFiltrado(Vendas filtro);
        Vendas PesquisarPorId(int id);
        string Incluir(Vendas vendas);
        string Editar(Vendas vendas);
        string Deletar(Vendas vendas);

    }
}
