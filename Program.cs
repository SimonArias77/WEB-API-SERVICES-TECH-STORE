using CONSTRUCCION_AVANZADA_API_CON_.NET.Data;
using CONSTRUCCION_AVANZADA_API_CON_.NET.Repositories;
using CONSTRUCCION_AVANZADA_API_CON_.NET.Services;
using DotNetEnv;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Load environment variables from a .env file.
Env.Load();

// Add environment variables to the project's configuration system.
builder.Configuration.AddEnvironmentVariables();

// Here we get the environment variables to connect to the database.
// These variables should be defined in the environment or a .env file.
var dbHost = Environment.GetEnvironmentVariable("DB_HOST");
var dbPort = Environment.GetEnvironmentVariable("DB_PORT");
var dbDatabaseName = Environment.GetEnvironmentVariable("DB_DATABASE");
var dbUser = Environment.GetEnvironmentVariable("DB_USERNAME");
var dbPassword = Environment.GetEnvironmentVariable("DB_PASSWORD");

// We build the MySQL connection string using the environment variables.
// This string includes the host, port, database name, user, and password.
var mySqlConnection = $"server={dbHost};port={dbPort};database={dbDatabaseName};uid={dbUser};password={dbPassword}";

// We register the database context (DbContext) in the project's services.
// MySQL is being used as the database engine, and the MySQL server version is specified.
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseMySql(mySqlConnection, ServerVersion.Parse("8.0.20-mysql")));

    builder.Services.AddScoped<ICategoryRepository, CategoryServices>();



// Get the necessary environment variables to configure JWT authentication.
// These variables should contain the security key, issuer, audience, and token expiration time.
var jwtKey = Environment.GetEnvironmentVariable("JWT_KEY");
var jwtIssuer = Environment.GetEnvironmentVariable("JWT_ISSUER");
var jwtAudience = Environment.GetEnvironmentVariable("JWT_AUDIENCE");
var jwtExpireMinutes = Environment.GetEnvironmentVariable("JWT_EXPIREMINUTES");

// Configure JWT authentication in the project's services.
// It is specified that the JWT authentication scheme will be used to authenticate and challenge requests.
// builder.Services.AddAuthentication(options =>
// {
//     options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
//     options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
// })
// // Specific JWT configuration, which includes validations such as issuer, audience, 
// // token lifetime, and the security key used to sign the tokens.
// .AddJwtBearer(options =>
// {
//     options.RequireHttpsMetadata = false;  // HTTPS is not required for the token (optional).
//     options.SaveToken = true;  // Saves the authentication token.
//     options.TokenValidationParameters = new TokenValidationParameters
//     {
//         ValidateIssuer = true,  // Validates that the token issuer is correct.
//         ValidateAudience = true,  // Validates that the token audience is correct.
//         ValidateLifetime = true,  // Validates that the token is not expired.
//         ValidateIssuerSigningKey = true,  // Validates that the signing key used to sign the token is valid.
//         ValidIssuer = jwtIssuer,   // Defines the valid issuer.
//         ValidAudience = jwtAudience,  // Defines the valid audience.
//         IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtKey))  // Defines the token signing key.
//     };
// });

// We add the authorization service, which will be used to restrict access to certain endpoints.
builder.Services.AddAuthorization();

// We configure CORS (Cross-Origin Resource Sharing) policies.
// This allows only certain origins (domains) to make requests to our API.
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowSpecificOrigin",
        builder =>
        {
            // Allows requests from the origins http://127.0.0.1:5173 and http://localhost:5173.
            // Also allows any type of header and HTTP method (GET, POST, etc.).
            // AllowCredentials allows credentials (cookies, authentication headers) to be sent.
            builder.WithOrigins("http://127.0.0.1:5173", "http://localhost:5173")
                   .AllowAnyHeader()
                   .AllowAnyMethod()
                   .AllowCredentials();
        });
});

// We add support for controllers (MVC or API Controllers).
// This allows the application to handle HTTP requests and return responses using controllers.
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseWelcomePage(new WelcomePageOptions
{
    Path = "/"
});

app.MapControllers();

app.Run();
