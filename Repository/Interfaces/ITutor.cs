using Adopet.Models;

namespace Adopet.Repository.Interfaces
{
    public interface ITutor
    {
        public Tutor AtualizarTutor(Tutor tutor);
        public Tutor CriarTutor(Tutor tutor);
        public List<Tutor> ExibirTodosTutores();
        public Tutor ExibirTutorById(int id);
        public void DeletarTutor(int id);
    }

}
