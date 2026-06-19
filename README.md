# AppServiceAndTravel

Descripción
-----------
Aplicación Razor Pages en .NET 8 para gestión de cotizaciones, clientes, operaciones (vehículos, conductores) y administración. Incluye generación de PDFs (QuestPDF) y se organiza por Areas: Comercial, Operaciones y Admin.

Requisitos
----------
- .NET 8 SDK
- SQL Server (o proveedor EF Core configurado)
- Java (para PlantUML)
- Graphviz (para PlantUML)
- PlantUML (plantuml.jar)
- Pandoc y un motor PDF (wkhtmltopdf o LaTeX) si quieres combinar Markdown -> PDF

Instalación y ejecución
-----------------------
1. Clonar el repositorio:
   git clone https://github.com/Fabiannavarrete24/AppServiceAndTravel.git

2. Configurar connection string en `appsettings.json` o Secret Manager:
   - `ConnectionStrings:DefaultConnection`

3. Aplicar migraciones:
   dotnet ef database update

4. Ejecutar la aplicación:
   dotnet run --project src/AppServiceAndTravel

Generación de documentación (diagramas y PDF)
---------------------------------------------
He incluido scripts y archivos PlantUML en `docs/`. Para generar los PDFs de diagramas y la documentación final sigue estos pasos:

- Instalar Java y Graphviz.
- Colocar `plantuml.jar` en `tools/plantuml/` o indicar su ruta.
- Ejecutar (desde la raíz del repo):
  PowerShell: `.\docs\generate_docs.ps1`

Lo anterior generará:
- PNG y PDF de cada `.puml` en `docs/output/`
- `docs/DOCUMENTACION_FINAL.pdf` que combina `README.md`, `INFORME_TECNICO.md` y los diagramas.

Notas importantes
-----------------
- Proyecto usa QuestPDF para generar cotizaciones (ver `Services/PdfService.cs`).
- Revisa `Program.cs` para los servicios registrados y políticas de autorización.
- Antes de desplegar, guarda secretos en Secret Manager o Azure Key Vault y aplica HTTPS/HSTS.

Contribuir
----------
Sigue el estilo del repositorio: C# estilo .NET 8. Para cambios grandes abre un Pull Request y añade tests cuando proceda.

Licencia
--------
Revisa el repositorio para la licencia aplicada.