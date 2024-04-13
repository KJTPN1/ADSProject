using ADSProject.Interfaces;
using ADSProject.Models;

namespace ADSProject.Repositories
{
    public class MateriaRepository : IMateria
    {
        private List<Materia> listitaMaterias = new List<Materia>
        {
            new Materia{IdMateria = 1, NombreMateria = "Estatica"}
        };

        public int ActualizarMateria(int idMateria, Materia materia)
        {
            try
            {
                int bandera = 0;

                int index = listitaMaterias.FindIndex(tmp => tmp.IdMateria == idMateria);
                
                if(index >= 0)
                {
                    listitaMaterias[index] = materia;
                    bandera = idMateria;
                } else
                {
                    bandera = -1;
                }

                return bandera;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int AgregarMateria(Materia materia)
        {
            try
            {
                if(listitaMaterias.Count > 0)
                {
                    materia.IdMateria = listitaMaterias.Last().IdMateria + 1;
                }
                listitaMaterias.Add(materia);

                return materia.IdMateria;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool EliminarMateria(int idMateria)
        {
            try
            {
                bool bandera = false;
                int index = listitaMaterias.FindIndex(aux => aux.IdMateria == idMateria);

                if (index >= 0)
                {
                    listitaMaterias.RemoveAt(index);
                    bandera = true;
                }

                return bandera;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Materia ObtenerMateriaPorID(int idMateria)
        {
            try
            {
                var materia = listitaMaterias.FirstOrDefault(tmp => tmp.IdMateria == idMateria);

                return materia;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Materia> ObtenerMaterias()
        {
            try
            {
                return listitaMaterias;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
