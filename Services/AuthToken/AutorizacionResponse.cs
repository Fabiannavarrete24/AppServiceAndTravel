using MimeKit.Encodings;
using System.ComponentModel.DataAnnotations;
namespace AppServiceAndTravel.Services.AuthToken
{
    public class AutorizacionResponse
    {
        [StringLength(200)] public string? Token { get; set; }
        [StringLength(200)] public string? RefreshToken { get; set; }
        public bool sucess {  get; set; }
        [StringLength(200)] public string? message { get; set; }
    }
}
