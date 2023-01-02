using Business;
using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Finanzas_Personal_App.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EgresosFuturosController : ControllerBase
    {
        /// <summary>
        /// este metodo obtiene un egreso  por id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>devuelve un json con los datos del id</returns>
        [HttpGet("{id}")]
        public EgresosFuturo? Get(int id)
        {
            using (var db = new FinanzasPersonalesContext())
            {
                return new EgresosFuturoBC().obtenerEgresosFuturo(db, id);
            }

        }


        /// <summary>
        /// este metodo agrega un egreso 
        /// </summary>
        /// <param name="oegresosFuturo"></param>
        [HttpPost]
        public void Post([FromBody] EgresosFuturo oegresosFuturo)
        {
            using (var db = new FinanzasPersonalesContext())
            {
                new EgresosFuturoBC().agregarEgresosFuturo(db, oegresosFuturo);

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
                new EgresosFuturoBC().modificarEgresosFuturo(db, id, Detalle, Monto);
            }

        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            using (var db = new FinanzasPersonalesContext())
            {
                new EgresosFuturoBC().eliminarEgresoFuturo(db, id);
            }

        }
    }
}
