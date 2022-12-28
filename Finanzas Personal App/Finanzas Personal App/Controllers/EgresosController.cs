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
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public Egreso? Get(int id)
        {
            using (var db = new FinanzasPersonalesContext())
            {
                return new EgresoBC().obtenerEgreso(db, id);
            }

        }
        

        /// <summary>
        /// 
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
        /// 
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


    }
}
