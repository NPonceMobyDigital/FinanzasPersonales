using Business;
using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Finanzas_Personal_App.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IngresosController : ControllerBase
    {

        /// <summary>
        /// este metodo obtiene un ingreso  por id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>devuelve un json con los datos del id</returns>
        [HttpGet("{id}")]
        public Ingreso? Get(int id)
        {
            using (var db = new FinanzasPersonalesContext())
            {
                return new IngresoBC().obtenerIngreso(db, id);
            }

        }


        /// <summary>
        /// este metodo agrega un ingreso  por id
        /// </summary>
        /// <param name="oIngreso"></param>
        [HttpPost]
        public void Post([FromBody] Ingreso oIngreso)
        {
            using (var db = new FinanzasPersonalesContext())
            {
                new IngresoBC().agregarIngreso(db, oIngreso);

            }

        }


        /// <summary>
        /// este metodo actualiza un ingreso  por id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="Detalle"></param>
        /// <param name="Monto"></param>
        [HttpPut("{id}")]
        public void Put(int id, string Detalle, int Monto)
        {
            using (var db = new FinanzasPersonalesContext())
            {
                new IngresoBC().modificarIngreso(db, id, Detalle, Monto);
            }

        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            using (var db = new FinanzasPersonalesContext())
            {
                new IngresoBC().eliminarIngreso(db, id);
            }

        }

    }
}
