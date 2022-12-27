using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class EgresoBC
    {
        /// <summary>
        ///Este metodo Agrega un egreso 
        /// </summary>
        /// <param name="db"></param>
        /// <param name="oEgreso"></param>
        /// <returns>devuelve un json</returns>

        public Egreso agregarEgreso(FinanzasPersonalesContext db, Egreso oEgreso)
        {
            db.Egresos.Add(oEgreso);
            db.SaveChanges();
            return oEgreso;
        }

        /// <summary>
        /// Este metodo actualiza un egreso 
        /// </summary>
        /// <param name="db"></param>
        /// <param name="id"></param>
        /// <param name="Detalle"></param>
        /// <param name="Monto"></param>
        /// <returns>devuelve un json con los datos actualizados</returns>

        public Egreso modificarEgreso(FinanzasPersonalesContext db, int id, string Detalle, int Monto)
        {
            Egreso? oEgresoViejo = db.Egresos.FirstOrDefault(a => a.IdEgreso == id);
            oEgresoViejo.Detalle = Detalle;
            oEgresoViejo.Monto = Monto;
            db.SaveChanges();
            return oEgresoViejo;
        }


        /// <summary>
        /// Este metodo obtiene un egreso por id
        /// </summary>
        /// <param name="db"></param>
        /// <param name="id"></param>
        /// <returns>devuelve un json por su id</returns>
        public Egreso? obtenerEgreso(FinanzasPersonalesContext db, int id)
        {
            return db.Egresos.FirstOrDefault(a => a.IdEgreso == id);
        }

    }
}
