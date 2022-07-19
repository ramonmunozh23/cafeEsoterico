namespace cafeEsoterico.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Receta")]
    public partial class Receta
    {
        [Key]
        [Column(Order = 0)]
        public double cantidad { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_materia_prima { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_producto { get; set; }

        public virtual Materia_prima Materia_prima { get; set; }

        public virtual Producto Producto { get; set; }
    }
}
