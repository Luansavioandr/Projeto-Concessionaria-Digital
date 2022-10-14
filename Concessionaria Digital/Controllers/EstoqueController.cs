using CD.Business;
using CD.Business.Contexto;
using CD.Business.Interfaces;
using CD.Models;
using Microsoft.AspNetCore.Mvc;

namespace Concessionaria_Digital.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstoqueController
    {
        private readonly EFContexto _contexto;
        public EstoqueController(EFContexto context)
        {
            _contexto = context;
        }
        //Listar o Estoque
        [HttpGet]
        public JsonResult PesquisarTodos()
        {
            IEstoqueNegocio estoqueNegocio = new EstoqueNegocio(_contexto);
            List<Estoque> lista = estoqueNegocio.PesquisarTodos();
            return new JsonResult(lista);

        }
 
        [HttpGet]
        [Route("{id}")]
        public JsonResult PesquisarEstoquePorId(int id)
        {
            IEstoqueNegocio estoqueNegocio = new EstoqueNegocio(_contexto);
            var pesquisar = estoqueNegocio.PesquisarPorId(id);
            return new JsonResult(pesquisar);
        }


        [HttpPost]
        public JsonResult IncluirEstoque(Estoque estoque)
        {
            IEstoqueNegocio estoqueNegocio = new EstoqueNegocio(_contexto);
            string incluir = estoqueNegocio.Incluir(estoque);
            return new JsonResult(incluir);
        }


        [HttpPut]
        public JsonResult AtualizarEstoque(Estoque estoque)
        {
            IEstoqueNegocio estoqueNegocio = new EstoqueNegocio(_contexto);
            string atualizar = estoqueNegocio.Editar(estoque);
            return new JsonResult(atualizar);
        }


        [HttpDelete]
        [Route("{id}")]
        public JsonResult DeletarEstoque(int id)
        {
            IEstoqueNegocio estoqueNegocio = new EstoqueNegocio(_contexto);
            string deletar = estoqueNegocio.Deletar(new Estoque { Id = id });
            return new JsonResult(deletar);
        }
    }
}
