using Adopet.Models;
using Adopet.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Adopet.Controllers
{
    [Route("[controller]")]
    public class VisitanteController : Controller
    {
        private readonly IVisitante _visitante;

        public VisitanteController(IVisitante visitante)
        {
            _visitante = visitante;
        }

        // POST
        // Atender uma requisição POST que crie um novo visitante, caso todos os campos
        // estejam preenchido e validados
        // Retornar Json com informações do tutor criado
        [HttpPost("[action]")]
        public Visitante CriarVisitante([FromQuery] Visitante visitante)
        {
            return _visitante.CriarVisitante(visitante);
        }

        // PUT / PATCH
        // Atender uma requisição capaz de atualizar um ou mais campos de um visitante
        // Retornar Json com informações atualizadas do visitante
        [HttpPut("[action]")]
        public Visitante AtualizarVisitante([FromQuery] Visitante visitante)
        {
            return _visitante.AtualizarVisitante(visitante);
        }

        // GET
        // Atender uma requisição GET que retorne um Json com todos os visitantes
        // Caso não exista visitante cadastrado, retornar uma mensagem de "Não encontrado"
        [HttpGet("[action]")]
        public List<Visitante> ExibirTodosVisitantes()
        {
            return _visitante.ExibirTodosVisitantes();
        }

        //GET
        // Atender uma requisição GET que retorne um único visitante caso o ID seja válido
        // caso o visitante não esteja cadastrado, informar uma mensagem de "Não encontrado"
        [HttpGet("[action]")]
        public Visitante ExibirVisitanteById(int id)
        {
            return _visitante.ExibirVisitanteById(id);
        }

        // DELETE
        // Atender uma requisição capaz de deletar um visitante pelo ID
        // Retornar uma mensagem de sucesso ou falha
        [HttpDelete("[action]/{id}")]
        public void DeletarVisitante(int id)
        {
            _visitante.DeletarVisitante(id);
        }
    }
}
