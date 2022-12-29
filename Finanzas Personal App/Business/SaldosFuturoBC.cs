using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class SaldosFuturoBC
    {
        /// <summary>
        /// Este metodo agrega un saldo futuro 
        /// </summary>
        /// <param name="db"></param>
        /// <param name="osaldosFuturo"></param>
        /// <returns>devuelve un json del saldo futuro</returns>
        public SaldosFuturo agregarSaldosFuturo(FinanzasPersonalesContext db, SaldosFuturo osaldosFuturo)
        {
            db.SaldosFuturos.Add(osaldosFuturo);
            db.SaveChanges();
            return osaldosFuturo;
        }


        /// <summary>
        /// Este metodo actualiza un saldo futuro
        /// </summary>
        /// <param name="db"></param>
        /// <param name="id"></param>
        /// <param name="Descripcion"></param>
        /// <param name="Monto"></param>
        /// <returns>devuelve un json con los datos actualizados</returns>
        public SaldosFuturo modificarSaldosFuturo(FinanzasPersonalesContext db, int id, string Descripcion, int Monto)
        {
            SaldosFuturo? osaldoViejo = db.SaldosFuturos.FirstOrDefault(a => a.IdMontoFuturo == id);
            osaldoViejo.Descripcion = Descripcion;
            osaldoViejo.Monto = Monto;
            db.SaveChanges();
            return osaldoViejo;
        }

        /// <summary>
        ///este metodo obtiene un saldo  por id
        /// </summary>
        /// <param name="db"></param>
        /// <param name="id"></param>
        /// <returns>devuelve un json por su id</returns>

        public SaldosFuturo? obtenerSaldosFuturo(FinanzasPersonalesContext db, int id)
        {
            return db.SaldosFuturos.FirstOrDefault(a => a.IdMontoFuturo == id);
        }

       
    }
}
