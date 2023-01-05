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
            SaldosFuturo? oIngresoViejo = new SaldosFuturo();
            if (Descripcion != null)
            {
                oIngresoViejo.IdMontoFuturo = id;
                oIngresoViejo.Descripcion = Descripcion;
                db.SaveChanges();
            }
            else
            {
                return null;
            }
            db.Saldos.First(a => a.IdSaldo == id);
            return oIngresoViejo;
        }

        /// <summary>
        ///este metodo obtiene un saldo  por id
        /// </summary>
        /// <param name="db"></param>
        /// <param name="id"></param>
        /// <returns>devuelve un json por su id</returns>

        public SaldosFuturo? obtenerSaldosFuturo(FinanzasPersonalesContext db, int id)
        {
            return db.SaldosFuturos.First(a => a.IdMontoFuturo == id);
        }

        /// <summary>
        /// este metodo elimina un registro
        /// </summary>
        /// <param name="db"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        /// 
        public SaldosFuturo eliminarSaldoFuturo(FinanzasPersonalesContext db, int id)
        {
            SaldosFuturo? osaldoViejo = db.SaldosFuturos.Find(id);
            if (osaldoViejo==null)
            {
                return null;
            }

            db.Remove(osaldoViejo);
            db.SaveChanges();
            return osaldoViejo;
             
        }

    }
}
