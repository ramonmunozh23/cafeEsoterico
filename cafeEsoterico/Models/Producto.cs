namespace cafeEsoterico.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Producto")]
    public partial class Producto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Producto()
        {
            Detalle_venta = new HashSet<Detalle_venta>();
            Receta = new HashSet<Receta>();
        }

        [Key]
        public int id_producto { get; set; }

        [Required]
        [StringLength(50)]
        public string nombre_producto { get; set; }

        [Required]
        [StringLength(50)]
        public string descripcion { get; set; }

        public int estatus { get; set; }

        [Required]
        [StringLength(1)]
        public string imagen { get; set; }

        public double precio_unitario { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Detalle_venta> Detalle_venta { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Receta> Receta { get; set; }
    }
}
