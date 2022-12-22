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
        //Crea nuevo Ingreso
        public Ingreso agregarIngreso(FinanzasPersonalesContext db, Ingreso oIngreso)
        {
            db.Ingresos.Add(oIngreso);
            db.SaveChanges();
            return oIngreso;
        }


        //Modifica Ingreso
        //Agregar validacion por Null
        public Ingreso modificarIngreso(FinanzasPersonalesContext db, int id, string Detalle, int Monto)
        {
            Ingreso? oIngresoViejo = db.Ingresos.FirstOrDefault(a => a.IdIngreso == id);
            oIngresoViejo.Detalle = Detalle;
            oIngresoViejo.Monto = Monto;
            db.SaveChanges();
            return oIngresoViejo;
        }

        //Obtiene Ingreso por id

        public Ingreso? obtenerIngreso(FinanzasPersonalesContext db, int id)
        {
            return db.Ingresos.FirstOrDefault(a => a.IdIngreso == id);
        }


    }
}
