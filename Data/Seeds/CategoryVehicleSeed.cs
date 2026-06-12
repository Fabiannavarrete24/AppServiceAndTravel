using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using AppServiceAndTravel.Models;
using AppServiceAndTravel.Areas.Operaciones.Models;

namespace AppServiceAndTravel.Data.Seeds
{
    public class CategoryVehicleSeed : IEntityTypeConfiguration<CategoriasVehiculos>
    {
        public void Configure(EntityTypeBuilder<CategoriasVehiculos> builder)
        {
            builder.HasData(

                        new CategoriasVehiculos { idCategoriaVehiculo = 1, descripcion = "Transporte Particular" },
                        new CategoriasVehiculos { idCategoriaVehiculo = 2, descripcion = "Transporte Público Pasajeros" },
                        new CategoriasVehiculos { idCategoriaVehiculo = 3, descripcion = "Transporte de Carga" },
                        new CategoriasVehiculos { idCategoriaVehiculo = 4, descripcion = "Motocicletas" },
                        new CategoriasVehiculos { idCategoriaVehiculo = 5, descripcion = "Remolques y Semirremolques" },
                        new CategoriasVehiculos { idCategoriaVehiculo = 6, descripcion = "Vehículos Especiales" }

            );
        }
    }
}
