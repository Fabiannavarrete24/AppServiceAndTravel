namespace AppServiceAndTravel.Models
{
    public class RefreshTokenRequest
    {
        public string? TokenExpirate { get; set; }
        public string? RefreshToken { get; set; }
    }
}
