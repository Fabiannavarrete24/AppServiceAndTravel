using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using AppServiceAndTravel.Models;

namespace AppServiceAndTravel.Data.Seeds
{
    public class TypeActitySeed : IEntityTypeConfiguration<TipoActividadSistema>
    {
        public void Configure(EntityTypeBuilder<TipoActividadSistema> builder)
        {
            builder.HasData(
                new TipoActividadSistema() {idTipoActividadSistema = 1, Codigo = "COTIZACION_CREADA",Nombre = "Cotización Creada",Icono = "bi-file-earmark-plus",Color = "primary",Activo = true},
                new TipoActividadSistema(){idTipoActividadSistema = 2, Codigo = "COTIZACION_EDITADA",Nombre = "Cotización Editada",Icono = "bi-pencil-square",Color = "warning",Activo = true},
                new TipoActividadSistema(){idTipoActividadSistema = 3, Codigo = "COTIZACION_APROBADA",Nombre = "Cotización Aprobada",Icono = "bi-check-circle",Color = "success",Activo = true},
                new TipoActividadSistema(){idTipoActividadSistema = 4, Codigo = "COTIZACION_RECHAZADA",Nombre = "Cotización Rechazada",Icono = "bi-x-circle",Color = "danger",Activo = true},
                new TipoActividadSistema(){idTipoActividadSistema = 5, Codigo = "COTIZACION_CANCELADA",Nombre = "Cotización Cancelada",Icono = "bi-slash-circle",Color = "secondary",Activo = true},
                new TipoActividadSistema(){idTipoActividadSistema = 6, Codigo = "SERVICIO_CREADO",Nombre = "Servicio Creado",Icono = "bi-truck",Color = "primary",Activo = true},
                new TipoActividadSistema(){idTipoActividadSistema = 7, Codigo = "SERVICIO_PROGRAMADO",Nombre = "Servicio Programado",Icono = "bi-calendar-event",Color = "info",Activo = true},
                new TipoActividadSistema(){idTipoActividadSistema = 8, Codigo = "SERVICIO_ASIGNADO",Nombre = "Servicio Asignado",Icono = "bi-person-check",Color = "warning",Activo = true},
                new TipoActividadSistema(){idTipoActividadSistema = 9, Codigo = "SERVICIO_INICIADO",Nombre = "Servicio Iniciado",Icono = "bi-play-circle",Color = "primary",Activo = true},
                new TipoActividadSistema(){idTipoActividadSistema = 10, Codigo = "SERVICIO_EN_CURSO",Nombre = "Servicio En Curso",Icono = "bi-arrow-repeat",Color = "warning",Activo = true},
                new TipoActividadSistema(){idTipoActividadSistema = 11, Codigo = "SERVICIO_FINALIZADO",Nombre = "Servicio Finalizado",Icono = "bi-check2-all",Color = "success",Activo = true},
                new TipoActividadSistema(){idTipoActividadSistema = 12, Codigo = "SERVICIO_CANCELADO",Nombre = "Servicio Cancelado",Icono = "bi-x-octagon",Color = "danger",Activo = true},
                new TipoActividadSistema(){idTipoActividadSistema = 13, Codigo = "VEHICULO_ASIGNADO",Nombre = "Vehículo Asignado",Icono = "bi-truck-flatbed",Color = "info",Activo = true},
                new TipoActividadSistema(){idTipoActividadSistema = 14, Codigo = "VEHICULO_LIBERADO",Nombre = "Vehículo Liberado",Icono = "bi-truck",Color = "secondary",Activo = true},
                new TipoActividadSistema(){idTipoActividadSistema = 15, Codigo = "CONDUCTOR_ASIGNADO",Nombre = "Conductor Asignado",Icono = "bi-person-badge",Color = "primary",Activo = true},
                new TipoActividadSistema(){idTipoActividadSistema = 16, Codigo = "CONDUCTOR_LIBERADO",Nombre = "Conductor Liberado",Icono = "bi-person-dash",Color = "secondary",Activo = true},
                new TipoActividadSistema(){idTipoActividadSistema = 17, Codigo = "USUARIO_CREADO",Nombre = "Usuario Creado",Icono = "bi-person-plus",Color = "success",Activo = true},
                new TipoActividadSistema(){idTipoActividadSistema = 18, Codigo = "USUARIO_ACTUALIZADO",Nombre = "Usuario Actualizado",Icono = "bi-person-gear",Color = "warning",Activo = true},
                new TipoActividadSistema(){idTipoActividadSistema = 19, Codigo = "USUARIO_DESACTIVADO",Nombre = "Usuario Desactivado",Icono = "bi-person-x",Color = "danger",Activo = true},
                new TipoActividadSistema(){idTipoActividadSistema = 20, Codigo = "LOGIN",Nombre = "Inicio de Sesión",Icono = "bi-box-arrow-in-right",Color = "success",Activo = true},
                new TipoActividadSistema(){idTipoActividadSistema = 21, Codigo = "LOGOUT",Nombre = "Cierre de Sesión",Icono = "bi-box-arrow-right",Color = "secondary",Activo = true},
                new TipoActividadSistema(){idTipoActividadSistema = 22, Codigo = "DOCUMENTO_SUBIDO",Nombre = "Documento Subido",Icono = "bi-upload",Color = "primary",Activo = true},
                new TipoActividadSistema(){idTipoActividadSistema = 23, Codigo = "PDF_GENERADO",Nombre = "PDF Generado",Icono = "bi-file-earmark-pdf",Color = "danger",Activo = true},
                new TipoActividadSistema(){idTipoActividadSistema = 24, Codigo = "WHATSAPP_ENVIADO",Nombre = "WhatsApp Enviado",Icono = "bi-whatsapp",Color = "success",Activo = true},
                new TipoActividadSistema(){idTipoActividadSistema = 25, Codigo = "EMAIL_ENVIADO",Nombre = "Correo Enviado",Icono = "bi-envelope",Color = "info",Activo = true}
            );
        }
    }
}