using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using AppServiceAndTravel.Models;
using AppServiceAndTravel.Areas.Operaciones.Models;

namespace AppServiceAndTravel.Data.Seeds
{
    public class TypeServiceSeed : IEntityTypeConfiguration<TiposServicios>
    {
        public void Configure(EntityTypeBuilder<TiposServicios> builder)
        {
            builder.HasData(
            
                new TiposServicios() {idTipoServicio = 1,descripcion = "Particular", fechaCreacion = DateTime.UtcNow,idUsuarioModifica = 1},
                new TiposServicios() { idTipoServicio = 2, descripcion = "Público", fechaCreacion = DateTime.UtcNow,idUsuarioModifica = 1 },
                new TiposServicios() { idTipoServicio = 3, descripcion = "Oficial", fechaCreacion = DateTime.UtcNow,idUsuarioModifica = 1 },
                new TiposServicios() { idTipoServicio = 4, descripcion = "Diplomático", fechaCreacion = DateTime.UtcNow,idUsuarioModifica = 1 },
                new TiposServicios() { idTipoServicio = 5, descripcion = "Especial", fechaCreacion = DateTime.UtcNow,idUsuarioModifica = 1 }

            );            
        }
    }
}
