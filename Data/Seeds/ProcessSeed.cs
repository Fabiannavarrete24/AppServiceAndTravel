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

                // nivel 1 Configuracion
                new Procesos() {idProceso = 1,url = null,proceso = "Seguridad",area = null,controlador = null,icono = "fa-user-shield"},            
                // nivel 2 Seguridad                                
                new Procesos() {idProceso = 2,url = null,proceso = "Configuracion",area = null,controlador = null,icono = "fa-gear",idProcesoPadre = 1},
                new Procesos() {idProceso = 3,url = "ConfiguracionGeneral",proceso = "Configuracion General",area = "Admin",controlador = "App",icono = null,idProcesoPadre = 2},
                new Procesos() {idProceso = 4,url = "Usuarios",proceso = "Usuarios",area = "Admin",controlador = "App",icono = null,idProcesoPadre = 2},
                new Procesos() {idProceso = 5,url = "Roles",proceso = "Roles",area = "Admin",controlador = "App",icono = null,idProcesoPadre = 2},
                new Procesos() {idProceso = 6,url = "Permisos",proceso = "Permisos",area = "Admin",controlador = "App",icono = null,idProcesoPadre = 2},
                // nivel 1 Proveedores
                new Procesos() {idProceso = 7,url = null,proceso = "Proveedores",area = null,controlador = null,icono = "fa-users-rectangle"},
                new Procesos() {idProceso = 8,url = "Proveedores",proceso = "Listado de Proveedores",area = "Admin",controlador = "App",icono = null,idProcesoPadre = 7},
                new Procesos() {idProceso = 9,url = "CrearProveedor",proceso = "Nuevo Proveedor",area = "Admin",controlador = "App",icono = null,idProcesoPadre = 7},
                // nivel 1 Conductores
                new Procesos() {idProceso = 10,url = null,proceso = "Conductores",area = null,controlador = null,icono = "fa-address-card"},
                new Procesos() {idProceso = 11,url = "Conductores",proceso = "Listado de Conductores",area = "Operaciones",controlador = "App",icono = null,idProcesoPadre = 10},
                new Procesos() {idProceso = 12,url = "CrearConductor",proceso = "Nuevo Conductor",area = "Operaciones",controlador = "App",icono = null,idProcesoPadre = 10},
                // nivel 1 Vehiculos
                new Procesos() {idProceso = 13,url = null,proceso = "Vehiculos",area = null,controlador = null,icono = "fa-car"},
                new Procesos() {idProceso = 14,url = "Vehiculos",proceso = "Listado de Vehiculos",area = "Operaciones",controlador = "App",icono = null,idProcesoPadre = 13},
                new Procesos() {idProceso = 15,url = "CrearVehiculo",proceso = "Nuevo Vehiculo",area = "Operaciones",controlador = "App",icono = null,idProcesoPadre = 13},
                // nivel 1 Cotizaciones
                new Procesos() {idProceso = 16,url = null,proceso = "Cotizaciones",area = null,controlador = null,icono = "fa-handshake"},
                new Procesos() {idProceso = 17,url = "Cotizaciones",proceso = "Historial",area = "Comercial",controlador = "App",icono = null,idProcesoPadre = 16},
                new Procesos() {idProceso = 18,url = "CrearCotizacion",proceso = "Nueva Cotización",area = "Comercial",controlador = "App",icono = null,idProcesoPadre = 16},
                // nivel 1 Clientes
                new Procesos() {idProceso = 19,url = null,proceso = "Clientes",area = null,controlador = null,icono = "fa-handshake"},
                new Procesos() {idProceso = 20,url = "Clientes",proceso = "Listado de Clientes",area = "Comercial",controlador = "App",icono = null,idProcesoPadre = 19},
                new Procesos() {idProceso = 21,url = "CrearCliente",proceso = "Nuevo Cliente",area = "Comercial",controlador = "App",icono = null,idProcesoPadre = 19},
                // nivel 1 Servicios
                new Procesos() {idProceso = 22,url = null,proceso = "Servicios",area = null,controlador = null,icono = "fa-car-side"},
                new Procesos() {idProceso = 23,url = "Servicios",proceso = "Historial",area = "Operaciones",controlador = "App",icono = null,idProcesoPadre = 22},
                new Procesos() {idProceso = 24,url = "CrearServicio",proceso = "Nuevo Servicio",area = "Operaciones",controlador = "App",icono = null,idProcesoPadre = 22}                
            );
        }
    }
}
