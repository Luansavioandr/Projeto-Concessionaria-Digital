using CD.Business.Contexto;
using CD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CD.Business
{
    public class ClienteNegocio
    {
        private readonly EFContexto _contexto;
        public ClienteNegocio(EFContexto contexto)
        {
            this._contexto = contexto;
        }

        public List<Cliente> PesquisarTodos()
        {
            return _contexto.Cliente.ToList();
        }

        public Cliente PesquisarPorId(int id)
        {
            return _contexto.Cliente.Find(id);
        }

        public string Incluir(Cliente cliente)
        {
            string retorno = "Salvo com sucesso";
            if (string.IsNullOrEmpty(cliente.Nome))
            {
                retorno = "Informe o nome do cliente";
            }
            else if (cliente.Cpf == 0)
            {
                retorno = "Informe o Cpf";
            }
            
            else
            {
                _contexto.Cliente.Add(cliente);
                _contexto.SaveChanges();
            }
            return retorno;
        }

        public string Editar(Cliente cliente)
        {
            string retorno = "Salvo com sucesso";
            if (string.IsNullOrEmpty(cliente.Nome))
            {
                retorno = "Informe o nome do cliente";
            }
            else if (cliente.Cpf == 0)
            {
                retorno = "Informe o Cpf";
            }

            else
            {
                _contexto.Cliente.Update(cliente);
                _contexto.SaveChanges();
            }
            return retorno;
        }

        public string Deletar(Cliente cliente)
        {
            _contexto.Cliente.Remove(cliente);
            _contexto.SaveChanges();
            return "ok";
        }
    }
}
