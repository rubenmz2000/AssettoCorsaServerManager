using AssettoManager.Core.Models;
using AssettoManager.Core.Utils;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AssettoManager.LocalApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class FileController(IConfiguration configuration) : ControllerBase
{
    private const string CarsPath = @"content\cars";
    private const string TracksPath = @"content\tracks";

    [HttpGet("cars")]
    public IActionResult GetCarsFolders()
    {
        var gamePath = configuration["FilesPath"];
        if (gamePath == null)
            return StatusCode(StatusCodes.Status500InternalServerError, "FilesPath not set");
        var fullPath = Path.Combine(gamePath, CarsPath);
        var carsPaths = Directory.GetDirectories(fullPath);

        var cars = carsPaths.Select(carPath => NameExtractor.ExtractCarName(carPath)).OfType<Car>().ToList();

        return Ok(cars);
    }

    
    [HttpGet("tracks")]
    public IActionResult GetTracksFolders()
    {
        var gamePath = configuration["FilesPath"];
        if (gamePath == null)
            return StatusCode(StatusCodes.Status500InternalServerError, "FilesPath not set");
        var tracksPath = Path.Combine(gamePath, TracksPath);
        var folders = Directory.GetDirectories(tracksPath);
        return Ok(folders);
    }
}