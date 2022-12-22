using System;
using System.Collections.Generic;

namespace Entities
{
    public partial class IngresosFuturo
    {
        public IngresosFuturo()
        {
            Perfiles = new HashSet<Perfile>();
        }

        public int IdIngresosFuturos { get; set; }
        public int Monto { get; set; }
        public string Detalle { get; set; } = null!;
        public DateTime FechaAlta { get; set; }
        public DateTime? FechaBaja { get; set; }
        public DateTime FechaEjecucion { get; set; }

        public virtual ICollection<Perfile> Perfiles { get; set; }
    }
}
