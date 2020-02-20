namespace Matricula.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CajaDiario")]
    public partial class CajaDiario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CajaDiario()
        {
            CajaMovimientoes = new HashSet<CajaMovimiento>();
        }

        public int Id { get; set; }

        public int CajaId { get; set; }

        public int UsuarioId { get; set; }

        public decimal SaldoInicial { get; set; }

        public decimal Entradas { get; set; }

        public decimal Salidas { get; set; }

        public decimal SaldoFinal { get; set; }

        public DateTime FechaInicio { get; set; }

        public DateTime? FechaFin { get; set; }

        public bool IndCierre { get; set; }

        public virtual Caja Caja { get; set; }

        public virtual Usuario Usuario { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CajaMovimiento> CajaMovimientoes { get; set; }
    }
}
