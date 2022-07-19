namespace cafeEsoterico.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Empleado")]
    public partial class Empleado
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Empleado()
        {
            Compra = new HashSet<Compra>();
        }

        [Key]
        public int id_empleado { get; set; }

        [Required]
        [StringLength(50)]
        public string nombre { get; set; }

        [Required]
        [StringLength(50)]
        public string ap_paterno { get; set; }

        [Required]
        [StringLength(50)]
        public string ap_materno { get; set; }

        [Column(TypeName = "date")]
        public DateTime fecha_nacimmiento { get; set; }

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
        [StringLength(10)]
        public string telefono { get; set; }

        public int estatus { get; set; }

        public int id_usuario { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Compra> Compra { get; set; }

        public virtual Usuario Usuario { get; set; }
    }
}
