using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class PerfileBC
    {
        /// <summary>
        ///  Este metodo Agrega un perfil 
        /// </summary>
        /// <param name="db"></param>
        /// <param name="operfile"></param>
        /// <returns>devuelve un json del perfil </returns>
        public Perfile agregarPerfile(FinanzasPersonalesContext db, Perfile operfile)
        {
            db.Perfiles.Add(operfile);
            db.SaveChanges();
            return operfile;
        }

        /// <summary>
        /// Este metodo obtiene un perfil por id
        /// </summary>
        /// <param name="db"></param>
        /// <param name="id"></param>
        /// <returns>devuelve un json de perfil por su id</returns>
        public Perfile? obtenerPerfile(FinanzasPersonalesContext db, int id)
        {
            return db.Perfiles.FirstOrDefault(a => a.IdPerfil == id);
        }

        /// <summary>
        /// Este metodo actualiza un perfil 
        /// </summary>
        /// <param name="db"></param>
        /// <param name="id"></param>
        /// <param name="Usuario"></param>
        /// <param name="Contraseña"></param>
        /// <returns>devuelve un json con los datos del perfil actualizados</returns>
        public Perfile modificarPerfile(FinanzasPersonalesContext db, int id, string Usuario, string Contraseña)
        {
            Perfile? operfilViejo = db.Perfiles.FirstOrDefault(a => a.IdPerfil== id);
            operfilViejo.Usuario = Usuario;
            operfilViejo.Contraseña = Contraseña;
            db.SaveChanges();
            return operfilViejo;
        }
        public Perfile eliminarPerfile(FinanzasPersonalesContext db, int id)
        {
            Perfile? operfilViejo = db.Perfiles.Find(id);
            db.Remove(operfilViejo);
            db.SaveChanges();
            return operfilViejo;
        }
    }
}
