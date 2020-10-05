using System;
using System.Collections.Generic;
using System.Text;
using Lavadero.Models.Entidades;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Utiles.Enumeraciones;

namespace Lavadero.Data
{
    public class LavaderoDbContext : IdentityDbContext
    {
        public LavaderoDbContext(DbContextOptions<LavaderoDbContext> options)
            : base(options)
        {
            //this.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }

        protected override void OnModelCreating(ModelBuilder builder)
        { //ver relaciones mucho a muchos
          base.OnModelCreating(builder);

            //builder.Entity<Cliente>(entity =>
            //{
            //    entity.HasKey(c => c.numeroCliente );

            //    entity.Property(c => c.nombreCliente)
            //        .HasColumnName("NombreCliente")                    
            //        .HasMaxLength(100);

            //    entity.Property(c => c.telefonoCliente)
            //        .HasColumnName("TelefonoCliente")
            //        .HasMaxLength(100);            



            //entity.HasOne(d => d.ProvinciaNavigation)
            //    .WithMany(p => p.Departamento)
            //    .HasForeignKey(d => d.ProvinciaID)
            //    .HasConstraintName("FK_Departamento_Provincia");
            //}//);
            #region Many to Manys
            #region Posiciones arancelarias
            //Hacer builder entity de cada entidad
            //builder.Entity<PosicionArancelaria>()
            //       .HasOne(cl => cl.Padre)
            //       .WithMany(c => c.Hijos)
            //       .HasForeignKey(cl => cl.PadreId);
            //#endregion

            //#region Posición arancelaria - Intervención
            //builder.Entity<PosicionArancelariaIntervencion>()
            //            .HasKey(cl => new { cl.PosicionArancelariaId, cl.IntervencionId });
            //builder.Entity<PosicionArancelariaIntervencion>()
            //       .HasOne(cl => cl.PosicionArancelaria)
            //       .WithMany(c => c.PosicionArancelariaIntervenciones)
            //       .HasForeignKey(cl => cl.PosicionArancelariaId);

            //builder.Entity<PosicionArancelariaIntervencion>()
            //       .HasOne(cl => cl.Intervencion)
            //       .WithMany(l => l.PosicionArancelariaIntervenciones)
            //       .HasForeignKey(cl => cl.IntervencionId);

            //builder.Entity<Cliente>().HasKey(x => x.ClienteNumero);
            //builder.Entity<Cliente>().Property(x => x.ClienteNumero).ValueGeneratedNever();
            #endregion
            #endregion

            SeedDatabase(builder);
        }
        private void SeedDatabase(ModelBuilder builder)//semilla base, datos que no son ABMS
        {
            builder.Entity<OrdenServicioEstado>()
                   .HasData(
                        new OrdenServicioEstado() { Id = 1, nombreOrdenServicioEstado = Enumeraciones.OrdenServicioEstado.EnProceso.ToString() },
                        new OrdenServicioEstado() { Id = 2, nombreOrdenServicioEstado = Enumeraciones.OrdenServicioEstado.Ejecutada.ToString() },
                        new OrdenServicioEstado() { Id = 3, nombreOrdenServicioEstado = Enumeraciones.OrdenServicioEstado.Cancelada.ToString() }
                   );
            builder.Entity<PlayaEstado>()
                    .HasData(
                        new PlayaEstado() { Id = 1, nombrePlayaEstado = Enumeraciones.PlayaEstado.Abierta.ToString() },
                        new PlayaEstado() { Id = 2, nombrePlayaEstado = Enumeraciones.PlayaEstado.Cerrada.ToString() },
                        new PlayaEstado() { Id = 3, nombrePlayaEstado = Enumeraciones.PlayaEstado.Cerrada.ToString() }
                    );

        }

        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<ConceptoPago> ConceptoPago { get; set; }
        public virtual DbSet<Empleado> Empleado { get; set; }
        public virtual DbSet<EmpleadoConceptoPago> EmpleadoConceptoPago { get; set; }
        public virtual DbSet<EstadoOrdenServicio> EstadoOrdenServicio { get; set; }
        public virtual DbSet<MovimientoCaja> MovimientoCaja { get; set; }
        public virtual DbSet<OrdenServicio> OrdenServicio { get; set; }
        public virtual DbSet<OrdenServicioEstado> OrdenServicioEstado { get; set; }
        public virtual DbSet<OrdenServicioServicio> OrdenServicioServicio { get; set; }
        public virtual DbSet<Pertenencia> Pertenencia { get; set; }
        public virtual DbSet<Playa> Playa { get; set; }
        public virtual DbSet<PlayaEmpleado> PlayaEmpleado { get; set; }
        public virtual DbSet<Reclamo> Reclamo { get; set; }
        public virtual DbSet<Servicio> Servicio { get; set; }
        public virtual DbSet<TipoEmpleado> TipoEmpleado { get; set; }
        public virtual DbSet<TipoPertenencia> TipoPertenencia { get; set; }
        public virtual DbSet<TipoServicio> TipoServicio { get; set; }
        public virtual DbSet<TipoVehiculo> TipoVehiculo { get; set; }
        public virtual DbSet<Vehiculo> Vehiculo { get; set; }
       
    }
}
