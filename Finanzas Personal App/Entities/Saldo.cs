using System;
using System.Collections.Generic;

namespace Entities
{
    public partial class Saldo
    {
        public Saldo()
        {
            Perfiles = new HashSet<Perfile>();
        }

        public int IdSaldo { get; set; }
        public int Monto { get; set; }
        public DateTime FechaAlta { get; set; }
        public DateTime? FechaBaja { get; set; }

        public virtual ICollection<Perfile> Perfiles { get; set; }
    }
}
