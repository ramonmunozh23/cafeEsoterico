namespace cafeEsoterico.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Venta")]
    public partial class Venta
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Venta()
        {
            Detalle_venta = new HashSet<Detalle_venta>();
        }

        [Key]
        public int id_venta { get; set; }

        public DateTime fecha_venta { get; set; }

        public double total { get; set; }

        public int id_cliente { get; set; }

        public virtual Cliente Cliente { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Detalle_venta> Detalle_venta { get; set; }
    }
}
