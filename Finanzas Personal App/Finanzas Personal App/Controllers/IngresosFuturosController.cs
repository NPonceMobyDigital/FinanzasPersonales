using Business;
using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Finanzas_Personal_App.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IngresosFuturosController : ControllerBase
    {
        /// <summary>
        /// este metodo obtiene un ingreso  por id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>devuelve un json con los datos del id</returns>
        [HttpGet("{id}")]
        public IngresosFuturo? Get(int id)
        {
            using (var db = new FinanzasPersonalesContext())
            {
                return new IngresosFuturoBC().obtenerIngresosFuturo(db, id);
            }

        }


        /// <summary>
        /// este metodo agrega un ingreso  por id
        /// </summary>
        /// <param name="oingresosFuturo"></param>
        [HttpPost]
        public void Post([FromBody] IngresosFuturo oingresosFuturo)
        {
            using (var db = new FinanzasPersonalesContext())
            {
                new IngresosFuturoBC().agregarIngresosFuturo(db, oingresosFuturo);

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
                new IngresosFuturoBC().modificarIngresosFuturo(db, id, Detalle, Monto);
            }

        }
    }
}
