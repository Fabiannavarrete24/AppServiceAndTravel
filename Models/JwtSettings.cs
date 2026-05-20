
using System.ComponentModel.DataAnnotations;

namespace AppServiceAndTravel.Models
{
public class JwtSettings
{
    [StringLength(200)] public string? SecretKey { get; set; }
    [StringLength(200)] public string? Issuer { get; set; }
    [StringLength(200)] public string? Audience { get; set; }
    public int ExpirationMinutes { get; set; }
}

}