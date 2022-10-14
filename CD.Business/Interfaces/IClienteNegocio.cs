using CD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CD.Business.Interfaces
{
    public interface IClienteNegocio
    {
        List<Cliente> PesquisarTodos();
        Cliente PesquisarPorId(int id);
        string Incluir(Cliente cliente);
        string Editar(Cliente cliente);
        string Deletar(Cliente cliente);


    }
}
