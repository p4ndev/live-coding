using BackEnd.Interface.Domain;
using BackEnd.Provider;
using BackEnd.Service;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<DataContext>();
builder.Services.AddScoped<IQuarentine, QuarentineService>();
builder.Services.AddScoped<IEmployee, EmployeeService>();
builder.Services.AddScoped<IActivity, ActivityService>();

builder.Services.AddCors();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseCors(c => c
    .AllowAnyOrigin()
    .AllowAnyMethod()
    .AllowAnyHeader()
);

app.UseSwagger();
app.UseSwaggerUI();
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
