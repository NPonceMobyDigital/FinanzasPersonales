using System;
using System.Collections.Generic;

namespace Entities
{
    public partial class VistaPerfile
    {
        public int? Saldo { get; set; }
        public int? Ingreso { get; set; }
        public int? IngresoFuturo { get; set; }
        public int? Egreso { get; set; }
        public int? EgresoFuturo { get; set; }
        public int? SaldoFuturo { get; set; }
        public string Nombre { get; set; } = null!;
        public string Usuario { get; set; } = null!;
    }
}
