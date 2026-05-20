using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using AppServiceAndTravel.Models;

namespace AppServiceAndTravel.Data.Seeds
{
    public class UserSeed : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            builder.HasData(
            
                new ApplicationUser() {idUsuario = 1,userName = "admin",password="admin",admin= true,activo = true,correo = "admin@correo.com" }
            
            );
        }
    }
}
