using System.ComponentModel.DataAnnotations;
namespace AppServiceAndTravel.Areas.Admin.ViewModels
{
public class ActividadRecienteVM
{
    public string Tipo { get; set; } = "";
    public string Descripcion { get; set; } = "";
    public DateTime Fecha { get; set; }
}
}


