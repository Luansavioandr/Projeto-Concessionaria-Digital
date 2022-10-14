using CD.Business;
using CD.Business.Contexto;
using CD.Business.Interfaces;
using CD.Models;
using Microsoft.AspNetCore.Mvc;

namespace Concessionaria_Digital.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FuncionarioController
    {
        private readonly EFContexto _contexto;
        public FuncionarioController(EFContexto context)
        {
            _contexto = context;
        }
        //Listar os Funcionario
        [HttpGet]
        public JsonResult PesquisarTodos()
        {
            IFuncionarioNegocio funcionarioNegocio = new FuncionarioNegocio(_contexto);
            List<Funcionario> lista = funcionarioNegocio.PesquisarTodos();
            return new JsonResult(lista);

        }

        [HttpGet]
        [Route("{id}")]
        public JsonResult PesquisarFuncionarioPorId(int id)
        {
            IFuncionarioNegocio funcionarioNegocio = new FuncionarioNegocio(_contexto);
            var pesquisar = funcionarioNegocio.PesquisarPorId(id);
            return new JsonResult(pesquisar);
        }


        [HttpPost]
        public JsonResult IncluirFuncionario(Funcionario funcionario)
        {
            IFuncionarioNegocio funcionarioNegocio = new FuncionarioNegocio(_contexto);
            string incluir = funcionarioNegocio.Incluir(funcionario);
            return new JsonResult(incluir);
        }


        [HttpPut]
        public JsonResult AtualizarFuncionario(Funcionario funcionario)
        {
            IFuncionarioNegocio funcionarioNegocio = new FuncionarioNegocio(_contexto);
            string atualizar = funcionarioNegocio.Editar(funcionario);
            return new JsonResult(atualizar);
        }


        [HttpDelete]
        [Route("{id}")]
        public JsonResult DeletarFuncionario(int id)
        {
            IFuncionarioNegocio funcionarioNegocio = new FuncionarioNegocio(_contexto);
            string deletar = funcionarioNegocio.Deletar(new Funcionario { Id = id });
            return new JsonResult(null);
        }
    }
}
