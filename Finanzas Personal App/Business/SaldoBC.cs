using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class SaldoBC
    {
        /// <summary>
        /// Este metodo Agrega un saldo 
        /// </summary>
        /// <param name="db"></param>
        /// <param name="oSaldo"></param>
        /// <returns>devuelve un json del saldo </returns>
        public Saldo agregarSaldo(FinanzasPersonalesContext db, Saldo oSaldo)
        {
            db.Saldos.Add(oSaldo);
            db.SaveChanges();
            return oSaldo;
        }


        /// <summary>
        /// Este metodo actualiza un saldo 
        /// </summary>
        /// <param name="db"></param>
        /// <param name="id"></param>
        /// <param name="Detalle"></param>
        /// <param name="Monto"></param>
        /// <returns>devuelve un json con los datos del saldo actualizados</returns>
        public Saldo modificarSaldo(FinanzasPersonalesContext db, int id, string Detalle, int Monto)
        {
            Saldo? oIngresoViejo = db.Saldos.FirstOrDefault(a => a.IdSaldo == id);
            oIngresoViejo.Monto = Monto;
            db.SaveChanges();
            return oIngresoViejo;
        }

        /// <summary>
        /// Este metodo obtiene un saldo por id
        /// </summary>
        /// <param name="db"></param>
        /// <param name="id"></param>
        /// <returns>devuelve un json por su id</returns>

        public Saldo? obtenerSaldo(FinanzasPersonalesContext db, int id)
        {
            return db.Saldos.FirstOrDefault(a => a.IdSaldo == id);
        }


    }
}

