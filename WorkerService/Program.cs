//using WorkerService;
//using WorkerService.DataAccess;
//using Microsoft.EntityFrameworkCore;
//using DbWorkerService;

//var builder = Host.CreateApplicationBuilder(args);
//builder.Services.AddHostedService<Worker>();

//builder.Services.AddDbContext<LibraryContext>(options =>
//    options.UseSqlServer(builder.Configuration.GetConnectionString("LibraryDb"))
//);

//var host = builder.Build();

//using (var scope = host.Services.CreateScope())
//{
//    using var db = scope.ServiceProvider.GetRequiredService<LibraryContext>();

//    db.Database.EnsureCreated();
//}
//host.Run();
