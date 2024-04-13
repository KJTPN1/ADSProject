using ADSProject.Models;

namespace ADSProject.Interfaces
{
    public interface IMateria
    {
        public int AgregarMateria(Materia materia);
        public int ActualizarMateria(int idMateria, Materia materia);
        public List<Materia> ObtenerMaterias();
        public Materia ObtenerMateriaPorID(int idMateria);
        public bool EliminarMateria(int idMateria);
    }
}
