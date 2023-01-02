using Business;
using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Finanzas_Personal_App.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EgresosController : ControllerBase
    {
        /// <summary>
        /// este metodo obtiene un egreso  por id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Devuelve un json con los datos del id</returns>
        [HttpGet("{id}")]
        public Egreso? Get(int id)
        {
            using (var db = new FinanzasPersonalesContext())
            {
                return new EgresoBC().obtenerEgreso(db, id);
            }

        }


        /// <summary>
        /// este metodo agrega un egreso 
        /// </summary>
        /// <param name="oEgreso"></param>
        [HttpPost]
        public void Post([FromBody] Egreso oEgreso)
        {
            using (var db = new FinanzasPersonalesContext())
            {
                new EgresoBC().agregarEgreso(db, oEgreso);

            }

        }


        /// <summary>
        /// este metodo actualiza un egreso  por id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="Detalle"></param>
        /// <param name="Monto"></param>
        [HttpPut("{id}")]
        public void Put(int id, string Detalle, int Monto)
        {
            using (var db = new FinanzasPersonalesContext())
            {
                new EgresoBC().modificarEgreso(db, id, Detalle, Monto);
            }

        }
//dgdg//
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            using (var db = new FinanzasPersonalesContext())
            {
                new EgresoBC().eliminarEgreso(db,id);
            }

        }


    }
}
