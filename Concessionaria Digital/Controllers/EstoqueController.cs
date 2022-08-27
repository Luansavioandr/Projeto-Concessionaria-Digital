using CD.Business;
using CD.Business.Contexto;
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
            List<Estoque> lista = new EstoqueNegocio(_contexto).PesquisarTodos();
            return new JsonResult(lista);

        }
 
        [HttpGet]
        [Route("{id}")]
        public JsonResult PesquisarEstoquePorId(int id)
        {
            var pesquisar = new EstoqueNegocio(_contexto).PesquisarPorId(id);
            return new JsonResult(pesquisar);
        }


        [HttpPost]
        public JsonResult IncluirEstoque(Estoque estoque)
        {
            string incluir = new EstoqueNegocio(_contexto).Incluir(estoque);
            return new JsonResult(incluir);
        }


        [HttpPut]
        public JsonResult AtualizarEstoque(Estoque estoque)
        {
            string atualizar = new EstoqueNegocio(_contexto).Editar(estoque);
            return new JsonResult(atualizar);
        }


        [HttpDelete]
        [Route("{id}")]
        public JsonResult DeletarEstoque(int id)
        {
            string deletar = new EstoqueNegocio(_contexto).Deletar(new Estoque { Id = id });
            return new JsonResult(deletar);
        }
    }
}
