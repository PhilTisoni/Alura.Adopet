using Adopet.Data.Dtos;
using Adopet.Models;
using Adopet.Repository.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace Adopet.Controllers
{
    [Route("[controller]")]
    public class TutorController : Controller
    {
        private readonly ITutor _tutor;
        private readonly IMapper _mapper;

        public TutorController(ITutor tutor, IMapper mapper)
        {
            _tutor = tutor;
            _mapper = mapper;
        }

        // POST
        // Atender uma requisição POST que crie um novo tutor, caso todos os campos
        // estejam preenchido e validados
        // Retornar Json com informações do tutor criado
        [HttpPost("[action]")]
        public IActionResult CriarTutor([FromBody] CriarTutorDto tutorDto)
        {
            Tutor tutor = _tutor.CriarTutor(_mapper.Map<Tutor>(tutorDto));
            return CreatedAtAction(nameof(ExibirTutorById), new{id = tutor.Id}, tutor);            
        }

        // PUT / PATCH
        // Atender uma requisição capaz de atualizar um ou mais campos de um tutor
        // Retornar Json com informações atualizadas do tutor
        [HttpPut("[action]")]
        public Tutor AtualizarTutor([FromQuery] Tutor tutor)
        {
            return _tutor.AtualizarTutor(tutor);
        }

        // GET
        // Atender uma requisição GET que retorne um Json com todos os tutores
        // Caso não exista tutor cadastrado, retornar uma mensagem de "Não encontrado"
        [HttpGet("[action]")]
        public List<Tutor> ExibirTodosTutores()
        {
            return _tutor.ExibirTodosTutores();
        }

        //GET
        // Atender uma requisição GET que retorne um único tutor caso o ID seja válido
        // caso o visitante não esteja cadastrado, informar uma mensagem de "Não encontrado"
        [HttpGet("[action] / {id}")]
        public Tutor ExibirTutorById(int id)
        {
            return _tutor.ExibirTutorById(id);
        }

        // DELETE
        // Atender uma requisição capaz de deletar um tutor pelo ID
        // Retornar uma mensagem de sucesso ou falha
        [HttpDelete("[action]/{id}")]
        public void DeletarTutor(int id)
        {
            _tutor.DeletarTutor(id);
        }
    }
}
