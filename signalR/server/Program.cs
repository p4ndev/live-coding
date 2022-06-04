using realtime;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSignalR();
builder.Services.AddCors(opt => {
    opt.AddDefaultPolicy(
        pol => pol.WithOrigins("http://localhost:4200").AllowAnyMethod().AllowAnyHeader().AllowCredentials()
    );
});

var app = builder.Build();

app.UseHttpsRedirection();
app.MapHub<DemoHub>("/demo");
app.UseCors();

app.Run();