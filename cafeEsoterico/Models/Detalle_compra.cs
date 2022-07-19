namespace cafeEsoterico.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Detalle_compra
    {
        [Key]
        public int cantidad { get; set; }

        public int id_materia_prima { get; set; }

        public int id_compra { get; set; }

        public double precio_unitario { get; set; }

        public double total { get; set; }

        public virtual Compra Compra { get; set; }

        public virtual Materia_prima Materia_prima { get; set; }
    }
}
