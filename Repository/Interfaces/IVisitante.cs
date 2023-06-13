using Adopet.Models;

namespace Adopet.Repository.Interfaces
{
    public interface IVisitante
    {
        public Visitante AtualizarVisitante(Visitante visitante);
        public Visitante CriarVisitante(Visitante visitante);
        public List<Visitante> ExibirTodosVisitantes();
        public Visitante ExibirVisitanteById(int id);
        public void DeletarVisitante(int id);
    }

}
