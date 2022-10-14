using CD.Business;
using CD.Business.Contexto;
using CD.Business.Interfaces;
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
            IClienteNegocio clienteNegocio = new ClienteNegocio(_contexto);
            List<Cliente> lista = clienteNegocio.PesquisarTodos();
            return new JsonResult(lista);

        }

        [HttpGet]
        [Route("{id}")]
        public JsonResult PesquisarClientePorId(int id)
        {
            IClienteNegocio clienteNegocio = new ClienteNegocio(_contexto);
            var pesquisar = clienteNegocio.PesquisarPorId(id);
            return new JsonResult(pesquisar);
        }


        [HttpPost]
        public JsonResult IncluirCliente(Cliente cliente)
        {
            IClienteNegocio clienteNegocio = new ClienteNegocio(_contexto);
            string incluir = clienteNegocio.Incluir(cliente);
            return new JsonResult(incluir);
        }


        [HttpPut]
        public JsonResult AtualizarCliente(Cliente cliente)
        {
            IClienteNegocio clienteNegocio = new ClienteNegocio(_contexto);
            string atualizar = clienteNegocio.Editar(cliente);
            return new JsonResult(atualizar);
        }


        [HttpDelete]
        [Route("{id}")]
        public JsonResult DeletarEstoque(int id)
        {
            IClienteNegocio clienteNegocio = new ClienteNegocio(_contexto);
            string deletar = clienteNegocio.Deletar(new Cliente { Id = id });
            return new JsonResult(deletar);
        }
    }
}
