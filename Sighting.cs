namespace BirdWatcher;

public class Sighting
{
    public Bird Bird { get; set; } = null!;
    public DateTime SightingDate { get; set; }
    public string ObserverFirstName { get; set; } = null!;
    public string ObserverLastName { get; set; } = null!;
    public Place Place { get; set; } = null!;
}

