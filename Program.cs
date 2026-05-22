
using AppServiceAndTravel.Models;
using AppServiceAndTravel.Services;
using AppServiceAndTravel.Data;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using System.Text;
using static Twilio.Rest.Intelligence.V3.ConfigurationResource;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Configurar la licencia de QuestPDF
QuestPDF.Settings.License = QuestPDF.Infrastructure.LicenseType.Community;

var connection = builder.Configuration.GetConnectionString("DefaultConnection");
var provider = builder.Configuration.GetValue<string>("ConnectionStrings:DatabaseProvider")!.ToLower();

builder.Services.AddDbContext<ApplicationDBContext>(options =>
{
    switch (provider!.ToLower())
    {
        case "mysql":
            options.UseMySql(connection, ServerVersion.AutoDetect(connection));
            break;

        case "postgresql":
            options.UseNpgsql(connection);
            break;
    }
});

//inyeccion de dependencias
builder.Services.AddHttpClient();

builder.Services.AddScoped<IAuthService, AuthService>();
builder.Services.AddScoped<IEmailService, EmailService>();
builder.Services.AddScoped<IJwtService, JwtService>();
builder.Services.AddScoped<UtilitiesServices>();
builder.Services.AddScoped<WhatsAppService>();
builder.Services.AddScoped<VehicleService>();
builder.Services.AddScoped<ConfiguracionService>();

builder.Services.AddHttpClient("WhatsApp");
builder.Services.AddHttpContextAccessor();

// Cargar configuración de autenticacion
var key = builder.Configuration.GetValue<string>("JwtSettings:SecretKey");
var keyBytes = Encoding.ASCII.GetBytes(key!);
builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("AdminOnly", policy =>
        policy.RequireClaim(ClaimTypes.Role, "administrador"));

    options.AddPolicy("CanAccessVentas", policy =>
        policy.RequireClaim("permission", "/ventas"));
});
builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;
    options.DefaultSignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = CookieAuthenticationDefaults.AuthenticationScheme;
})
        .AddCookie(options =>
        {
            options.LoginPath = "/Account/Login";
            options.LogoutPath = "/Account/Logout";
            options.AccessDeniedPath = "/Account/AccessDenied";
            options.ExpireTimeSpan = TimeSpan.FromMinutes(10);
            options.Cookie.HttpOnly = true;
            options.Cookie.SameSite = SameSiteMode.Lax;
            options.Cookie.SecurePolicy = CookieSecurePolicy.None;
        }

).AddJwtBearer(options =>
{
    options.RequireHttpsMetadata = false;
    options.SaveToken = true;
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey(keyBytes),
        ValidateIssuer = false,
        ValidateAudience = false,
        ValidateLifetime = true,
        ClockSkew = TimeSpan.Zero,
    };
}
);

// Configuracion de URL
builder.WebHost.ConfigureKestrel((context, options) =>
{
    var config = context.Configuration;

    var httpPort = config.GetValue<int?>("Server:HttpPort") ?? 7055;
    var httpsPort = config.GetValue<int?>("Server:HttpsPort");

    // HTTP siempre disponible
    options.ListenAnyIP(httpPort);

    // HTTPS solo si hay certificado
    var certPath = config["Server:Certificate:Path"];
    var certPassword = config["Server:Certificate:Password"];

    if (!string.IsNullOrEmpty(certPath) && File.Exists(certPath))
    {
        options.ListenAnyIP(httpsPort ?? 7056, listenOptions =>
        {
            listenOptions.UseHttps(certPath, certPassword);
        });
    }
});

builder.Services.AddCors(op =>
{
    op.AddPolicy("NewPolity", app =>
    {
        app.AllowAnyOrigin()
        .AllowAnyHeader()
        .AllowAnyMethod();
    });
});

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/App/Error");
    app.UseHttpsRedirection();

    app.UseHsts();
}
//app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseSwagger();
app.UseSwaggerUI(c =>
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Api Service And Travel")
);
app.UseAuthentication();
app.UseAuthorization();

var isConfigured = builder.Configuration.GetValue<bool>("IsConfigured");

app.MapControllerRoute(
    name: "areas",
    pattern: "{area:exists}/{controller=Account}/{action=Login}/{id?}"
);

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Account}/{action=Login}/{id?}"
);
app.MapControllers();

app.Run();