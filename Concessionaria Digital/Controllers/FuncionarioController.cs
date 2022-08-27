using CD.Business;
using CD.Business.Contexto;
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
            List<Funcionario> lista = new FuncionarioNegocio(_contexto).PesquisarTodos();
            return new JsonResult(lista);

        }

        [HttpGet]
        [Route("{id}")]
        public JsonResult PesquisarFuncionarioPorId(int id)
        {
            var pesquisar = new FuncionarioNegocio(_contexto).PesquisarPorId(id);
            return new JsonResult(pesquisar);
        }


        [HttpPost]
        public JsonResult IncluirFuncionario(Funcionario funcionario)
        {
            string incluir = new FuncionarioNegocio(_contexto).Incluir(funcionario);
            return new JsonResult(incluir);
        }


        [HttpPut]
        public JsonResult AtualizarFuncionario(Funcionario funcionario)
        {
            string atualizar = new FuncionarioNegocio(_contexto).Editar(funcionario);
            return new JsonResult(atualizar);
        }


        [HttpDelete]
        [Route("{id}")]
        public JsonResult DeletarFuncionario(int id)
        {
            string deletar = new FuncionarioNegocio(_contexto).Deletar(new Funcionario { Id = id });
            return new JsonResult(null);
        }
    }
}
