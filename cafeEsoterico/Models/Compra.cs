namespace cafeEsoterico.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Compra")]
    public partial class Compra
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Compra()
        {
            Detalle_compra = new HashSet<Detalle_compra>();
        }

        [Key]
        public int id_compra { get; set; }

        public DateTime fecha_compra { get; set; }

        public int id_proveedor { get; set; }

        public int id_empleado { get; set; }

        public double total { get; set; }

        public virtual Empleado Empleado { get; set; }

        public virtual Proveedor Proveedor { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Detalle_compra> Detalle_compra { get; set; }
    }
}
