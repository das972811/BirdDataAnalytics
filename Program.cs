using System.Dynamic;
using System.Numerics;
using BirdWatcher;

public class Program
{
    public static void Main(string[] args)
    {
        var birds = BirdRepository.LoadBirds();
        var importedBirds = BirdRepository.LoadImportedBirds();


        // PlayingBirdDataWithLinq(birds);
        // PlayingTwoBirdDataSet(birds, importedBirds);
        SearchBirds(birds);
    }

    public static void SearchBirds(IEnumerable<Bird> birds)
    {
        var searchParameters = new BirdSearch
        {
            Size = "Medium",
            Country = "United States",
            Colors = new List<string> { "White", "Brown", "Black" },
            Page = 0,
            PageSize = 5
        };

        Console.WriteLine("Type any key to begin search");

        while(Console.ReadKey().KeyChar != 'q')
        {
            Console.WriteLine($"Page: {searchParameters.Page}");
            birds.Search(searchParameters).ToList().ForEach( b =>
            {
                Console.WriteLine($"Common Name {b.CommonName}");
            });
            searchParameters.Page++;

        }
    }

    public static void PlayingTwoBirdDataSet(IEnumerable<Bird> birds, IEnumerable<Bird> importedBirds)
    {
        var newBirds = importedBirds.Join(
            birds,
            ib => ib.CommonName,
            b => b.CommonName,
            (ib, b) => new { importedBirds = ib, Birds = b}
        );

        var newBirdsGroupJoin = importedBirds.GroupJoin(
            birds,
            ib => ib.CommonName,
            b => b.CommonName,
            (ib, b) =>  new { ImportedBirds = ib, Birds = b }
        );

        var newBirdsGroupJoin2 = importedBirds.GroupJoin(
            birds,
            ib => ib.CommonName,
            b => b.CommonName,
            (ib, b) => new { ImportedBirds = ib, Birds = b }
        )
        .SelectMany(
            gb => gb.Birds.DefaultIfEmpty(),
            (gb, b) => new { gb.ImportedBirds, Bird = b }
        );

        var removeImportedNullBirds = newBirdsGroupJoin2.Where(nb => nb.Bird == null).Select(nb => nb.ImportedBirds);

        // birds.AddRange(newimportedBirds);

        foreach (var t in removeImportedNullBirds)
        {
            Console.WriteLine(t);
        }
    }

    public static void PlayingBirdDataWithLinq(IEnumerable<Bird> birds)
    {
        Console.WriteLine(birds.Count());

        // Find the number of sightings for each bird
        var numOfSightings = birds.SelectMany(b => b.Sightings).Count();
        Console.WriteLine($"Number of sightings for each bird: {numOfSightings}");

        // Find the avearge sighting count per bird in our data
        var averageOfTotalCountPerBird = birds.Select(b => b.Sightings.Count()).Average();
        Console.WriteLine($"Average sightings for each bird: {averageOfTotalCountPerBird}");

        // Find the number of different countries that contians bird sighting data
        var countriesBirdSightings = birds
            .SelectMany( b => b.Sightings )
            .Select( s => s.Place.Country )
            .Distinct();
        
        var countriesBirdSightingsTwo = birds
            .SelectMany( b => b.Sightings )
            .GroupBy( s => s.Place.Country )
            .Select( grp => new { Country = grp.Key, Sightings = grp.Count() } );
        
        Console.WriteLine(countriesBirdSightingsTwo.ElementAt(0));

        var statuses = birds.Select( b => b.ConservationStatus ).Distinct();
        statuses = statuses.Where( s => s != "LeastConcern" && s != "NearThreatened" );

        var endangeredSightings = birds.Join(
            statuses,
            b => b.ConservationStatus,
            s => s,
            (b, s) => new { Status = s, Birds = b }
        );

        var endangeredSightingsTwo = birds.Join(
            statuses,
            b => b.ConservationStatus,
            s => s,
            (b, s) => new { Status = s, b.Sightings }
        )
        .GroupBy(b => b.Status)
        .Select( b => new { Status = b.Key, Sightings = b.Sum( s => s.Sightings.Count() ) } );

        Console.WriteLine();
        foreach (var t in endangeredSightingsTwo)
        {
            Console.WriteLine(t);
        }
    }
}
