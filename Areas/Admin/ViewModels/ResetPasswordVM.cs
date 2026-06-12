namespace AppServiceAndTravel.Areas.Admin.ViewModels
{
    public class ResetPasswordVM
    {
        public int idUsuario { get; set; }
        public string Password { get; set; } = string.Empty;
    }
}