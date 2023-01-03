using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class IngresoBC
    {
        /// <summary>
        /// Este metodo Agrega un ingreso 
        /// </summary>
        /// <param name="db"></param>
        /// <param name="oIngreso"></param>
        /// <returns>devuelve un json del ingreso  </returns>
        /// 
        public Ingreso agregarIngreso(FinanzasPersonalesContext db, Ingreso oIngreso)
        {
            db.Ingresos.Add(oIngreso);
            db.SaveChanges();
            return oIngreso;
        }

        /// <summary>
        /// Este metodo obtiene un ingreso por id
        /// </summary>
        /// <param name="db"></param>
        /// <param name="id"></param>
        /// <returns>devuelve un json por su id </returns>
        public Ingreso? obtenerIngreso(FinanzasPersonalesContext db, int id)
        {
            return db.Ingresos.FirstOrDefault(a => a.IdIngreso == id);
        }

        /// <summary>
        /// Este metodo actualiza un ingreso 
        /// </summary>
        /// <param name="db"></param>
        /// <param name="id"></param>
        /// <param name="Detalle"></param>
        /// <param name="Monto"></param>
        /// <returns>devuelve un json con los datos actualizados</returns>
        public Ingreso modificarIngreso(FinanzasPersonalesContext db, int id, string Detalle, int Monto)
        {
            Ingreso? oIngresoViejo = new Ingreso();
            if(Detalle !=null)
            {   
                oIngresoViejo.IdIngreso = id;
                oIngresoViejo.Detalle = Detalle;
                db.SaveChanges();
            }
            else
            {
                return null;
            }
            db.Ingresos.First(a => a.IdIngreso == id);  
            return oIngresoViejo;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="db"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public Ingreso eliminarIngreso(FinanzasPersonalesContext db, int id)
        {
            Ingreso? oIngresoViejo = db.Ingresos.Find(id);
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
