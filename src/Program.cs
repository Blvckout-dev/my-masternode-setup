using Blvckout.MyMasternode.Setup.Options;
using Blvckout.MyMasternode.Setup.Database;

var builder = WebApplication.CreateBuilder(args);

// Read environment variables
builder.Configuration.AddEnvironmentVariables();

// Check configuration
builder.Services.AddOptions<DatabaseOptions>()
    .Bind(builder.Configuration.GetSection(DatabaseOptions.SECTION))
    .ValidateDataAnnotations()
    .ValidateOnStart();

// Add services to the container.
builder.Services.AddSingleton<MyMasternodeSetupContext>();

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

app.MapControllers();

app.Run();
