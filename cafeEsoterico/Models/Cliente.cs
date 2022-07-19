namespace cafeEsoterico.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Cliente")]
    public partial class Cliente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cliente()
        {
            Venta = new HashSet<Venta>();
        }

        [Key]
        public int id_cliente { get; set; }

        [Required]
        [StringLength(50)]
        public string nombre { get; set; }

        [Required]
        [StringLength(50)]
        public string ap_paterno { get; set; }

        [Required]
        [StringLength(50)]
        public string ap_materno { get; set; }

        [Required]
        [StringLength(10)]
        public string telefono { get; set; }

        public int estatus { get; set; }

        public int id_usuario { get; set; }

        public virtual Usuario Usuario { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Venta> Venta { get; set; }
    }
}
