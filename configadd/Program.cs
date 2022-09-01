 

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


 var replace=new Dictionary<string,string>{
    {"-v","version"}
 };

builder.Configuration.AddCommandLine(args, replace);

 var version=builder.Configuration.GetValue<string>("version");

 Console.WriteLine(version);

builder.Services.AddSingleton(version);




var custom=new custom();

builder.Configuration.GetSection("custom").Bind(custom); //good
//bind to an instance class
Console.WriteLine(custom.configvalue);

builder.Services.AddSingleton(custom);

//builder.Services.Configure<custom>(builder.Configuration.GetSection("custom"));

 var db=builder.Configuration["setting:database"];
 Console.WriteLine(db);

var env=builder.Configuration["ASPNETCORE_ENVIRONMENT"]; //access to launch.json

 Console.WriteLine(env);

var aps=builder.Configuration["lanchUrl"];


 Console.WriteLine(aps);

builder.Configuration.AddJsonFile("customc.json");

var ccc=builder.Configuration["customcon"];


 Console.WriteLine(ccc);





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
