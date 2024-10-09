var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseRouting();

//works for Both GET and POST as it has Map

//app.UseEndpoints(endpoints =>
//{
//    endpoints.Map("Map1", async (context) =>
//    {
//        await context.Response.WriteAsync("In Map 1");
//    });
//});


app.UseEndpoints(endpoints =>
{
    endpoints.MapGet("Map1", async (context) =>
    {
        await context.Response.WriteAsync("In Map 1");
    });
});

app.UseEndpoints(endpoints =>
{
    endpoints.MapPost("Map2", async (context) =>
    {
        await context.Response.WriteAsync("In Map 2");
    });
});

//Default routing

//app.Run(async context =>
//{
//    await context.Response.WriteAsync($"Request received At {context.Request.Path}");
//});


//// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//}

//app.UseHttpsRedirection();

//app.UseAuthorization();

//app.MapControllers();

app.Run();
