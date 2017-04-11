using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.Models;

namespace WebApi.Controllers
{
    public class EstudianteController : ApiController
    {
        List<Estudiante> ListadoEstudiantes = new List<Estudiante>()
        {
            new Estudiante { idEstudiante = "123",nombreEstudiante = "Juan", apellido1Estudiante = "Arias",apellido2Estudiante = "Soto" },
            new Estudiante { idEstudiante = "789",nombreEstudiante = "Juan", apellido1Estudiante = "Arias",apellido2Estudiante = "Soto" },
            new Estudiante { idEstudiante = "855",nombreEstudiante = "Juan", apellido1Estudiante = "Arias",apellido2Estudiante = "Soto" }
        };

        public IEnumerable<Estudiante> GetAllEstudiante()
        {
            return ListadoEstudiantes;
        }

        public IHttpActionResult getEstudiante (string id)
        {
            Estudiante objetoEstudiante = ListadoEstudiantes.FirstOrDefault((x) => x.idEstudiante.Equals(id));
            if (objetoEstudiante != null)
            {
                return Ok(objetoEstudiante);
            }
            else
            {
                return NotFound();
            }
        }
    }
}
