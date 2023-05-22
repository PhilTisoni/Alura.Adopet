using Adopet.Data;

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
        public void AtualizarVisitante()
        {

        }

        // POST
        // Atender uma requisição POST que crie um novo visitante, caso todos os campos
        // estejam preenchido e validados
        public void CriarVisitante()
        {

        }

        // GET
        // Atender uma requisição GET que retorne um Json com todos os visitantes
        // Caso não exista visitante cadastrado, retornar uma mensagem de "Não encontrado"
        public void ExibirTodosVisitantes()
        {

        }

        //GET
        // Atender uma requisição GET que retorne um único visitante
        // caso o visitante não esteja cadastrado, informar uma mensagem de "Não encontrado"
        public void ExibirVisitanteById()
        {

        }

        // DELETE
        // Atender uma requisição capaz de deletar um visitante pelo ID
        // Retornar uma mensagem de sucesso ou falha
        public void DeletarVisitante()
        {

        }
    }
}
