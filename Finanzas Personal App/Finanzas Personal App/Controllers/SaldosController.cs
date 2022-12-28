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
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public Saldo? Get(int id)
        {
            using (var db = new FinanzasPersonalesContext())
            {
                return new SaldoBC().obtenerSaldo(db, id);
            }

        }


        /// <summary>
        /// 
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
                new SaldoBC().modificarSaldo(db, id, Detalle, Monto);
            }

        }


    }
}
