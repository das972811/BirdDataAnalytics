namespace BirdWatcher;

public class RandomUtility
{
    private readonly Random gen = new(); 

    public List<Sighting> AddRandomSightings(int count)
    {
        var sightings = new List<Sighting>();
        for (int i = 0; i < count; i++)
        {
            sightings.Add(new Sighting { ObserverFirstName = RandomFirstName(), ObserverLastName = RandomLastName(), Place = new Place { Country = RandomCountry() }, SightingDate = RandomDate() });
        }
        return sightings;
    }

    public DateTime RandomDate()
    {
        DateTime start = new(2015, 1, 1);
        int range = (DateTime.Today - start).Days;
        return start.AddDays(gen.Next(range));
    }

    public string RandomCountry()
    {
        string[] countries = { "Panama", "United States", "Mexico", "Canada", "Cuba", "Guatemala", "Brazil", "Colombia" };
        int range = countries.Length;
        return countries[gen.Next(range)];
    }

    public string RandomFirstName()
    {
        string[] firstNames = { "Rachel", "Bob", "Carlos", "Jessica", "Evelyn", "Michael", "James", "Gloria", "Pat" };
        int range = firstNames.Length;
        return firstNames[gen.Next(range)];
    }

    public string RandomLastName()
    {
        string[] lastNames = { "Hall", "Jones", "Harrison", "King", "Taylor", "Stone", "Collins", "Gardner", "Reeves", "Holt", "Baker"};
        int range = lastNames.Length;
        return lastNames[gen.Next(range)];
    }
}