namespace cafeEsoterico.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Proveedor")]
    public partial class Proveedor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Proveedor()
        {
            Compra = new HashSet<Compra>();
        }

        [Key]
        public int id_proveedor { get; set; }

        [Required]
        [StringLength(13)]
        public string rfc { get; set; }

        [Required]
        [StringLength(50)]
        public string estado { get; set; }

        [Required]
        [StringLength(50)]
        public string ciudad { get; set; }

        [Required]
        [StringLength(50)]
        public string calle { get; set; }

        [Required]
        [StringLength(50)]
        public string colonia { get; set; }

        [Required]
        [StringLength(10)]
        public string no_exterior { get; set; }

        public int codigo_postal { get; set; }

        [Required]
        [StringLength(50)]
        public string razon_social { get; set; }

        public int telefono { get; set; }

        public int estatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Compra> Compra { get; set; }
    }
}
