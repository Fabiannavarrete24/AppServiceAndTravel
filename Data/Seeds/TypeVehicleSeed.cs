using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using AppServiceAndTravel.Models;
using AppServiceAndTravel.Areas.Operaciones.Models;

namespace AppServiceAndTravel.Data.Seeds
{
    public class TypeVehicleSeed : IEntityTypeConfiguration<TiposVehiculos>
    {
        public void Configure(EntityTypeBuilder<TiposVehiculos> builder)
        {
            builder.HasData(
                        new TiposVehiculos {idTipoVehiculo = 1,descripcion = "Automóvil",idCategoriaVehiculo = 1, idUsuarioModifica = 1 },
                        new TiposVehiculos{idTipoVehiculo = 2,descripcion = "Campero",idCategoriaVehiculo = 1, idUsuarioModifica = 1 },
                        new TiposVehiculos{idTipoVehiculo = 3,descripcion = "Camioneta",idCategoriaVehiculo = 1, idUsuarioModifica = 1},
                        new TiposVehiculos{idTipoVehiculo = 4,descripcion = "Motocicleta",idCategoriaVehiculo = 4, idUsuarioModifica = 1},
                        new TiposVehiculos{idTipoVehiculo = 5,descripcion = "Motocarro",idCategoriaVehiculo = 4, idUsuarioModifica = 1},
                        new TiposVehiculos{idTipoVehiculo = 6,descripcion = "Cuatrimoto",idCategoriaVehiculo = 4, idUsuarioModifica = 1},
                        new TiposVehiculos{idTipoVehiculo = 7,descripcion = "Microbús",idCategoriaVehiculo = 2, idUsuarioModifica = 1},
                        new TiposVehiculos{idTipoVehiculo = 8,descripcion = "Buseta",idCategoriaVehiculo = 2, idUsuarioModifica = 1},
                        new TiposVehiculos{idTipoVehiculo = 9,descripcion = "Bus",idCategoriaVehiculo = 2, idUsuarioModifica = 1},
                        new TiposVehiculos{idTipoVehiculo = 10,descripcion = "Furgón",idCategoriaVehiculo = 3, idUsuarioModifica = 1},
                        new TiposVehiculos{idTipoVehiculo = 11,descripcion = "Volqueta",idCategoriaVehiculo = 3, idUsuarioModifica = 1},
                        new TiposVehiculos{idTipoVehiculo = 12,descripcion = "Tractocamión",idCategoriaVehiculo = 3, idUsuarioModifica = 1},
                        new TiposVehiculos{idTipoVehiculo = 13,descripcion = "Vehículo Rígido",idCategoriaVehiculo = 3, idUsuarioModifica = 1},
                        new TiposVehiculos{idTipoVehiculo = 14,descripcion = "Vehículo Articulado",idCategoriaVehiculo = 3, idUsuarioModifica = 1},
                        new TiposVehiculos{idTipoVehiculo = 15,descripcion = "Remolque",idCategoriaVehiculo = 5, idUsuarioModifica = 1},
                        new TiposVehiculos{idTipoVehiculo = 16,descripcion = "Semirremolque",idCategoriaVehiculo = 5, idUsuarioModifica = 1},
                        new TiposVehiculos{idTipoVehiculo = 17,descripcion = "Ambulancia",idCategoriaVehiculo = 6, idUsuarioModifica = 1},
                        new TiposVehiculos{idTipoVehiculo = 18,descripcion = "Vehículo de Bomberos",idCategoriaVehiculo = 6, idUsuarioModifica = 1},
                        new TiposVehiculos{idTipoVehiculo = 19,descripcion = "Vehículo Blindado",idCategoriaVehiculo = 6, idUsuarioModifica = 1},
                        new TiposVehiculos{idTipoVehiculo = 20,descripcion = "Grúa",idCategoriaVehiculo = 6, idUsuarioModifica = 1}
                    );
        }
    }
}
