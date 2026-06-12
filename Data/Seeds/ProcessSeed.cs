using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using AppServiceAndTravel.Areas.Admin.Models;

namespace AppServiceAndTravel.Data.Seeds
{
    public class procesoSeed : IEntityTypeConfiguration<Procesos>
    {
        public void Configure(EntityTypeBuilder<Procesos> builder)
        {
            builder.HasData(

                // nivel 1 Seguridad
                new Procesos() {idProceso = 1,orden = 7,url = null,proceso = "Seguridad",area = null,controlador = null,icono = "fa-user-shield"},            
                new Procesos() {idProceso = 2,orden = 7,url = "ConfiguracionGeneral",proceso = "Configuracion General",area = "Admin",controlador = "App",icono = null,idProcesoPadre = 1},
                new Procesos() {idProceso = 3,orden = 7,url = "Usuarios",proceso = "Usuarios",area = "Admin",controlador = "App",icono = null,idProcesoPadre = 1},
                new Procesos() {idProceso = 4,orden = 7,url = "Roles",proceso = "Roles",area = "Admin",controlador = "App",icono = null,idProcesoPadre = 1},
                new Procesos() {idProceso = 5,orden = 7,url = "Permisos",proceso = "Permisos",area = "Admin",controlador = "App",icono = null,idProcesoPadre = 1},
                // nivel 1 Proveedores
                new Procesos() {idProceso = 6,orden = 6,url = null,proceso = "Proveedores",area = null,controlador = null,icono = "fa-users-rectangle"},
                new Procesos() {idProceso = 7,orden = 6,url = "Proveedores",proceso = "Listado de Proveedores",area = "Admin",controlador = "App",icono = null,idProcesoPadre = 6},
                new Procesos() {idProceso = 8,orden = 6,url = "CrearProveedor",proceso = "Nuevo Proveedor",area = "Admin",controlador = "App",icono = null,idProcesoPadre = 6},
                // nivel 1 Conductores
                new Procesos() {idProceso = 9,orden = 4,url = null,proceso = "Conductores",area = null,controlador = null,icono = "fa-address-card"},
                new Procesos() {idProceso = 10,orden = 4,url = "Conductores",proceso = "Listado de Conductores",area = "Operaciones",controlador = "App",icono = null,idProcesoPadre = 9},
                new Procesos() {idProceso = 11,orden = 4,url = "CrearConductor",proceso = "Nuevo Conductor",area = "Operaciones",controlador = "App",icono = null,idProcesoPadre = 9},
                new Procesos() {idProceso = 12,orden = 4,url = "ConductoresAliados",proceso = "Listado de Conductores Aliados",area = "Operaciones",controlador = "App",icono = null,idProcesoPadre = 9},
                new Procesos() {idProceso = 13,orden = 4,url = "CrearConductorAliado",proceso = "Nuevo Conductor Aliado",area = "Operaciones",controlador = "App",icono = null,idProcesoPadre = 9},
                // nivel 1 Vehiculos
                new Procesos() {idProceso = 14,orden = 5,url = null,proceso = "Vehiculos",area = null,controlador = null,icono = "fa-car"},
                new Procesos() {idProceso = 15,orden = 5,url = "Vehiculos",proceso = "Listado de Vehiculos",area = "Operaciones",controlador = "App",icono = null,idProcesoPadre = 14},
                new Procesos() {idProceso = 16,orden = 5,url = "CrearVehiculo",proceso = "Nuevo Vehiculo",area = "Operaciones",controlador = "App",icono = null,idProcesoPadre = 14},
                new Procesos() {idProceso = 17,orden = 5,url = "VehiculosAliados",proceso = "Listado de Vehiculos Aliados",area = "Operaciones",controlador = "App",icono = null,idProcesoPadre = 14},
                new Procesos() {idProceso = 18,orden = 5,url = "CrearVehiculoAliado",proceso = "Nuevo Vehiculo Aliado",area = "Operaciones",controlador = "App",icono = null,idProcesoPadre = 14},
                // nivel 1 Cotizaciones
                new Procesos() {idProceso = 19,orden = 1,url = null,proceso = "Cotizaciones",area = null,controlador = null,icono = "fa-handshake"},
                new Procesos() {idProceso = 20,orden = 1,url = "Cotizaciones",proceso = "Historial",area = "Comercial",controlador = "App",icono = null,idProcesoPadre = 19},
                new Procesos() {idProceso = 21,orden = 1,url = "CrearCotizacion",proceso = "Nueva Cotización",area = "Comercial",controlador = "App",icono = null,idProcesoPadre = 19},
                // nivel 1 Clientes
                new Procesos() {idProceso = 22,orden = 2,url = null,proceso = "Clientes",area = null,controlador = null,icono = "fa-handshake"},
                new Procesos() {idProceso = 23,orden = 2,url = "Clientes",proceso = "Listado de Clientes",area = "Comercial",controlador = "App",icono = null,idProcesoPadre = 22},
                new Procesos() {idProceso = 24,orden = 2,url = "CrearCliente",proceso = "Nuevo Cliente",area = "Comercial",controlador = "App",icono = null,idProcesoPadre = 22},
                // nivel 1 Servicios
                new Procesos() {idProceso = 25,orden = 3,url = null,proceso = "Servicios",area = null,controlador = null,icono = "fa-car-side"},
                new Procesos() {idProceso = 26,orden = 3,url = "Servicios",proceso = "Historial",area = "Operaciones",controlador = "App",icono = null,idProcesoPadre = 25},
                new Procesos() {idProceso = 27,orden = 3,url = "CrearServicio",proceso = "Nuevo Servicio",area = "Operaciones",controlador = "App",icono = null,idProcesoPadre = 25},              
                new Procesos() {idProceso = 28,orden = 3,url = "TipoServicios",proceso = "Tipo Servicios",area = "Operaciones",controlador = "App",icono = null,idProcesoPadre = 25},
                //nivel 1 Formatos Correos
                new Procesos() {idProceso = 29,orden = 8,url = null,proceso = "Configuracion",area = null,controlador = null,icono = "fa-gear"},
                new Procesos() {idProceso = 30,orden = 8,url = "FormatosCorreos",proceso = "Formatos Correos",area = "Admin",controlador = "App",icono = null,idProcesoPadre = 29},
                new Procesos() {idProceso = 31,orden = 8,url = "TipoCotizaciones",proceso = "Tipo Cotizaciónes",area = "Admin",controlador = "App",icono = null,idProcesoPadre = 29}
            );
        }
    }
}
