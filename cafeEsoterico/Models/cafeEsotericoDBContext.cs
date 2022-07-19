using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace cafeEsoterico.Models
{
    public partial class cafeEsotericoDBContext : DbContext
    {
        public cafeEsotericoDBContext()
            : base("name=cafeEsotericoDBContext")
        {
        }

        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<Compra> Compra { get; set; }
        public virtual DbSet<Detalle_compra> Detalle_compra { get; set; }
        public virtual DbSet<Empleado> Empleado { get; set; }
        public virtual DbSet<Materia_prima> Materia_prima { get; set; }
        public virtual DbSet<Producto> Producto { get; set; }
        public virtual DbSet<Proveedor> Proveedor { get; set; }
        public virtual DbSet<Rol> Rol { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }
        public virtual DbSet<Venta> Venta { get; set; }
        public virtual DbSet<Detalle_venta> Detalle_venta { get; set; }
        public virtual DbSet<Receta> Receta { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.ap_paterno)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.ap_materno)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.telefono)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .HasMany(e => e.Venta)
                .WithRequired(e => e.Cliente)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Compra>()
                .HasMany(e => e.Detalle_compra)
                .WithRequired(e => e.Compra)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Empleado>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Empleado>()
                .Property(e => e.ap_paterno)
                .IsUnicode(false);

            modelBuilder.Entity<Empleado>()
                .Property(e => e.ap_materno)
                .IsUnicode(false);

            modelBuilder.Entity<Empleado>()
                .Property(e => e.ciudad)
                .IsUnicode(false);

            modelBuilder.Entity<Empleado>()
                .Property(e => e.calle)
                .IsUnicode(false);

            modelBuilder.Entity<Empleado>()
                .Property(e => e.colonia)
                .IsUnicode(false);

            modelBuilder.Entity<Empleado>()
                .Property(e => e.no_exterior)
                .IsUnicode(false);

            modelBuilder.Entity<Empleado>()
                .Property(e => e.telefono)
                .IsUnicode(false);

            modelBuilder.Entity<Empleado>()
                .HasMany(e => e.Compra)
                .WithRequired(e => e.Empleado)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Materia_prima>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Materia_prima>()
                .Property(e => e.unidad_medida)
                .IsUnicode(false);

            modelBuilder.Entity<Materia_prima>()
                .Property(e => e.descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Materia_prima>()
                .HasMany(e => e.Detalle_compra)
                .WithRequired(e => e.Materia_prima)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Materia_prima>()
                .HasMany(e => e.Receta)
                .WithRequired(e => e.Materia_prima)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.nombre_producto)
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.imagen)
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .HasMany(e => e.Detalle_venta)
                .WithRequired(e => e.Producto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Producto>()
                .HasMany(e => e.Receta)
                .WithRequired(e => e.Producto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Proveedor>()
                .Property(e => e.rfc)
                .IsUnicode(false);

            modelBuilder.Entity<Proveedor>()
                .Property(e => e.estado)
                .IsUnicode(false);

            modelBuilder.Entity<Proveedor>()
                .Property(e => e.ciudad)
                .IsUnicode(false);

            modelBuilder.Entity<Proveedor>()
                .Property(e => e.calle)
                .IsUnicode(false);

            modelBuilder.Entity<Proveedor>()
                .Property(e => e.colonia)
                .IsUnicode(false);

            modelBuilder.Entity<Proveedor>()
                .Property(e => e.no_exterior)
                .IsUnicode(false);

            modelBuilder.Entity<Proveedor>()
                .Property(e => e.razon_social)
                .IsUnicode(false);

            modelBuilder.Entity<Proveedor>()
                .HasMany(e => e.Compra)
                .WithRequired(e => e.Proveedor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Rol>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Rol>()
                .Property(e => e.descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Rol>()
                .HasMany(e => e.Usuario)
                .WithRequired(e => e.Rol)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.correo)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.contrasena)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .HasMany(e => e.Cliente)
                .WithRequired(e => e.Usuario)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Usuario>()
                .HasMany(e => e.Empleado)
                .WithRequired(e => e.Usuario)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Venta>()
                .HasMany(e => e.Detalle_venta)
                .WithRequired(e => e.Venta)
                .WillCascadeOnDelete(false);
        }
    }
}
