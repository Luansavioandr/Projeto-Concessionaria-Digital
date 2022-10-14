using CD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CD.Business.Interfaces
{
    public interface IFuncionarioNegocio
    {
        List<Funcionario> PesquisarTodos();
        Funcionario PesquisarPorId(int id);
        string Incluir(Funcionario funcionario);
        string Editar(Funcionario funcionario);
        string Deletar(Funcionario funcionario);

    }
}
