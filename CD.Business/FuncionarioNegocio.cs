using CD.Business.Contexto;
using CD.Business.Interfaces;
using CD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CD.Business
{
    public class FuncionarioNegocio : IFuncionarioNegocio
    {
        private readonly EFContexto _contexto;
        public FuncionarioNegocio(EFContexto contexto)
        {
            this._contexto = contexto;
        }

        public List<Funcionario> PesquisarTodos()
        {
            return _contexto.Funcionario.ToList();
        }

        public Funcionario PesquisarPorId(int id)
        {
            return _contexto.Funcionario.Find(id);
        }

        public string Incluir(Funcionario funcionario)
        {
            string retorno = "Salvo com sucesso";
            if (string.IsNullOrEmpty(funcionario.Nome))
            {
                retorno = "Informe o nome do funcionario";
            }
            else if (funcionario.Cpf == 0)
            {
                retorno = "Informe o Cpf";
            }

            else
            {
                _contexto.Funcionario.Add(funcionario);
                _contexto.SaveChanges();
            }
            return retorno;
        }

        public string Editar(Funcionario funcionario)
        {
            string retorno = "Salvo com sucesso";
            if (string.IsNullOrEmpty(funcionario.Nome))
            {
                retorno = "Informe o nome do cliente";
            }
            else if (funcionario.Cpf == 0)
            {
                retorno = "Informe o Cpf";
            }

            else
            {
                _contexto.Funcionario.Update(funcionario);
                _contexto.SaveChanges();
            }
            return retorno;
        }

        public string Deletar(Funcionario funcionario)
        {
            _contexto.Funcionario.Remove(funcionario);
            _contexto.SaveChanges();
            return "ok";
        }
    }
}
