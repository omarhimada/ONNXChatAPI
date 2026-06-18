using OnnxChatApi.Options;
using OnnxChatApi.Services;

var builder = WebApplication.CreateBuilder(args);

builder.WebHost.UseUrls(builder.Configuration["Urls"] ?? "http://0.0.0.0:5000");

builder.Services.Configure<OnnxGenAIOptions>(
    builder.Configuration.GetSection(OnnxGenAIOptions.SectionName));

builder.Services.AddSingleton<IChatService, OnnxChatService>();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.MapControllers();

app.Run();