using Business;
using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Finanzas_Personal_App.Controllers
{
    [Route("api/saldos")]
    [ApiController]
    public class SaldosController : ControllerBase
    {

        /// <summary>
        /// este metodo obtiene un saldo  por id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>devuelve un json con los datos por id</returns>
        [HttpGet("{id}")]
        public Saldo? Get(int id)
        {
            using (var db = new FinanzasPersonalesContext())
            {
                return new SaldoBC().obtenerSaldo(db, id);
            }

        }


        /// <summary>
        /// este metodo agrega un saldo  por id
        /// </summary>
        /// <param name="osaldo"></param>
        [HttpPost]
        public void Post([FromBody] Saldo osaldo)
        {
            using (var db = new FinanzasPersonalesContext())
            {
                new SaldoBC().agregarSaldo(db, osaldo);

            }

        }


        /// <summary>
        /// este metodo actualiza un saldo  por id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="Detalle"></param>
        /// <param name="Monto"></param>
        [HttpPut("{id}")]
        public void Put(int id, string Detalle, int Monto)
        {
            using (var db = new FinanzasPersonalesContext())
            {
                new SaldoBC().modificarSaldo(db, id, Detalle, Monto);
            }

        }
        /// <summary>
        /// este metodo elimina un registro
        /// </summary>
        /// <param name="id"></param>
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            using (var db = new FinanzasPersonalesContext())
            {
                new SaldoBC().eliminarSaldo(db, id);
            }

        }

    }
}
