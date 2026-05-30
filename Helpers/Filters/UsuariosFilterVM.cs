namespace AppServiceAndTravel.Helpers.Filters
{
    public class UsuariosFilterVM : PaginationRequest
    {
        public string? Search { get; set; }
        public bool? Admin { get; set; }
        public int? IdRol { get; set; }
    }
}
