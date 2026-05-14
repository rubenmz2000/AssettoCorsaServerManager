namespace AssettoManager.Core.Models;

public class Car
{
    public string Name { get; set; }
    public string Brand { get; set; }
    public string Description { get; set; }
    public string[] Tags { get; set; }
    public string Class { get; set; }
    
    public string FolderPath { get; set; }

    public override string ToString()
    {
        return Name;
    }
}