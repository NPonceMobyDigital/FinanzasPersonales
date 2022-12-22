using System;
using System.Collections.Generic;

namespace Entities
{
    public partial class SaldosFuturo
    {
        public SaldosFuturo()
        {
            Perfiles = new HashSet<Perfile>();
        }

        public int IdMontoFuturo { get; set; }
        public int Monto { get; set; }
        public string Descripcion { get; set; } = null!;
        public DateTime FechaDeAlta { get; set; }
        public DateTime? FechaDeBaja { get; set; }
        public string FechaDeConcrecion { get; set; } = null!;

        public virtual ICollection<Perfile> Perfiles { get; set; }
    }
}
