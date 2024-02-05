using Stone_homework.Services;
using Stone_homework.Services.Implementation;
using Stone_homework.Storage;
using Stone_homework.Storage.Implementation;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<ApplicationDbContext>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IDepartmentRepository, DepartmentRepository>();
builder.Services.AddScoped<IVacancyRepository, VacancyRepository>();

builder.Services.AddScoped<IVacancyService, VacancyService>();

//not implemented
//builder.Services.AddScoped<IDepartmentService, DepartmentService>();
//могу забыть добавить, но для остальных сервисов и хранилищ это тоже нужно

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
