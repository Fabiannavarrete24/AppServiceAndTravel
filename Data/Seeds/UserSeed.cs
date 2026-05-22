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
            
                new ApplicationUser() {idUsuario = 1,userName = "admin",password="admin",nombreCompleto="Administrador",cargo= "Administrador",
                    correo = "admin@correo.com", admin= true,activo = true,crypt=true,hast=true,
                    fechaCreacion=DateTime.UtcNow,fechaCambioClave=DateTime.UtcNow.AddMonths(3),fechaModificacion=DateTime.UtcNow,restaurada=false,confirmada=true }
            
            );
        }
    }
}
