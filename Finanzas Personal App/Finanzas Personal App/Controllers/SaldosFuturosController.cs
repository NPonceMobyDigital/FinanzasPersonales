using Business;
using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Finanzas_Personal_App.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SaldosFuturosController : ControllerBase
    {
        /// <summary>
        /// este metodo obtiene un saldo  por id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public SaldosFuturo? Get(int id)
        {
            using (var db = new FinanzasPersonalesContext())
            {
                return new SaldosFuturoBC().obtenerSaldosFuturo(db, id);
            }

        }


        /// <summary>
        /// este metodo agrega un saldo  por id
        /// </summary>
        /// <param name="osaldosFuturo"></param>
        [HttpPost]
        public void Post([FromBody] SaldosFuturo osaldosFuturo)
        {
            using (var db = new FinanzasPersonalesContext())
            {
                new SaldosFuturoBC().agregarSaldosFuturo(db, osaldosFuturo);

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
                new SaldosFuturoBC().modificarSaldosFuturo(db, id, Detalle, Monto);
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
                new SaldosFuturoBC().eliminarSaldoFuturo(db, id);
            }

        }
    }
}
