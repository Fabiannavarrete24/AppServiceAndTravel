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

                new Procesos() {IdProceso = 1,url = null,proceso = "Configuracion",area = null,controlador = null,icono = "fa-gear"},
                new Procesos() {IdProceso = 2,url = null,proceso = "Productos",area = null,controlador = null,icono = "fa-shop"},
                new Procesos() {IdProceso = 3,url = null,proceso = "Usuarios",area = null,controlador = null,icono = "fa-user",idParentproceso = 1},
                new Procesos() {IdProceso = 4,url = "AdminManagement",proceso = "Users",area = "Admin",controlador = "App",icono = null,idParentproceso = 3},
                new Procesos() {IdProceso = 5,url = "Appearance",proceso = "Apariencia",area = "Admin",controlador = "App",icono = null,idParentproceso = 1},
                new Procesos() {IdProceso = 6,url = "DatabaseConnections",proceso = "Base de datos",area = "Admin",controlador = "App",icono = null,idParentproceso = 1},
                new Procesos() {IdProceso = 7,url = "ProductsManagement",proceso = "Gestion de productos",area = "Admin",controlador = "App",icono = null,idParentproceso = 2},
                new Procesos() {IdProceso = 8,url = "RolPermissions",proceso = "notification",area = "Admin",controlador = "App",icono = null,idParentproceso = 3},
                new Procesos() {IdProceso = 9,url = "SupplierManagement",proceso = "Provedores",area = "Admin",controlador = "App",icono = null,idParentproceso = 1},
                new Procesos() {IdProceso = 10,url = "SystemConfiguration",proceso = "Sistema",area = "Admin",controlador = "App",icono = null,idParentproceso = 1},
                new Procesos() {IdProceso = 11,url = "Ventas",proceso = "Ventas",area = null,controlador = null,icono = "fa-store"},
                new Procesos() {IdProceso = 12,url = "Dasboard",proceso = "Dasboard",area = null,controlador = "App",icono = null},
                new Procesos() {IdProceso = 13,url = "Sales",proceso = "Venta",area = null,controlador = "App",icono = "fa-cart-shopping",idParentproceso = 11},
                new Procesos() {IdProceso = 14,url = "Products",proceso = "Productos",area = null,controlador = "App",icono = "fa-shop"},
                new Procesos() {IdProceso = 15,url = "ProductsManagement",proceso = "Gestion de Productos",area = null,controlador = "App",icono = null,idParentproceso = 14},
                new Procesos() {IdProceso = 16,url = "Orders",proceso = "Pedidos",area = null,controlador = "App",icono = null,idParentproceso = 14},
                new Procesos() {IdProceso = 17,url = "OrdersManagement",proceso = "Gestion de Pedidos",area = null,controlador = "App",icono = null,idParentproceso = 14}

            );
        }
    }
}
