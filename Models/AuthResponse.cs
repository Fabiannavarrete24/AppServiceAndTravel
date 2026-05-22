
namespace AppServiceAndTravel.Models
{
    public class AuthResponse
    {
        public string? Token { get; set; }
        public string? RefreshToken { get; set; }
        public bool sucess {  get; set; }
        public string? message { get; set; }

        public string? expiration { get; set; }
    }
}
