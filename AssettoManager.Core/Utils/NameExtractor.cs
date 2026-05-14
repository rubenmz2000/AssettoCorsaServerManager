using AssettoManager.Core.Models;
using Newtonsoft.Json;

namespace AssettoManager.Core.Utils;

public class NameExtractor
{
    private const string NameJsonPath = @"ui\ui_car.json";
    
    public static Car? ExtractCarName(string carFolderPath)
    {
        var jsonPath = Path.Combine(carFolderPath, NameJsonPath);
        var json = File.ReadAllText(jsonPath);
        var car = JsonConvert.DeserializeObject<Car>(json);
        
        if (car == null)
            return null;
        
        car?.FolderPath = carFolderPath;
        return car;
    }
}