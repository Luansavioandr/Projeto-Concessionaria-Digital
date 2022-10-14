using CD.Business;
using CD.Business.Contexto;
using CD.Business.Interfaces;
using CD.Models;
using Microsoft.AspNetCore.Mvc;

namespace Concessionaria_Digital.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VendasController
    {
        private readonly EFContexto _contexto;
        public VendasController(EFContexto context)
        {
            _contexto = context;
        }
        //Listar as Vendas
        [HttpGet]
        public JsonResult PesquisarTodos()
        {
            IVendasNegocio vendasNegocio = new VendasNegocio(_contexto);
            List<Vendas> lista = vendasNegocio.PesquisarTodosFiltrado();
            return new JsonResult(lista);

        }

        [HttpGet]
        [Route("{id}")]
        public JsonResult PesquisarVendasPorId(int id)
        {
            IVendasNegocio vendasNegocio = new VendasNegocio(_contexto);
            var pesquisar = vendasNegocio.PesquisarPorId(id);
            return new JsonResult(pesquisar);
        }


        [HttpPost]
        public JsonResult IncluirVendas(Vendas vendas)
        {
            IVendasNegocio vendasNegocio = new VendasNegocio(_contexto);
            string incluir = vendasNegocio.Incluir(vendas);
            return new JsonResult(incluir);
        }


        [HttpPut]
        public JsonResult AtualizarVendas(Vendas vendas)
        {
            IVendasNegocio vendasNegocio = new VendasNegocio(_contexto);
            string atualizar = vendasNegocio.Editar(vendas);
            return new JsonResult(atualizar);
        }


        [HttpDelete]
        [Route("{id}")]
        public JsonResult DeletarVendas(int id)
        {
            IVendasNegocio vendasNegocio = new VendasNegocio(_contexto);
            string deletar = vendasNegocio.Deletar(new Vendas { Id = id });
            return new JsonResult(deletar);
        }
    }
}
