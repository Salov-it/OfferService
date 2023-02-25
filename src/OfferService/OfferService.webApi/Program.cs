using AutoMapper;
using OfferService.Application.Interface;
using OfferService.Application.Mapping;
using System.Reflection;
using OfferService.Application;
using OfferService.persistance;
using Microsoft.AspNetCore.Authentication;
using MediatR;

var builder = WebApplication.CreateBuilder(args);

IConfiguration configuration = builder.Configuration;

builder.Services.AddAutoMapper(config =>
{
    config.AddProfile(new AssemblyMappingProfile(Assembly.GetExecutingAssembly()));
    config.AddProfile(new AssemblyMappingProfile(typeof(IOfferContext).Assembly));

});

builder.Services.AddApplication();
builder.Services.AddPersistance(configuration);

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var serviseProvider = scope.ServiceProvider;
    try
    {
        var context = serviseProvider.GetRequiredService<OfferContext>();
        DbInit.init(context);
    }
    catch (Exception ex)
    {

    }
};



// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

if (builder.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});


app.Run();
