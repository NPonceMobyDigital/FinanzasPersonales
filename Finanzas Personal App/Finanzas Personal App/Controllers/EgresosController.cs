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

        [HttpGet("{id}")]
        public Egreso? Get(int id)
        {
            using (var db = new FinanzasPersonalesContext())
            {
                return new EgresoBC().obtenerEgreso(db, id);
            }

        }



        [HttpPost]
        public void Post([FromBody] Ingreso oIngreso)
        {
            using (var db = new FinanzasPersonalesContext())
            {
                new IngresoBC().agregarIngreso(db, oIngreso);

            }

        }



        [HttpPut("{id}")]
        public void Put(int id, string Detalle, int Monto)
        {
            using (var db = new FinanzasPersonalesContext())
            {
                new IngresoBC().modificarIngreso(db, id, Detalle, Monto);
            }

        }


    }
}
