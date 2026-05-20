using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using AppServiceAndTravel.Models;

namespace AppServiceAndTravel.Data.Seeds
{
    public class RolesSeed : IEntityTypeConfiguration<Roles>
    {
        public void Configure(EntityTypeBuilder<Roles> builder)
        {
            builder.HasData(

                new Roles() { idRol= 1,descripcion= "Administrador" },
                new Roles() { idRol= 2,descripcion= "Usuarios" }
            );
        }
    }
}