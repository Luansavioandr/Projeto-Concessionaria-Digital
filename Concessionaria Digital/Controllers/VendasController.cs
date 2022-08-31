using CD.Business;
using CD.Business.Contexto;
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
            List<Vendas> lista = new VendasNegocio(_contexto).PesquisarTodosFiltrado();
            return new JsonResult(lista);

        }

        [HttpGet]
        [Route("{id}")]
        public JsonResult PesquisarVendasPorId(int id)
        {
            var pesquisar = new VendasNegocio(_contexto).PesquisarPorId(id);
            return new JsonResult(pesquisar);
        }


        [HttpPost]
        public JsonResult IncluirVendas(Vendas vendas)
        {
            string incluir = new VendasNegocio(_contexto).Incluir(vendas);
            return new JsonResult(incluir);
        }


        [HttpPut]
        public JsonResult AtualizarVendas(Vendas vendas)
        {
            string atualizar = new VendasNegocio(_contexto).Editar(vendas);
            return new JsonResult(atualizar);
        }


        [HttpDelete]
        [Route("{id}")]
        public JsonResult DeletarVendas(int id)
        {
            string deletar = new VendasNegocio(_contexto).Deletar(new Vendas { Id = id });
            return new JsonResult(deletar);
        }
    }
}
