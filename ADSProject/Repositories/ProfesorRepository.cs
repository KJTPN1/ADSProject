using ADSProject.Interfaces;
using ADSProject.Models;

namespace ADSProject.Repositories
{
    public class ProfesorRepository : IProfesor
    {
        private List<Profesor> lstProfesores = new List<Profesor>
        {
            new Profesor{ IdProfesor = 1, NombresProfesor = "JUAN CARLOS",
            ApellidosProfesor = "PEREZ SOSA", Email = "PS24I04002@usonsonate.edu.sv"
            }
        };
        public int ActualizarProfesor(int IdProfesor, Profesor profesor)
        {
            try
            {
                // Obtenemos el indice del objeto para actualizar
                int indice = lstProfesores.FindIndex(tmp => tmp.IdProfesor == IdProfesor);

                // Procedemos con la actualizacion
                lstProfesores[indice] = profesor;

                return IdProfesor;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public int AgregarProfesor(Profesor profesor)
        {
            try
            {
                // Validar si existen datos en la lista, de ser asi, tomaremos el ultimo ID
                // y lo incrementamos en una unidad
                if (lstProfesores.Count > 0)
                {
                    profesor.IdProfesor = lstProfesores.Last().IdProfesor + 1;
                }

                lstProfesores.Add(profesor);

                return profesor.IdProfesor;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool EliminarProfesor(int idProfesor)
        {
            try
            {
                // Obtenemos el indice el objeto a eliminar
                int indice = lstProfesores.FindIndex(tmp => tmp.IdProfesor == idProfesor);

                // Procedemos a eliminar el registro
                lstProfesores.RemoveAt(indice);

                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Profesor ObtenerProfesorPorID(int idProfesor)
        {
            try
            {
                // Buscamos y asignamos el objeto estudiante
                var profesor = lstProfesores.FirstOrDefault(tmp => tmp.IdProfesor == idProfesor);

                return profesor;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Profesor> ObtenerTodosLosProfesores()
        {
            try
            {
                return lstProfesores;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}