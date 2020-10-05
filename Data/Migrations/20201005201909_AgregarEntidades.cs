using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Lavadero.Data.Migrations
{
    public partial class AgregarEntidades : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    nombreCliente = table.Column<string>(nullable: true),
                    telefonoCliente = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ConceptoPago",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    nombreConceptoPago = table.Column<string>(nullable: true),
                    descripcionConceptoPago = table.Column<string>(nullable: true),
                    fechaBajaConceptoPago = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConceptoPago", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrdenServicioEstado",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    nombreOrdenServicioEstado = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdenServicioEstado", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PlayaEstado",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    nombrePlayaEstado = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayaEstado", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoEmpleado",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    nombreTipoEmpleado = table.Column<string>(nullable: true),
                    descripcionTipoEmpleado = table.Column<string>(nullable: true),
                    fechaBajaTipoEmpleado = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoEmpleado", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoPertenencia",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    nombreTipoPertenencia = table.Column<string>(nullable: true),
                    descripcionTipoPertenencia = table.Column<string>(nullable: true),
                    fechaBajaTipoPertenencia = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoPertenencia", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoServicio",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    nombreTipoServicio = table.Column<string>(nullable: true),
                    descripcionTipoServicio = table.Column<string>(nullable: true),
                    fechaBajaTipoServicio = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoServicio", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoVehiculo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    nombreTipoVehiculo = table.Column<string>(nullable: true),
                    descripcionTipoVehiculo = table.Column<string>(nullable: true),
                    fechaBajaTipoVehiculo = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoVehiculo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Reclamo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    observacion = table.Column<string>(nullable: true),
                    ClienteId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reclamo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reclamo_Cliente_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Cliente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Playa",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    nombrePlaya = table.Column<string>(nullable: true),
                    ubicacionPlaya = table.Column<string>(nullable: true),
                    estadoPlaya = table.Column<string>(nullable: true),
                    playaEstadoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Playa", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Playa_PlayaEstado_playaEstadoId",
                        column: x => x.playaEstadoId,
                        principalTable: "PlayaEstado",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Servicio",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    nombreServicio = table.Column<string>(nullable: true),
                    descripcionServicio = table.Column<string>(nullable: true),
                    fechaBajaServicio = table.Column<DateTime>(nullable: false),
                    tipoServicioId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servicio", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Servicio_TipoServicio_tipoServicioId",
                        column: x => x.tipoServicioId,
                        principalTable: "TipoServicio",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MovimientoCaja",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    tipoMovimientoCaja = table.Column<int>(nullable: false),
                    fechaHoraMovimientoCaja = table.Column<DateTime>(nullable: false),
                    PlayaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovimientoCaja", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MovimientoCaja_Playa_PlayaId",
                        column: x => x.PlayaId,
                        principalTable: "Playa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Vehiculo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    patenteVehiculo = table.Column<string>(nullable: true),
                    modeloVehiculo = table.Column<string>(nullable: true),
                    marcaVehiculo = table.Column<string>(nullable: true),
                    colorVehiculo = table.Column<string>(nullable: true),
                    clienteId = table.Column<int>(nullable: true),
                    tipoVehiculoId = table.Column<int>(nullable: true),
                    playaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehiculo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vehiculo_Cliente_clienteId",
                        column: x => x.clienteId,
                        principalTable: "Cliente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Vehiculo_Playa_playaId",
                        column: x => x.playaId,
                        principalTable: "Playa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Vehiculo_TipoVehiculo_tipoVehiculoId",
                        column: x => x.tipoVehiculoId,
                        principalTable: "TipoVehiculo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Empleado",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    nombreEmpleado = table.Column<string>(nullable: true),
                    dniEmpleado = table.Column<int>(nullable: false),
                    fechaBaja = table.Column<DateTime>(nullable: true),
                    tipoEmpleadoId = table.Column<int>(nullable: true),
                    ServicioId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empleado", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Empleado_Servicio_ServicioId",
                        column: x => x.ServicioId,
                        principalTable: "Servicio",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Empleado_TipoEmpleado_tipoEmpleadoId",
                        column: x => x.tipoEmpleadoId,
                        principalTable: "TipoEmpleado",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrdenServicio",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    fechaHoraIngreso = table.Column<DateTime>(nullable: false),
                    fechaHoraEgreso = table.Column<DateTime>(nullable: false),
                    vehiculoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdenServicio", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrdenServicio_Vehiculo_vehiculoId",
                        column: x => x.vehiculoId,
                        principalTable: "Vehiculo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Pertenencia",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    nombrePertenencia = table.Column<string>(nullable: true),
                    descripcionPertenencia = table.Column<string>(nullable: true),
                    tipoPertenenciaId = table.Column<int>(nullable: true),
                    VehiculoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pertenencia", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pertenencia_Vehiculo_VehiculoId",
                        column: x => x.VehiculoId,
                        principalTable: "Vehiculo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pertenencia_TipoPertenencia_tipoPertenenciaId",
                        column: x => x.tipoPertenenciaId,
                        principalTable: "TipoPertenencia",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EmpleadoConceptoPago",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    fechaHoraInicioEmpleadoConceptoPago = table.Column<DateTime>(nullable: false),
                    fechaHoraFinEmpleadoConceptoPago = table.Column<DateTime>(nullable: false),
                    conceptoPagoId = table.Column<int>(nullable: true),
                    EmpleadoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmpleadoConceptoPago", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmpleadoConceptoPago_Empleado_EmpleadoId",
                        column: x => x.EmpleadoId,
                        principalTable: "Empleado",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EmpleadoConceptoPago_ConceptoPago_conceptoPagoId",
                        column: x => x.conceptoPagoId,
                        principalTable: "ConceptoPago",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PlayaEmpleado",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    fechaHoraInicioPlayaEmpleado = table.Column<DateTime>(nullable: false),
                    fechaHoraFinPlayaEmpleado = table.Column<DateTime>(nullable: false),
                    playaId = table.Column<int>(nullable: true),
                    EmpleadoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayaEmpleado", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlayaEmpleado_Empleado_EmpleadoId",
                        column: x => x.EmpleadoId,
                        principalTable: "Empleado",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PlayaEmpleado_Playa_playaId",
                        column: x => x.playaId,
                        principalTable: "Playa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EstadoOrdenServicio",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    fechaHoraInicioEstadoOrdenServicio = table.Column<DateTime>(nullable: false),
                    fechaHoraFinEstadoOrdenServicio = table.Column<DateTime>(nullable: false),
                    ordenServicioEstadoId = table.Column<int>(nullable: true),
                    OrdenServicioId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadoOrdenServicio", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EstadoOrdenServicio_OrdenServicio_OrdenServicioId",
                        column: x => x.OrdenServicioId,
                        principalTable: "OrdenServicio",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EstadoOrdenServicio_OrdenServicioEstado_ordenServicioEstadoId",
                        column: x => x.ordenServicioEstadoId,
                        principalTable: "OrdenServicioEstado",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrdenServicioServicio",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    servicioId = table.Column<int>(nullable: true),
                    OrdenServicioId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdenServicioServicio", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrdenServicioServicio_OrdenServicio_OrdenServicioId",
                        column: x => x.OrdenServicioId,
                        principalTable: "OrdenServicio",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrdenServicioServicio_Servicio_servicioId",
                        column: x => x.servicioId,
                        principalTable: "Servicio",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "OrdenServicioEstado",
                columns: new[] { "Id", "nombreOrdenServicioEstado" },
                values: new object[,]
                {
                    { 1, "EnProceso" },
                    { 2, "Ejecutada" },
                    { 3, "Cancelada" }
                });

            migrationBuilder.InsertData(
                table: "PlayaEstado",
                columns: new[] { "Id", "nombrePlayaEstado" },
                values: new object[,]
                {
                    { 1, "Abierta" },
                    { 2, "Cerrada" },
                    { 3, "Cerrada" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Empleado_ServicioId",
                table: "Empleado",
                column: "ServicioId");

            migrationBuilder.CreateIndex(
                name: "IX_Empleado_tipoEmpleadoId",
                table: "Empleado",
                column: "tipoEmpleadoId");

            migrationBuilder.CreateIndex(
                name: "IX_EmpleadoConceptoPago_EmpleadoId",
                table: "EmpleadoConceptoPago",
                column: "EmpleadoId");

            migrationBuilder.CreateIndex(
                name: "IX_EmpleadoConceptoPago_conceptoPagoId",
                table: "EmpleadoConceptoPago",
                column: "conceptoPagoId");

            migrationBuilder.CreateIndex(
                name: "IX_EstadoOrdenServicio_OrdenServicioId",
                table: "EstadoOrdenServicio",
                column: "OrdenServicioId");

            migrationBuilder.CreateIndex(
                name: "IX_EstadoOrdenServicio_ordenServicioEstadoId",
                table: "EstadoOrdenServicio",
                column: "ordenServicioEstadoId");

            migrationBuilder.CreateIndex(
                name: "IX_MovimientoCaja_PlayaId",
                table: "MovimientoCaja",
                column: "PlayaId");

            migrationBuilder.CreateIndex(
                name: "IX_OrdenServicio_vehiculoId",
                table: "OrdenServicio",
                column: "vehiculoId");

            migrationBuilder.CreateIndex(
                name: "IX_OrdenServicioServicio_OrdenServicioId",
                table: "OrdenServicioServicio",
                column: "OrdenServicioId");

            migrationBuilder.CreateIndex(
                name: "IX_OrdenServicioServicio_servicioId",
                table: "OrdenServicioServicio",
                column: "servicioId");

            migrationBuilder.CreateIndex(
                name: "IX_Pertenencia_VehiculoId",
                table: "Pertenencia",
                column: "VehiculoId");

            migrationBuilder.CreateIndex(
                name: "IX_Pertenencia_tipoPertenenciaId",
                table: "Pertenencia",
                column: "tipoPertenenciaId");

            migrationBuilder.CreateIndex(
                name: "IX_Playa_playaEstadoId",
                table: "Playa",
                column: "playaEstadoId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayaEmpleado_EmpleadoId",
                table: "PlayaEmpleado",
                column: "EmpleadoId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayaEmpleado_playaId",
                table: "PlayaEmpleado",
                column: "playaId");

            migrationBuilder.CreateIndex(
                name: "IX_Reclamo_ClienteId",
                table: "Reclamo",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Servicio_tipoServicioId",
                table: "Servicio",
                column: "tipoServicioId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculo_clienteId",
                table: "Vehiculo",
                column: "clienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculo_playaId",
                table: "Vehiculo",
                column: "playaId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculo_tipoVehiculoId",
                table: "Vehiculo",
                column: "tipoVehiculoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmpleadoConceptoPago");

            migrationBuilder.DropTable(
                name: "EstadoOrdenServicio");

            migrationBuilder.DropTable(
                name: "MovimientoCaja");

            migrationBuilder.DropTable(
                name: "OrdenServicioServicio");

            migrationBuilder.DropTable(
                name: "Pertenencia");

            migrationBuilder.DropTable(
                name: "PlayaEmpleado");

            migrationBuilder.DropTable(
                name: "Reclamo");

            migrationBuilder.DropTable(
                name: "ConceptoPago");

            migrationBuilder.DropTable(
                name: "OrdenServicioEstado");

            migrationBuilder.DropTable(
                name: "OrdenServicio");

            migrationBuilder.DropTable(
                name: "TipoPertenencia");

            migrationBuilder.DropTable(
                name: "Empleado");

            migrationBuilder.DropTable(
                name: "Vehiculo");

            migrationBuilder.DropTable(
                name: "Servicio");

            migrationBuilder.DropTable(
                name: "TipoEmpleado");

            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Playa");

            migrationBuilder.DropTable(
                name: "TipoVehiculo");

            migrationBuilder.DropTable(
                name: "TipoServicio");

            migrationBuilder.DropTable(
                name: "PlayaEstado");
        }
    }
}
