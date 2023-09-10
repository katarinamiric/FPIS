using API.Data;
using API.Interfaces;
using API.Mapper;
using API.Services;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddScoped<IObavestenjeOIzvrsenojUplatiRepository, ObavestenjeOIzvrsenojUplatiRepository>();
builder.Services.AddScoped<IObavestenjeOIzvrsenojUplatiService, ObavestenjeOIzvrsenojUplatiService>();
builder.Services.AddScoped<IUplatnicaZaOsiguranjeRepository, UplatnicaZaOsiguranjeRepository>();
builder.Services.AddScoped<IUplatnicaZaOsiguranjeService, UplatnicaZaOsiguranjeService>();
builder.Services.AddScoped<IRadnikRepository, RadnikRepository>();
builder.Services.AddScoped<IRadnikService, RadnikService>();
builder.Services.AddScoped<IOsiguravajucaKucaRepository, OsiguravajucaKucaRepository>();
builder.Services.AddScoped<IOsiguravajucaKucaService, OsiguravajucaKucaService>();
builder.Services.AddScoped<IRacunRepository, RacunRepository>();
builder.Services.AddScoped<IRacunService, RacunService>();
builder.Services.AddScoped<IUgovorRepository, UgovorRepository>();
builder.Services.AddScoped<IUgovorService, UgovorService>();
builder.Services.AddDbContext<ApplicationDbContext>(opt =>
{
    opt.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"));
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(x => x.AddProfile(new StavkaRacunaProfile()));
builder.Services.AddCors();






var app = builder.Build();

// Configure the HTTP request pipeline.
// if (app.Environment.IsDevelopment())
// {
//     app.UseSwagger();
//     app.UseSwaggerUI();
// }

// app.UseHttpsRedirection();

// app.UseAuthorization();
app.UseCors(x => x.AllowAnyHeader().AllowAnyMethod().WithOrigins("*"));
app.UseSwagger();
app.UseSwaggerUI();
app.MapControllers();

app.Run();
