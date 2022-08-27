using CD.Business;
using CD.Business.Contexto;
using CD.Models;
using Microsoft.AspNetCore.Mvc;

namespace Concessionaria_Digital.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController
    {
        private readonly EFContexto _contexto;
        public ClienteController(EFContexto context)
        {
            _contexto = context;
        }
        //Listar os Clientes
        [HttpGet]
        public JsonResult PesquisarTodos()
        {
            List<Cliente> lista = new ClienteNegocio(_contexto).PesquisarTodos();
            return new JsonResult(lista);

        }

        [HttpGet]
        [Route("{id}")]
        public JsonResult PesquisarClientePorId(int id)
        {
            var pesquisar = new ClienteNegocio(_contexto).PesquisarPorId(id);
            return new JsonResult(pesquisar);
        }


        [HttpPost]
        public JsonResult IncluirCliente(Cliente cliente)
        {
            string incluir = new ClienteNegocio(_contexto).Incluir(cliente);
            return new JsonResult(incluir);
        }


        [HttpPut]
        public JsonResult AtualizarCliente(Cliente cliente)
        {
            string atualizar = new ClienteNegocio(_contexto).Editar(cliente);
            return new JsonResult(atualizar);
        }


        [HttpDelete]
        [Route("{id}")]
        public JsonResult DeletarEstoque(int id)
        {
            string deletar = new ClienteNegocio(_contexto).Deletar(new Cliente { Id = id });
            return new JsonResult(deletar);
        }
    }
}
