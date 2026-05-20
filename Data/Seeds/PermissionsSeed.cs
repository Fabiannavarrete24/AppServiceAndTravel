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

                new Permisos() { IdProceso = 1, idRol = 1, lectura = true, edita = true, elimina = true },
                new Permisos() { IdProceso = 2, idRol = 1, lectura = true, edita = true, elimina = true },
                new Permisos() { IdProceso = 3, idRol = 1, lectura = true, edita = true, elimina = true },
                new Permisos() { IdProceso = 4, idRol = 1, lectura = true, edita = true, elimina = true },
                new Permisos() { IdProceso = 5, idRol = 1, lectura = true, edita = true, elimina = true },
                new Permisos() { IdProceso = 6, idRol = 1, lectura = true, edita = true, elimina = true },
                new Permisos() { IdProceso = 7, idRol = 1, lectura = true, edita = true, elimina = true },
                new Permisos() { IdProceso = 8, idRol = 1, lectura = true, edita = true, elimina = true },
                new Permisos() { IdProceso = 9, idRol = 1, lectura = true, edita = true, elimina = true },
                new Permisos() { IdProceso = 10, idRol = 1, lectura = true, edita = true, elimina = true },
                new Permisos() { IdProceso = 11, idRol = 1, lectura = true, edita = true, elimina = true },
                new Permisos() { IdProceso = 12, idRol = 1, lectura = true, edita = true, elimina = true },
                new Permisos() { IdProceso = 13, idRol = 1, lectura = true, edita = true, elimina = true },
                new Permisos() { IdProceso = 14, idRol = 1, lectura = true, edita = true, elimina = true },
                new Permisos() { IdProceso = 15, idRol = 1, lectura = true, edita = true, elimina = true },
                new Permisos() { IdProceso = 16, idRol = 1, lectura = true, edita = true, elimina = true },
                new Permisos() { IdProceso = 17, idRol = 1, lectura = true, edita = true, elimina = true },
                new Permisos() { IdProceso = 18, idRol = 1, lectura = true, edita = true, elimina = true },
                new Permisos() { IdProceso = 11, idRol = 2, lectura = true, edita = true, elimina = true },
                new Permisos() { IdProceso = 12, idRol = 2, lectura = true, edita = true, elimina = true },
                new Permisos() { IdProceso = 13, idRol = 2, lectura = true, edita = true, elimina = true },
                new Permisos() { IdProceso = 14, idRol = 2, lectura = true, edita = true, elimina = true },
                new Permisos() { IdProceso = 15, idRol = 2, lectura = true, edita = true, elimina = true },
                new Permisos() { IdProceso = 16, idRol = 2, lectura = true, edita = true, elimina = true },
                new Permisos() { IdProceso = 17, idRol = 2, lectura = true, edita = true, elimina = true },
                new Permisos() { IdProceso = 18, idRol = 2, lectura = true, edita = true, elimina = true }

            );
        }
    }
}
