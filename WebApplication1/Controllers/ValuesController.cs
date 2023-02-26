using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Reflection;
using System.Text.Json;

namespace WebApplication1.Controllers;
[Route("api/[controller]")]
[ApiController]
public class ValuesController : ControllerBase
{
    //private const string path = "C:\\Users\\MARCI\\source\\repos\\GroupVy\\GroupVy\\bin\\Debug\\net6.0\\teszt.json";
    private const string path = "teszt.json";

    [HttpGet]
    public async Task<List<Model>> Get()
    {
        var content =  System.IO.File.ReadAllText(path);
        var models = JsonSerializer.Deserialize<List<Model>>(content)!;

        return models;
    }
}

public class Model
{
    public int X { get; set; }
    public int Y { get; set; }
}