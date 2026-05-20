using System.ComponentModel.DataAnnotations;

namespace AppServiceAndTravel.Services.AuthToken
{
    public class AutorizacionRequest
    {
        [StringLength(200)] public string? user { get; set; }
        [StringLength(200)] public string? password { get; set; }
    }
}
