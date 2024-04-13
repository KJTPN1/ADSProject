using ADSProject.Models;

namespace ADSProject.Interfaces
{
    public interface IProfesor
    {
        public int AgregarProfesor(Profesor profesor);
        public int ActualizarProfesor(int IdProfesor, Profesor profesor);
        public bool EliminarProfesor(int IdProfesor);
        public List<Profesor> ObtenerTodosLosProfesores();
        public Profesor ObtenerProfesorPorID(int IdProfesor);
    }
}
