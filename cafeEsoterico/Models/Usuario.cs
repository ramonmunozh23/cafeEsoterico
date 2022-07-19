namespace cafeEsoterico.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Usuario")]
    public partial class Usuario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Usuario()
        {
            Cliente = new HashSet<Cliente>();
            Empleado = new HashSet<Empleado>();
        }

        [Key]
        public int id_usuario { get; set; }

        public int estatus { get; set; }

        [Required]
        [StringLength(50)]
        public string correo { get; set; }

        [Required]
        [StringLength(50)]
        public string contrasena { get; set; }

        public int id_rol { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cliente> Cliente { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Empleado> Empleado { get; set; }

        public virtual Rol Rol { get; set; }
    }
}
