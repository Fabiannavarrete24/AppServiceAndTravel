using AppServiceAndTravel.Models;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

public class PdfService
{
    public byte[] GenerarCotizacion(Cotizacion c)
    {
        return Document.Create(container =>
        {
            container.Page(page =>
            {
                page.Margin(30);

                page.Header()
                    .Text("COTIZACIÓN")
                    .FontSize(24)
                    .Bold();

                page.Content().Column(col =>
                {
                    col.Item().Text($"Cliente: {c.Cliente}");
                    col.Item().Text($"Total: $");
                });

                page.Footer()
                    .AlignCenter()
                    .Text(x =>
                    {
                        x.Span("Página ");
                        x.CurrentPageNumber();
                    });

            });

        }).GeneratePdf();
    }
}