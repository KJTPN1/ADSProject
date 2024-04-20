using ADSProject.Interfaces;
using ADSProject.Models;

namespace ADSProject.Repositories
{
    public class CarreraRepository : ICarrera
    {
        private List<Carrera> lstCarreras = new List<Carrera>
        {
            new Carrera{ IdCarrera = 1, Codigo = "ADS", Nombre = "Analisis de Sistemas"
            }
        };

        public int ActualizarCarrera(int IdCarrera, Carrera carrera)
        {
            try
            {
                int indice = lstCarreras.FindIndex(tmp => tmp.IdCarrera == IdCarrera);

                lstCarreras[indice] = carrera;

                return IdCarrera;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public int AgregarCarrera(Carrera carrera)
        {
            try
            {
                if (lstCarreras.Count > 0)
                {
                    carrera.IdCarrera = lstCarreras.Last().IdCarrera + 1;
                }

                lstCarreras.Add(carrera);

                return carrera.IdCarrera;
            }
            catch
            {
                throw;
            }
        }
        public bool EliminarCarrera(int IdCarrera)
        {
            try
            {
                int indice = lstCarreras.FindIndex(tmp => tmp.IdCarrera == IdCarrera);

                lstCarreras.RemoveAt(indice);

                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public Carrera ObtenerCarreraPorID(int IdCarrera)
        {
            try
            {
                Carrera carrera = lstCarreras.FirstOrDefault(tmp => tmp.IdCarrera == IdCarrera);

                return carrera;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public List<Carrera> ObtenerTodasLasCarreras()
        {
            try
            {
                return lstCarreras;
            }
            catch (Exception)
            {
                throw;
            }
        }


    }
}
