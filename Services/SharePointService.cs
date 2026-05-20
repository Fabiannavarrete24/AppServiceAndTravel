using Microsoft.Graph;

namespace AppServiceAndTravel.Services
{
    public class SharePointService
    {
        private readonly GraphServiceClient _graph;

        public SharePointService(GraphServiceClient graph)
        {
            _graph = graph;
        }

        public async Task SubirArchivoAsync(
            byte[] archivo,
            string driveId,
            string nombreArchivo)
        {
            using var stream = new MemoryStream(archivo);

            await _graph
                .Drives[driveId]
                .Items["root"]
                .ItemWithPath($"Cotizaciones/{nombreArchivo}")
                .Content
                .PutAsync(stream);
        }
    }
}