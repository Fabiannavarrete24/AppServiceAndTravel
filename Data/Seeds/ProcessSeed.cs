using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using AppServiceAndTravel.Models;

namespace AppServiceAndTravel.Data.Seeds
{
    public class procesoSeed : IEntityTypeConfiguration<Procesos>
    {
        public void Configure(EntityTypeBuilder<Procesos> builder)
        {
            builder.HasData(

                new Procesos() {idProceso = 1,url = null,proceso = "Configuracion",area = null,controlador = null,icono = "fa-gear"},
                new Procesos() {idProceso = 2,url = null,proceso = "Productos",area = null,controlador = null,icono = "fa-shop"},
                new Procesos() { idProceso = 3,url = null,proceso = "Usuarios",area = null,controlador = null,icono = "fa-user",idProcesoPadre = 1},
                new Procesos() { idProceso = 4,url = "AdminManagement",proceso = "Users",area = "Admin",controlador = "App",icono = null,idProcesoPadre = 3},
                new Procesos() { idProceso = 5,url = "Appearance",proceso = "Apariencia",area = "Admin",controlador = "App",icono = null,idProcesoPadre = 1},
                new Procesos() {idProceso = 6,url = "DatabaseConnections",proceso = "Base de datos",area = "Admin",controlador = "App",icono = null,idProcesoPadre = 1},
                new Procesos() {idProceso = 7,url = "ProductsManagement",proceso = "Gestion de productos",area = "Admin",controlador = "App",icono = null,idProcesoPadre = 2},
                new Procesos() {idProceso = 8,url = "RolPermissions",proceso = "notification",area = "Admin",controlador = "App",icono = null,idProcesoPadre = 3},
                new Procesos() {idProceso = 9,url = "SupplierManagement",proceso = "Provedores",area = "Admin",controlador = "App",icono = null,idProcesoPadre = 1},
                new Procesos() {idProceso = 10,url = "SystemConfiguration",proceso = "Sistema",area = "Admin",controlador = "App",icono = null,idProcesoPadre = 1},
                new Procesos() {idProceso = 11,url = "Ventas",proceso = "Ventas",area = null,controlador = null,icono = "fa-store"},
                new Procesos() {idProceso = 12,url = "index",proceso = "Dashboard",area = null,controlador = "Home",icono = null},
                new Procesos() {idProceso = 13,url = "Sales",proceso = "Venta",area = null,controlador = "App",icono = "fa-cart-shopping",idProcesoPadre = 11},
                new Procesos() {idProceso = 14,url = "Products",proceso = "Productos",area = null,controlador = "App",icono = "fa-shop"},
                new Procesos() {idProceso = 15,url = "ProductsManagement",proceso = "Gestion de Productos",area = null,controlador = "App",icono = null,idProcesoPadre = 14},
                new Procesos() {idProceso = 16,url = "Orders",proceso = "Pedidos",area = null,controlador = "App",icono = null,idProcesoPadre = 14},
                new Procesos() {idProceso = 17,url = "OrdersManagement",proceso = "Gestion de Pedidos",area = null,controlador = "App",icono = null,idProcesoPadre = 14}

            );
        }
    }
}
