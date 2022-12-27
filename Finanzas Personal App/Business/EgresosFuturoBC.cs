using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class EgresosFuturoBC
    {
        /// <summary>
        /// Este metodo agrega un egreso futuro 
        /// </summary>
        /// <param name="db"></param>
        /// <param name="oegresosFuturo"></param>
        /// <returns>devuelve un json del egreso futuro</returns>
        public EgresosFuturo agregarEgresosFuturo(FinanzasPersonalesContext db, EgresosFuturo oegresosFuturo)
        {
            db.EgresosFuturos.Add(oegresosFuturo);
            db.SaveChanges();
            return oegresosFuturo;
        }


        /// <summary>
        /// Este metodo actualiza un egreso futuro
        /// </summary>
        /// <param name="db"></param>
        /// <param name="id"></param>
        /// <param name="Detalle"></param>
        /// <param name="Monto"></param>
        /// <returns>devuelve un json con los datos actualizados</returns>
        public EgresosFuturo modificarSaldosFuturo(FinanzasPersonalesContext db, int id, string Detalle, int Monto)
        {
            EgresosFuturo? oEgresoViejo = db.EgresosFuturos.FirstOrDefault(a => a.IdEgresosFuturos == id);
            oEgresoViejo.Detalle = Detalle;
            oEgresoViejo.Monto = Monto;
            db.SaveChanges();
            return oEgresoViejo;
        }

        /// <summary>
        /// este metodo obtiene un egreso  por id
        /// </summary>
        /// <param name="db"></param>
        /// <param name="id"></param>
        /// <returns>devuelve un json por su id</returns>

        public EgresosFuturo? obtenerSaldosFuturo(FinanzasPersonalesContext db, int id)
        {
            return db.EgresosFuturos.FirstOrDefault(a => a.IdEgresosFuturos == id);
        }
    }
}
