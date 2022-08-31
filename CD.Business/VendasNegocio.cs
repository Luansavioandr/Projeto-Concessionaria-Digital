using CD.Business.Contexto;
using CD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CD.Business
{
    public class VendasNegocio
    {
        private readonly EFContexto _contexto;
        public VendasNegocio(EFContexto contexto)
        {
            this._contexto = contexto;
        }

        public List<Vendas> PesquisarTodosFiltrado(Vendas filtro)
        {
            IQueryable<Vendas> query = _contexto.Vendas;
            if (filtro == null)
            {
                return query.ToList();
            }
            if (filtro.EstoqueId > 0)
            {
                query = query.Where(x => x.EstoqueId == filtro.EstoqueId);
            }
            if (filtro.ClienteId > 0)
            {
                query = query.Where(x => x.ClienteId == filtro.ClienteId);
            }
            if (filtro.FuncionarioId > 0)
            {
                query = query.Where(x => x.FuncionarioId == filtro.FuncionarioId);
            }
            if (!string.IsNullOrEmpty(filtro.FormaPagamento))
            {
                query = query.Where(x => x.FormaPagamento == filtro.FormaPagamento);
            }
            if (filtro.DataVenda != default(DateTime))
            {
                query = query.Where(x => filtro.DataVenda >= x.DataVenda);
            }

            return query.ToList();
        }

        public Vendas PesquisarPorId(int id)
        {
            return _contexto.Vendas.Find(id);
        }

        public string Incluir(Vendas vendas)
        {
            string resultado = "Salvo com sucesso";
            if (string.IsNullOrEmpty(vendas.FormaPagamento))
            {
                resultado = "Informar a Forma de pagamento";
            }
            else if (vendas.EstoqueId == 0)
            {
                resultado = "Informar o Estoque";
            }
            else if (vendas.ClienteId == 0)
            {
                resultado = "Informar o Cliente";
            }
            else if (vendas.FuncionarioId == 0)
            {
                resultado = "Informar o Funcionario";
            }
            else if (vendas.ValorVenda == 0)
            {
                resultado = "Informar o Funcionario";
            }
            else
            {
                _contexto.Vendas.Add(vendas);
                _contexto.SaveChanges();
            }
            return resultado;
        }

        public string Editar(Vendas vendas)
        {
            string resultado = "Salvo com sucesso";
            if (string.IsNullOrEmpty(vendas.FormaPagamento))
            {
                resultado = "Informar a Forma de pagamento";
            }
            else if (vendas.EstoqueId == 0)
            {
                resultado = "Informar o Estoque";
            }
            else if (vendas.ClienteId == 0)
            {
                resultado = "Informar o Cliente";
            }
            else if (vendas.FuncionarioId == 0)
            {
                resultado = "Informar o Funcionario";
            }
            else if (vendas.ValorVenda == 0)
            {
                resultado = "Informar o Funcionario";
            }
            else
            {
                _contexto.Vendas.Update(vendas);
                _contexto.SaveChanges();
            }
            return resultado;
        }


        public string Deletar(Vendas vendas)
        {
            _contexto.Vendas.Remove(vendas);
            _contexto.SaveChanges();
            return "ok";
        }
    }
}
