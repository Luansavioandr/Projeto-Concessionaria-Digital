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

        public List<Vendas> PesquisarTodos()
        {
            return _contexto.Vendas.ToList();
        }

        public Vendas PesquisarPorId(int id)
        {
            return _contexto.Vendas.Find(id);
        }

        public string Incluir(Vendas vendas)
        {
            _contexto.Vendas.Add(vendas);
            _contexto.SaveChanges();
            return "Salvo Com Sucesso";
        }

        public string Editar(Vendas vendas)
        {
            _contexto.Vendas.Update(vendas);
            _contexto.SaveChanges();
            return "Salvo Com Sucesso";
        }

        public string Deletar(Vendas vendas)
        {
            _contexto.Vendas.Remove(vendas);
            _contexto.SaveChanges();
            return "ok";
        }
    }
}
