using Adopet.Data;
using Adopet.Models;
using Adopet.Repository.Interfaces;

namespace Adopet.Repository
{
    public class TutorRepository : ITutor
    {
        private readonly AppDbContext _context;
        public TutorRepository(AppDbContext context)
        {
            _context = context; 
        }

        public Tutor CriarTutor(Tutor tutor)
        {
            _context.Tutores.Add(tutor);
            _context.SaveChanges();
            return tutor;
        }

        public Tutor AtualizarTutor(Tutor tutor)
        {
            _context.Tutores.Update(tutor);
            _context.SaveChanges();
            return tutor;
        }

        public List<Tutor> ExibirTodosTutores()
        {
            return _context.Tutores.ToList();
        }

        public Tutor ExibirTutorById(int id)
        {
            return _context.Tutores.Find(id);
        }

        public void DeletarTutor(int id)
        {
            var tutor = ExibirTutorById(id);
            if (tutor != null)
            {
                _context.Tutores.Remove(tutor);
                _context.SaveChanges();
            }
        }
    }
}
