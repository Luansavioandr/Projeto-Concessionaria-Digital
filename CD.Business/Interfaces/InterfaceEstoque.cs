using CD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CD.Business.Interfaces
{
    public interface IEstoqueNegocio
    {
        List<Estoque> PesquisarTodos();
        Estoque PesquisarPorId(int id);
        string Incluir(Estoque estoque);
        string Editar(Estoque estoque);
        string Deletar(Estoque estoque);
    }
}
