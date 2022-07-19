namespace cafeEsoterico.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Materia_prima
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Materia_prima()
        {
            Detalle_compra = new HashSet<Detalle_compra>();
            Receta = new HashSet<Receta>();
        }

        [Key]
        public int id_materia_prima { get; set; }

        [Required]
        [StringLength(50)]
        public string nombre { get; set; }

        [Required]
        [StringLength(10)]
        public string unidad_medida { get; set; }

        public double existencias { get; set; }

        [StringLength(50)]
        public string descripcion { get; set; }

        public int estatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Detalle_compra> Detalle_compra { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Receta> Receta { get; set; }
    }
}
