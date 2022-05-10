#region Usings
global using System;
global using System.IO;
global using System.Net;
global using System.Linq;
global using backend.domains;
global using backend.interfaces;
global using backend.controllers;
global using backend.repositories;
global using Microsoft.AspNetCore.Mvc;
global using System.Collections.Generic;
#endregion

#region Server
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(opts => 
    opts.AddPolicy(
        "react-ts-app",
        builder => builder.WithOrigins("http://localhost:3000")
    )
);
#endregion

#region DI / IoC
builder.Services.AddSingleton<IContactRepository, ContactRepository>();
#endregion

#region App
var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI();
app.UseHttpsRedirection();
app.UseCors("react-ts-app");
app.UseAuthorization();
app.MapControllers();
app.Run();
#endregion