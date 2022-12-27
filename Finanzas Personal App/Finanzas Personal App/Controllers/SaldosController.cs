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
        [HttpGet("{id}")]
        public Saldo? Get(int id)
        {
            using (var db = new FinanzasPersonalesContext())
            {
                return new SaldoBC().obtenerSaldo(db, id);
            }

        }

        
    }
}
