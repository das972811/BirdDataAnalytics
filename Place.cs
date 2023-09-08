namespace BirdWatcher;

public class Place
{ 
    public string Country { get; set; } = null!;
    public string City { get; set; } = null!;
    //Mountain,Plain,Forest,Desert,Beach,City
    public string TerrainType { get; set; } = null!;
    // HumidContinental,Subtropical,Semiarid,Desert,Mediterranean,Marine,Subarctic,Tundra,RainForest
    public string Climate { get; set; } = null!;
}