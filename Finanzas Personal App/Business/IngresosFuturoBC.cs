using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class IngresosFuturoBC
    {
        /// <summary>
        /// Este metodo Agrega un ingreso 
        /// </summary>
        /// <param name="db"></param>
        /// <param name="oingresosFuturo"></param>
        /// <returns>devuelve un json del ingreso</returns>
        public IngresosFuturo agregarIngresosFuturo(FinanzasPersonalesContext db, IngresosFuturo oingresosFuturo)
        {
            db.IngresosFuturos.Add(oingresosFuturo);
            db.SaveChanges();
            return oingresosFuturo;
        }


        /// <summary>
        /// Este metodo actualiza un ingreso 
        /// </summary>
        /// <param name="db"></param>
        /// <param name="id"></param>
        /// <param name="Detalle"></param>
        /// <param name="Monto"></param>
        /// <returns>devuelve un json con los datos actualizados</returns>
        public IngresosFuturo modificarIngresosFuturo(FinanzasPersonalesContext db, int id, string Detalle, int Monto)
        {
            IngresosFuturo? oIngresoViejo = new IngresosFuturo();
            if (Detalle != null)
            {
                oIngresoViejo.IdIngresosFuturos = id;
                oIngresoViejo.Detalle = Detalle;
                db.SaveChanges();
            }
            else
            {
                return null;
            }
            db.IngresosFuturos.First(a => a.IdIngresosFuturos == id);
            return oIngresoViejo;
        }

        /// <summary>
        /// Este metodo obtiene un ingreso por id
        /// </summary>
        /// <param name="db"></param>
        /// <param name="id"></param>
        /// <returns>devuelve un json por su id</returns>
        public IngresosFuturo? obtenerIngresosFuturo(FinanzasPersonalesContext db, int id)
        {
            return db.IngresosFuturos.FirstOrDefault(a => a.IdIngresosFuturos == id);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="db"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public IngresosFuturo eliminarIngresosFuturo(FinanzasPersonalesContext db, int id)
        {
            IngresosFuturo? oIngresoViejo = db.IngresosFuturos.Find(id);
            if (oIngresoViejo == null)
            {
                return null;
            }
            db.Remove(oIngresoViejo);
            db.SaveChanges();
            return oIngresoViejo;
        }
    }
}
