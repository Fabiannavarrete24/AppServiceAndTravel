using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using AppServiceAndTravel.Models;

namespace AppServiceAndTravel.Data.Seeds
{
    public class PermissionsSeed : IEntityTypeConfiguration<Permisos>
    {
        public void Configure(EntityTypeBuilder<Permisos> builder)
        {
            builder.HasData(

                new Permisos() { idProceso = 1, idRol = 1, lectura = true, edita = true, elimina = true },
                new Permisos() { idProceso = 2, idRol = 1, lectura = true, edita = true, elimina = true },
                new Permisos() { idProceso = 3, idRol = 1, lectura = true, edita = true, elimina = true },
                new Permisos() { idProceso = 4, idRol = 1, lectura = true, edita = true, elimina = true },
                new Permisos() { idProceso = 5, idRol = 1, lectura = true, edita = true, elimina = true },
                new Permisos() { idProceso = 6, idRol = 1, lectura = true, edita = true, elimina = true },
                new Permisos() { idProceso = 7, idRol = 1, lectura = true, edita = true, elimina = true },
                new Permisos() { idProceso = 8, idRol = 1, lectura = true, edita = true, elimina = true },
                new Permisos() { idProceso = 9, idRol = 1, lectura = true, edita = true, elimina = true },
                new Permisos() { idProceso = 10, idRol = 1, lectura = true, edita = true, elimina = true },
                new Permisos() { idProceso = 11, idRol = 1, lectura = true, edita = true, elimina = true },
                new Permisos() { idProceso = 12, idRol = 1, lectura = true, edita = true, elimina = true },
                new Permisos() { idProceso = 13, idRol = 1, lectura = true, edita = true, elimina = true },
                new Permisos() { idProceso = 14, idRol = 1, lectura = true, edita = true, elimina = true },
                new Permisos() { idProceso = 15, idRol = 1, lectura = true, edita = true, elimina = true },
                new Permisos() { idProceso = 16, idRol = 1, lectura = true, edita = true, elimina = true },
                new Permisos() { idProceso = 17, idRol = 1, lectura = true, edita = true, elimina = true }
            );
        }
    }
}
