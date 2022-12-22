using System;
using System.Collections.Generic;

namespace Entities
{
    public partial class Egreso
    {
        public Egreso()
        {
            Perfiles = new HashSet<Perfile>();
        }

        public int IdEgreso { get; set; }
        public int Monto { get; set; }
        public string Detalle { get; set; } = null!;
        public DateTime FechaDeAlta { get; set; }
        public DateTime? FechaDeBaja { get; set; }

        public virtual ICollection<Perfile> Perfiles { get; set; }
    }
}
