using ADSProject.Interfaces;
using ADSProject.Models;

namespace ADSProject.Repositories
{
    public class GrupoRepository : IGrupo
    {
        private List<Grupo> lstGrupos = new List<Grupo>
        {
            new Grupo{ IdGrupo = 1, IdCarrera = 1, IdMateria = 1, 
                Anio = 2024, Ciclo = 1, IdProfesor = 1
            }
        };
        public int ActualizarGrupo(int idGrupo, Grupo grupo)
        {
            try
            {
                // Obtenemos el indice del objeto para actualizar
                int indice = lstGrupos.FindIndex(tmp => tmp.IdGrupo == idGrupo);

                // Procedemos con la actualizacion
                lstGrupos[indice] = grupo;

                return idGrupo;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public int AgregarGrupo(Grupo grupo)
        {
            try
            {
                // Validar si existen datos en la lista, de ser asi, tomaremos el ultimo ID
                // y lo incrementamos en una unidad
                if (lstGrupos.Count > 0)
                {
                    grupo.IdGrupo = lstGrupos.Last().IdGrupo + 1;
                }

                lstGrupos.Add(grupo);

                return grupo.IdGrupo;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool EliminarGrupo(int idGrupo)
        {
            try
            {
                // Obtenemos el indice el objeto a eliminar
                int indice = lstGrupos.FindIndex(tmp => tmp.IdGrupo == idGrupo);

                // Procedemos a eliminar el registro
                lstGrupos.RemoveAt(indice);

                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Grupo ObtenerGrupoPorID(int idGrupo)
        {
            try
            {
                // Buscamos y asignamos el objeto estudiante
                var grupo = lstGrupos.FirstOrDefault(tmp => tmp.IdGrupo == idGrupo);

                return grupo;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Grupo> ObtenerTodosLosGrupos()
        {
            try
            {
                return lstGrupos;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
