using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using AppServiceAndTravel.Models;

namespace AppServiceAndTravel.Data.Seeds
{
    public class RolesUsuariosSeed : IEntityTypeConfiguration<RolesUsuarios>
    {
        public void Configure(EntityTypeBuilder<RolesUsuarios> builder)
        {
            builder.HasData(

                new RolesUsuarios() { idRol = 1, idUsuario = 1 }
            );
        }
    }
}