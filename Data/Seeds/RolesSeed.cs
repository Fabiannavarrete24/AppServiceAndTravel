using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using AppServiceAndTravel.Areas.Admin.Models;

namespace AppServiceAndTravel.Data.Seeds
{
    public class RolesSeed : IEntityTypeConfiguration<Roles>
    {
        public void Configure(EntityTypeBuilder<Roles> builder)
        {
            builder.HasData(

                new Roles() { idRol= 1,nombre = "Administrador" },
                new Roles() { idRol= 2,nombre = "Usuarios" }
            );
        }
    }
}