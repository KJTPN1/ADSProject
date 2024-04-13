using ADSProject.Interfaces;
using ADSProject.Models;
using ADSProject.Utils;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;

namespace ADSProject.Controllers
{
    [Route("api/materias/")]
    public class MateriasController : ControllerBase
    {
        private readonly IMateria materia;
        private string pCodRespuesta;
        public const string COD_EXITO = "000000";
        public const string COD_ERROR = "999999";
        private string pMensajeTecnico;
        private string pMensajeUsuario;

        public MateriasController(IMateria materia)
        {
            this.materia = materia;

        }

        [HttpPost("agregarMateria")]
        public ActionResult<string> AgregarMateria([FromBody] Materia materia)
        {
            try
            {
                int contador = this.materia.AgregarMateria(materia);

                if (contador > 0)
                {
                    pCodRespuesta = COD_EXITO;
                    pMensajeUsuario = "Registro insertado con exito";
                    pMensajeTecnico = pCodRespuesta + " || " + pMensajeUsuario;
                }
                else
                {
                    pCodRespuesta = COD_ERROR;
                    pMensajeUsuario = "Ocurrio un problema al insertar el registro";
                    pMensajeTecnico = pCodRespuesta + " || " + pMensajeUsuario;
                }

                return Ok(new { pCodRespuesta, pMensajeUsuario, pMensajeTecnico });
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpPut("actualizarMateria/{idMateria}")]
        public ActionResult<string> ActualizarMateria(int idMateria, [FromBody] Materia materia)
        {
            try
            {
                int contador = this.materia.ActualizarMateria(idMateria, materia);

                if (contador > 0)
                {
                    pCodRespuesta = COD_EXITO;
                    pMensajeUsuario = "Registro actualizado con exito";
                    pMensajeTecnico = pCodRespuesta + " || " + pMensajeUsuario;
                }
                else
                {
                    pCodRespuesta = COD_ERROR;
                    pMensajeUsuario = "Ocurrio un problema al actualizar el registro";
                    pMensajeTecnico = pCodRespuesta + " || " + pMensajeUsuario;
                }

                return Ok(new { pCodRespuesta, pMensajeUsuario, pMensajeTecnico });
            }
            catch (Exception)
            {

                throw;
            }
        }


        [HttpDelete("eliminarMateria/{idMateria}")]
        public ActionResult<string> eliminarMateria(int idMateria)
        {
            try
            {
               bool eliminado = this.materia.EliminarMateria(idMateria);

                if (eliminado)
                {
                    pCodRespuesta = COD_EXITO;
                    pMensajeUsuario = "Registro eliminado con exito";
                    pMensajeTecnico = pCodRespuesta + " || " + pMensajeUsuario;
                }
                else
                {
                    pCodRespuesta = COD_ERROR;
                    pMensajeUsuario = "Ocurrio un problema al eliminar el registro";
                    pMensajeTecnico = pCodRespuesta + " || " + pMensajeUsuario;
                }

                return Ok(new { pCodRespuesta, pMensajeUsuario, pMensajeTecnico });
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpGet("obtenerMateriaPorID/{idMateria}")]
        public ActionResult<Materia> ObtenerMateriaPorID(int idMateria)
        {
            try
            {
                Materia materia = this.materia.ObtenerMateriaPorID(idMateria);

                if (materia != null)
                {
                    return Ok(materia);
                }
                else
                {
                    pCodRespuesta = Constants.COD_ERROR;
                    pMensajeUsuario = "No se encontraron datos de la materia";
                    pMensajeTecnico = pCodRespuesta + " || " + pMensajeUsuario;

                    return NotFound(new { pCodRespuesta, pMensajeUsuario, pMensajeTecnico });
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpGet("obtenerMaterias")]
        public ActionResult<List<Materia>> ObtenerMaterias()
        {
            try
            {
                List<Materia> lstMaterias = this.materia.ObtenerMaterias();

                return Ok(lstMaterias);
            }
            catch (Exception)
            {

                throw;
            }
        }


    }
}
