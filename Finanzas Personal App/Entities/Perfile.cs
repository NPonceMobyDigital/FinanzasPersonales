using System;
using System.Collections.Generic;

namespace Entities
{
    public partial class Perfile
    {
        public int IdPerfil { get; set; }
        public string Nombre { get; set; } = null!;
        public int? IdSaldo { get; set; }
        public int? IdIngreso { get; set; }
        public int? IdIngresoFuturo { get; set; }
        public int? IdEgreso { get; set; }
        public int? IdEgresoFuturo { get; set; }
        public DateTime FechaAlta { get; set; }
        public DateTime? FechaBaja { get; set; }
        public int? IdSaldoFuturo { get; set; }
        public string Usuario { get; set; } = null!;
        public string Contraseña { get; set; } = null!;

        public virtual EgresosFuturo? IdEgresoFuturoNavigation { get; set; }
        public virtual Egreso? IdEgresoNavigation { get; set; }
        public virtual IngresosFuturo? IdIngresoFuturoNavigation { get; set; }
        public virtual Ingreso? IdIngresoNavigation { get; set; }
        public virtual SaldosFuturo? IdSaldoFuturoNavigation { get; set; }
        public virtual Saldo? IdSaldoNavigation { get; set; }
    }
}
