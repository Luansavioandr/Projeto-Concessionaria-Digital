using CD.Business.Contexto;
using CD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CD.Business
{
    public class EstoqueNegocio
    {
        private readonly EFContexto _contexto;
        public EstoqueNegocio(EFContexto contexto)
        {
            this._contexto = contexto;
        }
        
        public List<Estoque> PesquisarTodos()
        {
            return _contexto.Estoque.ToList();
        }

        public Estoque PesquisarPorId(int id)
        {
            return _contexto.Estoque.Find(id);
        }

        public string Incluir(Estoque estoque)
        {
            string retorno = "Salvo com sucesso";
            if (string.IsNullOrEmpty(estoque.Marca))
            {
                retorno = "Informe a Marca";
            }
            else if (string.IsNullOrEmpty(estoque.Modelo))
            {
                retorno = "Informe o Modelo";
            }
            else if (string.IsNullOrEmpty(estoque.Cor))
            {
                retorno = "Informe a Cor";
            }
            else if (string.IsNullOrEmpty(estoque.Ano))
            {
                retorno = "Informe o Ano";
            }
            else if (string.IsNullOrEmpty(estoque.Placa))
            {
                retorno = "Informe a Placa";
            }
            else if (string.IsNullOrEmpty(estoque.Cambio))
            {
                retorno = "Informe o Cambio";
            }
            else
            {
                _contexto.Estoque.Add(estoque);
                _contexto.SaveChanges();
            }
            return retorno;
        }

        public string Editar(Estoque estoque)
        {
            string retorno = "Salvo com sucesso";
            if (string.IsNullOrEmpty(estoque.Marca))
            {
                retorno = "Informe a Marca";
            }
            else if (string.IsNullOrEmpty(estoque.Modelo))
            {
                retorno = "Informe o Modelo";
            }
            else if (string.IsNullOrEmpty(estoque.Cor))
            {
                retorno = "Informe a Cor";
            }
            else if (string.IsNullOrEmpty(estoque.Ano))
            {
                retorno = "Informe o Ano";
            }
            else if (string.IsNullOrEmpty(estoque.Placa))
            {
                retorno = "Informe a Placa";
            }
            else if (string.IsNullOrEmpty(estoque.Cambio))
            {
                retorno = "Informe o Cambio";
            }
            else
            {
                _contexto.Estoque.Update(estoque);
                _contexto.SaveChanges();
            }
            return retorno;
        }

        public string Deletar(Estoque estoque)
        {
            _contexto.Estoque.Remove(estoque);
            _contexto.SaveChanges();
            return "ok";
        }
    }
}
