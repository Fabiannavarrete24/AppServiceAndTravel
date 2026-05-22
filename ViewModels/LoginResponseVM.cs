using AppServiceAndTravel.Models;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;
namespace AppServiceAndTravel.ViewModels
{
    public class LoginResponseVM
    {
        public bool success { get; set; }
        public string? message { get; set; }
        public ApplicationUser? user { get; set; }
        public List<Claim>? claims { get; set; }
    }
}


