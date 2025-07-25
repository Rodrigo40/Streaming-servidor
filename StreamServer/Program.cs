using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;
using System.IO;
using System.Threading.Tasks;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Define o diretório onde os arquivos estão
string mediaPath = Path.Combine(Directory.GetCurrentDirectory(), "Media");

// Middleware para vídeo
app.MapGet("/video", async context =>
{
    string filePath = Path.Combine(mediaPath, "video.mp4");

    if (!File.Exists(filePath))
    {
        context.Response.StatusCode = 404;
        await context.Response.WriteAsync("Vídeo não encontrado.");
        return;
    }

    context.Response.ContentType = "video/mp4";
    await context.Response.SendFileAsync(filePath);
});

// Middleware para áudio
app.MapGet("/audio", async context =>
{
    string filePath = Path.Combine(mediaPath, "audio.mp3");

    if (!File.Exists(filePath))
    {
        context.Response.StatusCode = 404;
        await context.Response.WriteAsync("Áudio não encontrado.");
        return;
    }

    context.Response.ContentType = "audio/mpeg";
    await context.Response.SendFileAsync(filePath);
});

app.Run();
