using Adopet.Data;
using Adopet.Models;

namespace Adopet.Repository
{
    public class VisitanteRepository
    {
        private readonly AppDbContext _context;
        public VisitanteRepository(AppDbContext context)
        {
            _context = context; 
        }

        // PUT / PATCH
        // Atender uma requisição capaz de atualizar um ou mais campos de um visitante
        public Visitante AtualizarVisitante(int id, Visitante visitante)
        {
            _context.Visitantes.Update(visitante);
            _context.SaveChanges();
            return visitante;
        }

        // POST
        // Atender uma requisição POST que crie um novo visitante, caso todos os campos
        // estejam preenchido e validados
        public Visitante CriarVisitante(Visitante visitante)
        {
            _context.Visitantes.Add(visitante);
            _context.SaveChanges();
            return visitante;
        }

        // GET
        // Atender uma requisição GET que retorne um Json com todos os visitantes
        // Caso não exista visitante cadastrado, retornar uma mensagem de "Não encontrado"
        public List<Visitante> ExibirTodosVisitantes()
        {
            return _context.Visitantes.ToList();
        }

        //GET
        // Atender uma requisição GET que retorne um único visitante
        // caso o visitante não esteja cadastrado, informar uma mensagem de "Não encontrado"
        public Visitante ExibirVisitanteById(int id)
        {
            return _context.Visitantes.Find(id);
        }

        // DELETE
        // Atender uma requisição capaz de deletar um visitante pelo ID
        // Retornar uma mensagem de sucesso ou falha
        public void DeletarVisitante(int id)
        {
            var visitante = ExibirVisitanteById(id);
            if (visitante != null)
            {
                _context.Visitantes.Remove(visitante);
                _context.SaveChanges();
            }
        }
    }
}
