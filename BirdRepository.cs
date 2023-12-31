namespace BirdWatcher;
public static class BirdRepository
{
    public static List<Bird> LoadBirds()
    {
        var utility = new RandomUtility();
        var birds = new List<Bird>
        {
            new(utility, "Towhee", "Abert's Towhee", "Melozone aberti", 24, 28, 45.3, 6, "Brown", "", "", "", "LeastConcern", "LC"),
            new(utility, "Flycatcher", "Acadian Flycatcher", "Empidonax virescens", 14.6, 22.9, 13, 9, "Green", "Brown", "", "", "LeastConcern", "LC"),
            new(utility, "Woodpecker", "Acorn Woodpecker", "Melanerpes formicivorus", 22.9, 44.5, 79.4, 15, "Black", "White", "Red", "", "LeastConcern", "LC"),
            new(utility, "Dove", "African Collared-Dove", "Streptopelia roseogrisea", 26, 0, 16, 12, "Brown", "Black", "Grey", "", "LeastConcern", "LC"),
            new(utility, "Flycatcher", "Alder Flycatcher", "Empidonax alnorum", 14.6, 21.6, 14, 13, "", "", "", "", "LeastConcern", "LC"),
            new(utility, "Goose", "Aleutian Cackling Goose", "Mearnsia novaeguineae", 68.6, 121.9, 2200, 4, "White", "", "", "", "LeastConcern", "LC"),
            new(utility, "Tern", "Aleutian Tern", "Onychoprion aleuticus", 30.5, 73.7, 113.4, 4, "White", "", "", "", "LeastConcern", "LC"),
            new(utility, "Hummingbird", "Allen's Hummingbird", "Selasphorus sasin", 9.5, 10.8, 3.12, 15, "Red", "Green", "", "", "LeastConcern", "LC"),
            new(utility, "Oriole", "Altamira Oriole", "Icterus gularis", 25.5, 35.6, 56.7, 1, "Orange", "Black", "", "United States|Mexico", "LeastConcern", "LC"),
            new(utility, "Kingfisher", "Amazon Kingfisher", "Chloroceryle amazona", 30, 110, 0, 0, "Blue", "White", "Orange", "Mexico", "LeastConcern", "LC"),
            new(utility, "Avocet", "American Avocet", "Recurvirostra americana", 45.7, 78.7, 311.8, 10, "White", "Brown", "Black", "United States", "LeastConcern", "LC"),
            new(utility, "Bittern", "American Bittern", "Botaurus lentiginosus", 71.1, 106.7, 680.4, 18, "Brown", "Black", "", "United States", "LeastConcern", "LC"),
            new(utility, "Duck", "American Black Duck", "Anas rubripes", 58.4, 88.9, 1179.3, 3, "Black", "", "", "United States", "LeastConcern", "LC"),
            new(utility, "Coot", "American Coot", "Fulica americana", 35.6, 70, 635, 19, "Grey", "Black", "", "United States", "LeastConcern", "LC"),
            new(utility, "Crow", "American Crow", "Corvus brachyrhynchos", 44.5, 99, 453.6, 7, "Black", "", "", "United States", "LeastConcern", "LC"),
            new(utility, "Dipper", "American Dipper", "Cinclus mexicanus", 19, 28, 56.7, 14, "Grey", "Black", "", "United States", "LeastConcern", "LC"),
            new(utility, "Flamingo", "American Flamingo", "Phoenicopterus ruber", 116.8, 152.4, 2500, 7, "Pink", "", "", "United States", "LeastConcern", "LC"),
            new(utility, "Plover", "American Golden-Plover", "Pluvialis dominica", 26.7, 66, 141.8, 9, "", "", "", "United States", "LeastConcern", "LC"),
            new(utility, "Goldfinch", "American Goldfinch", "Carduelis tristis", 12.7, 23, 13, 7, "White", "", "", "United States", "LeastConcern", "LC"),
            new(utility, "Kestrel", "American Kestrel", "Falco sparverius", 23, 56, 116.3, 5, "", "", "", "United States", "LeastConcern", "LC"),
            new(utility, "Oystercatcher", "American Oystercatcher", "Haematopus palliatus", 44.4, 81.3, 635, 16, "", "White", "", "United States", "LeastConcern", "LC"),
            new(utility, "Pipit", "American Pipit", "Anthus rubescens", 16.5, 26.7, 21.3, 14, "", "", "", "United States", "LeastConcern", "LC"),
            new(utility, "Warbler", "American Redstart", "Setophaga ruticilla", 13.3, 19.7, 11.3, 20, "Red", "", "", "United States", "LeastConcern", "LC"),
            new(utility, "Robin", "American Robin", "Turdus migratorius", 25.4, 43, 76.4, 8, "", "", "", "United States", "LeastConcern", "LC"),
            new(utility, "Woodpecker", "American Three-toed Woodpecker", "Picoides dorsalis", 22.2, 38.1, 65.2, 11, "Red", "Black", "", "United States", "LeastConcern", "LC"),
            new(utility, "Sparrow", "American Tree Sparrow", "Spizella arborea", 15.9, 24.1, 19.8, 25, "", "White", "", "United States", "LeastConcern", "LC"),
            new(utility, "Pelican", "American White Pelican", "Pelecanus erythrorhynchos", 157.5, 274, 7400, 7, "White", "", "", "United States", "LeastConcern", "LC"),
            new(utility, "Woodcock", "American Woodcock", "Scolopax minor", 28, 45.7, 198.5, 1, "White", "", "", "United States", "LeastConcern", "LC"),
            new(utility, "Murrelet", "Ancient Murrelet", "Synthliboramphus antiquus", 25.4, 43.2, 198.4, 16, "Black", "White", "", "United States", "LeastConcern", "LC"),
            new(utility, "Anhinga", "Anhinga", "Anhinga anhinga", 90, 114.3, 1225, 15, "Black", "White", "", "Brazil", "LeastConcern", "LC"),
            new(utility, "Hummingbird", "Anna's Hummingbird", "Calypte anna", 10.2, 13.3, 5.7, 11, "", "", "", "", "LeastConcern", "LC"),
            new(utility, "Hummingbird", "Antillean Crested Hummingbird", "Orthorhyncus cristatus", 9.5, 12, 4, 19, "White", "", "", "", "LeastConcern", "LC"),
            new(utility, "Nightjar", "Antillean Nighthawk", "Chordeiles gundlachii", 21.6, 53.3, 56.7, 6, "", "", "", "", "LeastConcern", "LC"),
            new(utility, "Swift", "Antillean Palm-Swift", "Tachornis phoenicobia", 11.5, 25, 11, 6, "", "", "", "", "LeastConcern", "LC"),
            new(utility, "Falcon", "Aplomado Falcon", "Falco femoralis", 45.7, 122, 255, 20, "", "", "", "", "LeastConcern", "LC"),
            new(utility, "Loon", "Arctic Loon", "Gavia arctica", 68.6, 101.6, 2600, 15, "Black", "", "", "Canada", "LeastConcern", "LC"),
            new(utility, "Tern", "Arctic Tern", "Sterna paradisaea", 30.5, 78.7, 113.4, 2, "", "", "", "", "LeastConcern", "LC"),
            new(utility, "Warbler", "Arctic Warbler", "Phylloscopus borealis", 12.7, 20.3, 9.9, 18, "", "", "", "", "LeastConcern", "LC"),
            new(utility, "Woodpecker", "Arizona Woodpecker", "Picoides arizonae", 19, 35.6, 45.4, 11, "", "", "", "", "LeastConcern", "LC"),
            new(utility, "Flycatcher", "Ash-throated Flycatcher", "Myiarchus cinerascens", 21.6, 30.5, 28.4, 5, "", "", "", "", "LeastConcern", "LC"),
            new(utility, "Storm-Petrel", "Ashy Storm-Petrel", "Oceanodroma homochroa", 20.3, 45.7, 36.8, 2, "Grey", "White", "", "United States", "Endangered", "EN"),
            new(utility, "Flycatcher", "Asian Brown Flycatcher", "Muscicapa dauurica", 13.5, 20.3, 11.3, 13, "", "", "", "", "LeastConcern", "LC"),
            new(utility, "Rosy-Finch", "Asian Rosy-Finch", "Leucosticte arctoa", 18, 0, 48, 9, "", "", "", "", "LeastConcern", "LC"),
            new(utility, "Puffin", "Atlantic Puffin", "Fratercula arctica", 31.75, 53.34, 368, 0, "Black", "White", "Orange", "", "Vulnerable", "VU"),
            new(utility, "Oriole", "Audubon's Oriole", "Icterus graduacauda", 21.4, 30.5, 36.8, 4, "", "", "", "", "LeastConcern", "LC"),
            new(utility, "Shearwater", "Audubon's Shearwater", "Puffinus lherminieri", 30.5, 68.6, 170.1, 2, "", "", "", "", "LeastConcern", "LC"),
            new(utility, "Thrush", "Aztec Thrush", "Ridgwayia pinicola", 23.5, 40.6, 76.5, 4, "", "", "", "", "LeastConcern", "LC"),
            new(utility, "Sparrow", "Bachman's Sparrow", "Peucaea aestivalis", 15.2, 18.4, 19.8, 6, "Brown", "", "", "", "NearThreatened", "NT"),
            new(utility, "Warbler", "Bachman's Warbler", "Vermivora bachmanii", 10.7, 18.3, 9.9, 5, "Black", "White", "", "United States|Cuba", "CriticallyEngandered", "CR"),
            new(utility, "Duck", "Baer's Pochard", "Aythya baeri", 45.7, 79, 880, 0, "Black", "Brown", "White", "China|Vietnam|Japan|India", "CriticallyEngandered", "CR"),
            new(utility, "Mockingbird", "Bahama Mockingbird", "Mimus gundlachii", 28, 37, 65.2, 9, "", "", "", "", "LeastConcern", "LC"),
            new(utility, "Swallow", "Bahama Swallow", "Tachycineta cyaneoviridis", 14.6, 35.6, 17, 3, "Green", "Blue", "Black|White", "Bahamas", "Endangered", "EN"),
            new(utility, "Hummingbird", "Bahama Woodstar", "Calliphlox evelynae", 10.2, 12.7, 5.7, 18, "", "", "", "", "LeastConcern", "LC"),
            new(utility, "Yellowthroat", "Bahama Yellowthroat", "Geothlypis rostrata", 15, 17, 17.3, 18, "White", "Yellow", "", "", "LeastConcern", "LC"),
            new(utility, "Teal", "Baikal Teal", "Anas formosa", 43.2, 63.5, 496, 3, "", "", "", "", "LeastConcern", "LC"),
            new(utility, "Sandpiper", "Baird's Sandpiper", "Calidris bairdii", 19.05, 46.18, 36.85, 1, "White", "", "", "", "LeastConcern", "LC"),
            new(utility, "Sparrow", "Baird's Sparrow", "Ammodramus bairdii", 14, 22.2, 17, 17, "Brown", "", "", "United States|Canada|Mexico", "LeastConcern", "LC"),
            new(utility, "Eagle", "Bald Eagle", "Haliaeetus leucocephalus", 78.75, 203, 4300, 19, "Brown", "White", "Yellow", "United States|Canada|Mexico", "LeastConcern", "LC"),
            new(utility, "Oriole", "Baltimore Oriole", "Icterus galbula (1)", 22.2, 29.2, 34, 4, "Orange", "", "", "", "LeastConcern", "LC"),
            new(utility, "Bananaquit", "Bananaquit", "Coereba flaveola", 11.4, 20.3, 19, 18, "White", "Grey", "Black", "", "LeastConcern", "LC"),
            new(utility, "Swallow", "Bank Swallow", "Riparia riparia", 13.33, 33, 14.17, 16, "", "", "", "", "LeastConcern", "LC"),
            new(utility, "Owl", "Barn Owl", "Tyto alba", 40.64, 106.68, 454, 3, "Brown", "White", "", "United States|Brazil|Canada|Mexico|Venezuela", "LeastConcern", "LC"),
            new(utility, "Swallow", "Barn Swallow", "Hirundo rustica", 17.14, 38.1, 19.84, 16, "", "", "", "", "LeastConcern", "LC"),
            new(utility, "Goose", "Barnacle Goose", "Branta leucopsis", 68.58, 127, 1678, 10, "", "", "", "", "LeastConcern", "LC"),
            new(utility, "Owl", "Barred Owl", "Strix varia", 53.34, 106.68, 726, 15, "Brown", "White", "", "Canada|United States", "LeastConcern", "LC"),
            new(utility, "Parakeet", "Barred Parakeet", "Bolborhynchus lineola", 17.8, 71, 55, 2, "White", "", "", "", "LeastConcern", "LC"),
            new(utility, "Duck", "Barrow's Goldeneye", "Bucephala islandica", 45.7, 71, 952.5, 2, "", "", "", "", "LeastConcern", "LC"),
            new(utility, "Warbler", "Black-and-white Warbler", "Mniotilta varia", 13.3, 21, 11.3, 16, "Black", "White", "", "", "LeastConcern", "LC"),
            new(utility, "Plover", "Black-bellied Plover", "Pluvialis squatarola", 29.2, 73.7, 226.8, 4, "Black", "Brown", "", "", "LeastConcern", "LC"),
            new(utility, "Cuckoo", "Black-billed Cuckoo", "Coccyzus erythropthalmus", 30.5, 44.5, 56.7, 7, "White", "Brown", "", "", "LeastConcern", "LC"),
            new(utility, "Magpie", "Black-billed Magpie", "Pica pica", 48.26, 63.5, 170, 14, "Black", "", "", "", "LeastConcern", "LC"),
            new(utility, "Albatross", "Black-browed Albatross", "Thalassarche melanophris", 88.9, 223.5, 4500, 5, "White", "Grey", "Black", "", "NearThreatened", "NT"),
            new(utility, "Macaw", "Blue-and-yellow Macaw", "Ava ararauna", 91.4, 122, 1100, 1, "Blue", "Yellow", "", "", "LeastConcern", "LC"),
            new(utility, "Macaw", "Blue-throated Macaw", "Ara glaucogularis", 68.6, 101.6, 2600, 1, "Blue", "Yellow", "Orange|Black", "Bolivia", "CriticallyEngandered", "CR"),
            new(utility, "Hummingbird", "Broad-billed Hummingbird", "Cynanthus latirostris", 10.2, 14.6, 2.8, 9, "", "", "", "", "LeastConcern", "LC"),
            new(utility, "Sandpiper", "Broad-billed Sandpiper", "Limicola falcinellus", 17.8, 38.1, 39.7, 13, "", "", "", "", "LeastConcern", "LC"),
            new(utility, "Hummingbird", "Buff-bellied Hummingbird", "Amazilia yucatanensis", 10.8, 14.6, 3.7, 8, "White", "", "", "", "LeastConcern", "LC"),
            new(utility, "Flycatcher", "Buff-breasted Flycatcher", "Empidonax fulvifrons", 12.7, 19.1, 8.5, 12, "", "", "", "", "LeastConcern", "LC"),
            new(utility, "Condor", "California condor", "Gymnogyps californianus", 300, 0, 1200, 3, "Black", "Red", "", "United States", "CriticallyEngandered", "CR"),
            new(utility, "Warbler", "Cape May Warbler", "Setophaga tigrina", 12.7, 21, 11.3, 11, "Yellow", "Grey", "", "Canada|United States", "NearThreatened", "NT"),
            new(utility, "Waxwing", "Cedar Waxwing", "Bombycilla cedrorum", 18.4, 30.5, 56.7, 11, "", "", "", "", "LeastConcern", "LC"),
            new(utility, "Warbler", "Cerulean Warbler", "Setophaga cerulea", 12, 19.7, 9.9, 1, "Blue", "White", "Black|Grey", "", "Vulnerable", "VU"),
            new(utility, "Longspur", "Chestnut-collared Longspur", "Calcarius ornatus", 15.25, 26.7, 28.3, 0, "Brown", "White", "Black", "", "NearThreatened", "NT"),
            new(utility, "Macaw", "Chestnut-fronted Macaw", "Ara severa", 45.7, 76.2, 425.2, 0, "White", "", "", "Panama|Brazil|Bolivia", "LeastConcern", "LC"),
            new(utility, "Raven", "Chihuahuan Raven", "Corvus cryptoleucus", 49.5, 111.8, 544.3, 0, "", "", "", "", "LeastConcern", "LC"),
            new(utility, "Flamingo", "Chilean Flamingo", "Phoenicopterus chilensis", 111.8, 144.8, 2300, 10, "Pink", "", "", "", "NearThreatened", "NT"),
            new(utility, "Swift", "Chimney Swift", "Chaetura pelagica", 13.3, 35.6, 22.7, 13, "Black", "Grey", "Black|White", "", "NearThreatened", "NT"),
            new(utility, "Egret", "Chinese Egret", "Egretta eulophotes", 68.6, 114.3, 482, 5, "White", "", "", "China", "Vulnerable", "VU"),
            new(utility, "Heron", "Chinese Pond-Heron", "Ardeola bacchus", 45.7, 86.4, 370, 1, "", "", "", "", "LeastConcern", "LC"),
            new(utility, "Sparrow", "Chipping Sparrow", "Spizella passerina", 14, 21.6, 11.3, 19, "Brown", "", "", "Canada|United States", "LeastConcern", "LC"),
            new(utility, "Shearwater", "Christmas Shearwater", "Puffinus nativitatis", 38, 90, 415, 19, "", "", "", "", "LeastConcern", "LC"),
            new(utility, "Chukar", "Chukar", "Alectoris chukar", 35.5, 50.8, 590, 18, "Grey", "Black", "White|Pink", "", "LeastConcern", "LC"),
            new(utility, "Hummingbird", "Cinnamon Hummingbird", "Amazilia rutila", 11.4, 14, 6, 17, "", "", "", "", "LeastConcern", "LC"),
            new(utility, "Teal", "Cinnamon Teal", "Anas cyanoptera", 44.6, 56, 397, 5, "", "", "", "", "LeastConcern", "LC"),
            new(utility, "Wagtail", "Citrine Wagtail", "Motacilla citreola", 16.5, 22.9, 19.8, 12, "Yellow", "Black", "White", "", "LeastConcern", "LC"),
            new(utility, "Rail", "Clapper Rail", "Rallus longirostris", 36.8, 48.3, 283.5, 3, "Brown", "", "", "", "LeastConcern", "LC"),
            new(utility, "Grebe", "Clark's Grebe", "Aechmophorus clarkii", 63.5, 61, 1400, 4, "", "", "", "", "LeastConcern", "LC"),
            new(utility, "Nutcracker", "Clark's Nutcracker", "Nucifraga columbiana", 30.5, 61, 130, 5, "", "", "", "", "LeastConcern", "LC"),
            new(utility, "Sparrow", "Clay-colored Sparrow", "Spizella pallida", 14, 19, 11, 9, "Brown", "", "", "", "LeastConcern", "LC"),
            new(utility, "Thrush", "Clay-colored Thrush", "Turdus grayi", 23, 39.4, 73.7, 15, "Brown", "", "", "", "LeastConcern", "LC"),
            new(utility, "Swallow", "Cliff Swallow", "Petrochelidon pyrrhonota", 14, 34, 21, 2, "", "", "", "", "LeastConcern", "LC"),
            new(utility, "Heron", "Cocoi Heron", "Ardea cocoi", 127, 0, 2500, 4, "", "", "", "", "LeastConcern", "LC"),
            new(utility, "Falcon", "Collared Forest-Falcon", "Micrastur semitorquatus", 61, 89, 540, 10, "Brown", "", "", "", "LeastConcern", "LC"),
            new(utility, "Hawk", "Common Black Hawk", "Buteogallus anthracinus", 53, 117, 953, 10, "", "", "", "", "LeastConcern", "LC"),
            new(utility, "Chiffchaff", "Common Chiffchaff", "Phylloscopus collybita", 12, 18, 8.5, 2, "Brown", "Grey", "", "", "LeastConcern", "LC"),
            new(utility, "Crane", "Common Crane", "Grus grus", 129.5, 231, 5400, 16, "White", "", "", "", "LeastConcern", "LC"),
            new(utility, "Cuckoo", "Common Cuckoo", "Cuculus canorus", 33, 66, 141.7, 11, "Black", "White", "Grey", "", "LeastConcern", "LC"),
            new(utility, "Eider", "Common Eider", "Somateria mollissima", 61, 96.5, 2100, 16, "White", "Black", "", "", "NearThreatened", "NT"),
            new(utility, "Gallinule", "Common Gallinule", "Gallinula galeata", 35.6, 53.3, 311.8, 8, "", "", "", "", "LeastConcern", "LC"),
            new(utility, "Duck", "Common Goldeneye", "Bucephala clangula", 47, 66, 861.8, 19, "", "", "", "", "LeastConcern", "LC"),
            new(utility, "Grackle", "Common Grackle", "Quiscalus quiscula", 31.8, 43.2, 113.4, 10, "", "", "", "", "LeastConcern", "LC"),
            new(utility, "Dove", "Common Ground-Dove", "Columbina passerina", 16.5, 26.7, 28.4, 19, "Brown", "Orange", "Black|White|Grey", "", "LeastConcern", "LC"),
            new(utility, "Martin", "Common House-Martin", "Delichon urbicum", 15.2, 30.5, 14.2, 10, "", "", "", "", "LeastConcern", "LC"),
            new(utility, "Hawk", "Cooper's Hawk", "Accipiter cooperii", 41.9, 78.7, 453.6, 7, "", "", "", "", "LeastConcern", "LC"),
            new(utility, "Flycatcher", "Cordilleran Flycatcher", "Empidonax occidentalis", 13.9, 20.3, 11.3, 4, "", "", "", "", "LeastConcern", "LC"),
            new(utility, "Warbler", "Crescent-chested Warbler", "Oreothlypis superciliosa", 11, 17.8, 8.5, 0, "", "", "", "", "LeastConcern", "LC"),
            new(utility, "Meadowlark", "Cuban Eastern Meadowlark", "Sturnella magna hippocrepis", 28, 40, 150, 9, "Brown", "", "", "", "LeastConcern", "LC"),
            new(utility, "Flycatcher", "Eastern Kingbird", "Tyrannus tyrannus", 23, 35, 55, 17, "", "", "", "", "LeastConcern", "LC"),
            new(utility, "Sparrow", "Field Sparrow", "Spizella pusilla", 14.6, 20.3, 12.8, 9, "", "", "", "", "LeastConcern", "LC"),
            new(utility, "Thrush", "Fieldfare", "Turdus pilaris", 25.4, 45.7, 99.2, 10, "", "", "", "", "LeastConcern", "LC"),
            new(utility, "Crow", "Fish Crow", "Corvus ossifragus", 38.1, 91.4, 283.5, 0, "Black", "", "", "", "LeastConcern", "LC"),
            new(utility, "Sparrow", "Five-striped Sparrow", "Amphispiza quinquestriata", 15.2, 20.3, 19.8, 13, "", "", "", "", "LeastConcern", "LC"),
            new(utility, "Owl", "Flammulated Owl", "Psiloscops flammeolus", 17.1, 40.6, 59.5, 10, "Black", "White", "Brown", "Canada|United States", "LeastConcern", "LC"),
            new(utility, "Jay", "Florida Scrub-Jay", "Aphelocoma coerulescens", 27.94, 34.3, 85, 7, "Blue", "Grey", "", "", "Vulnerable", "VU"),
            new(utility, "Flycatcher", "Fork-tailed Flycatcher", "Tyrannus savana", 38.1, 38.1, 28.3, 8, "", "", "", "", "LeastConcern", "LC"),
            new(utility, "Storm-Petrel", "Fork-tailed Storm-Petrel", "Oceanodroma furcata", 21.6, 48.3, 53.9, 12, "", "", "", "", "LeastConcern", "LC"),
            new(utility, "Swift", "Fork-tailed Swift", "Apus pacificus", 19.8, 53.3, 48.2, 16, "Brown", "", "", "", "LeastConcern", "LC"),
            new(utility, "Tern", "Forster's Tern", "Sterna forsteri", 33, 78.7, 170.1, 9, "", "", "", "", "LeastConcern", "LC"),
            new(utility, "Sparrow", "Fox Sparrow", "Passerella iliaca", 17.8, 26.7, 31.2, 18, "Brown", "White", "", "Canada|United States", "LeastConcern", "LC"),
            new(utility, "Gull", "Franklin's Gull", "Larus pipixcan", 37, 91, 283.5, 5, "White", "", "", "", "LeastConcern", "LC"),
            new(utility, "Duck", "Fulvous Whistling-Duck", "Dendrocygna bicolor", 48.3, 66, 680.4, 5, "", "", "", "", "LeastConcern", "LC"),
            new(utility, "Duck", "Gadwall", "Mareca strepera", 63.5, 100, 1020, 11, "", "", "", "", "LeastConcern", "LC"),
            new(utility, "Petrel", "Galapagos Petrel", "Pterodroma phaeopygia", 43, 91, 410, 2, "White", "Black", "Brown", "Galapagos", "CriticallyEngandered", "CR"),
            new(utility, "Shearwater", "Galapagos Shearwater", "Puffinus subalaris", 31, 63, 225, 19, "", "", "", "", "LeastConcern", "LC"),
            new(utility, "Quail", "Gambel's Quail", "Callipepla gambelii", 25.4, 35.6, 270.1, 1, "", "", "", "", "LeastConcern", "LC"),
            new(utility, "Teal", "Garganey", "Anas querquedula", 39.4, 60.1, 368.5, 4, "", "", "", "", "LeastConcern", "LC"),
            new(utility, "Warbler", "Golden-cheeked Warbler", "Setophaga chrysoparia", 12.7, 19.7, 9.9, 3, "Black", "White", "Yellow", "United States", "Endangered", "EN"),
            new(utility, "Kinglet", "Golden-crowned Kinglet", "Regulus satrapa", 10.2, 17.8, 6, 13, "", "", "", "", "LeastConcern", "LC"),
            new(utility, "Sparrow", "Golden-crowned Sparrow", "Zonotrichia atricapilla", 18.4, 24, 28.35, 9, "", "", "", "", "LeastConcern", "LC"),
            new(utility, "Warbler", "Golden-crowned Warbler", "Basileuterus culicivorus", 12.7, 19.1, 10.5, 9, "", "", "", "", "LeastConcern", "LC"),
            new(utility, "Woodpecker", "Golden-fronted Woodpecker", "Melanerpes aurifrons", 24.1, 43.2, 82.2, 19, "", "", "", "", "LeastConcern", "LC"),
            new(utility, "Thrush", "Gray-cheeked Thrush", "Catharus minimus", 18.4, 33, 31.2, 2, "", "", "", "", "LeastConcern", "LC"),
            new(utility, "Booby", "Masked Booby", "Sula dactylatra", 81.3, 157.5, 1500, 13, "White", "Black", "", "", "LeastConcern", "LC"),
            new(utility, "Becard", "Gray-collared Becard", "Pachyramphus major", 16, 0, 22.7, 14, "Red", "White", "Black", "", "LeastConcern", "LC"),
            new(utility, "Rosy-Finch", "Gray-crowned Rosy-Finch", "Leucosticte tephrocotis", 15.9, 33, 25.8, 6, "", "", "", "", "LeastConcern", "LC"),
            new(utility, "Yellowthroat", "Gray-crowned Yellowthroat", "Geothlypis poliocephala", 14, 20.3, 14.5, 2, "", "", "", "", "LeastConcern", "LC"),
            new(utility, "Chickadee", "Gray-headed Chickadee", "Parus cinctus", 14, 21.6, 12.5, 2, "Brown", "Black", "White|Grey", "", "LeastConcern", "LC"),
            new(utility, "Gull", "Gray-hooded Gull", "Larus cirrocephalus", 40.6, 109.2, 323.2, 16, "", "", "", "", "LeastConcern", "LC"),
            new(utility, "Heron", "Great Blue Heron", "Ardea herodias", 117, 190, 2400, 2, "Blue", "", "", "", "LeastConcern", "LC"),
            new(utility, "Flycatcher", "Great Crested Flycatcher", "Myiarchus crinitus", 22, 33, 34, 8, "", "", "", "", "LeastConcern", "LC"),
            new(utility, "Owl", "Great Gray Owl", "Strix nebulosa", 68.6, 132.1, 1100, 3, "Grey", "White", "Brown", "Canada|United States", "LeastConcern", "LC"),
            new(utility, "Macaw", "Great Green Macaw", "Ara ambiguus", 90, 0, 1300, 2, "Green", "Red", "Blue", "Costa Rica|Colombia", "Endangered", "EN"),
            new(utility, "Bullfinch", "Greater Antillean Bullfinch", "Loxigilla violacea", 16.5, 0, 22.7, 15, "Black", "Red", "", "", "LeastConcern", "LC"),
            new(utility, "Grackle", "Greater Antillean Grackle", "Quiscalus niger", 27.9, 0, 62, 12, "", "", "", "", "LeastConcern", "LC"),
            new(utility, "Redpoll", "Greenland's Common Redpoll", "Acanthis flammea rostrata", 13.3, 23, 13, 17, "", "", "", "", "LeastConcern", "LC"),
            new(utility, "Ani", "Groove-billed Ani", "Crotophaga sulcirostris", 34.3, 43.2, 85, 20, "Black", "", "", "United States|Mexico|Bahamas", "LeastConcern", "LC"),
            new(utility, "Murrelet", "Guadalupe Murrelet", "Synthliboramphus hypoleucus", 24.9, 38.1, 170.1, 3, "White", "", "", "United States|Mexico", "Endangered", "EN"),
            new(utility, "Tern", "Gull-billed Tern", "Gelochelidon nilotica", 35.5, 86.4, 170.1, 9, "", "", "", "", "LeastConcern", "LC"),
            new(utility, "Woodpecker", "Ivory-billed woodpecker", "Campephilus principalis", 51, 76, 0, 1, "Black", "White", "Red", "United States", "CriticallyEngandered", "CR"),
            new(utility, "Motmot", "Keel-billed motmot", "Electron carinatum", 14, 20.3, 14.5, 1, "Yellow", "Green", "Blue", "Belize|Costa Rica|Guatemala|Honduras|Nicaragua", "Vulnerable", "VU"),
            new(utility, "Warbler", "Kirtland’s warbler", "Dendroica kirtlandii", 12.7, 19.1, 10.5, 2, "", "", "", "", "NearThreatened", "NT"),
            new(utility, "Flycatcher", "La Sagra's Flycatcher", "Myiarchus sagrae", 18.4, 26.7, 17.9, 15, "Brown", "", "", "", "LeastConcern", "LC"),
            new(utility, "Storm-Petrel", "Leach's Storm-Petrel", "Oceanodroma leucorhoa", 20.3, 50.8, 39.7, 11, "", "", "", "", "LeastConcern", "LC"),
            new(utility, "Sandpiper", "Least Sandpiper", "Calidris minutilla", 15.2, 33, 19.8, 13, "Brown", "White", "", "United States|Mexico", "LeastConcern", "LC"),
            new(utility, "Storm-Petrel", "Least Storm-Petrel", "Oceanodroma microsoma", 14.6, 38.1, 21, 14, "", "", "", "", "LeastConcern", "LC"),
            new(utility, "Tern", "Least Tern", "Sternula antillarum", 22.9, 50.8, 42.5, 9, "", "", "", "", "LeastConcern", "LC"),
            new(utility, "Nightjar", "Lesser Nighthawk", "Chordeiles acutipennis", 22.9, 55.9, 56.7, 16, "Brown", "", "", "", "LeastConcern", "LC"),
            new(utility, "Prairie-Chicken", "Lesser Prairie-Chicken", "Tympanuchus pallidicinctus", 40.6, 63.5, 720, 1, "Brown", "Red", "Black", "United States|Mexico", "Vulnerable", "VU"),
            new(utility, "Plover", "Lesser Sand-Plover", "Charadrius mongolus", 19, 55.9, 67, 19, "", "", "", "United States|Mexico", "LeastConcern", "LC"),
            new(utility, "Duck", "Lesser Scaup", "Aythya affinis", 41.9, 63.5, 816.5, 20, "", "", "", "", "LeastConcern", "LC"),
            new(utility, "Goose", "Lesser White-fronted Goose", "Anser erythropus", 66, 134.6, 2000, 3, "Brown", "White", "Black|Grey", "Greenland|Ireland|Scotland", "Vulnerable", "VU"),
            new(utility, "Warbler", "Lesser Whitethroat", "Sylvia curruca", 14, 17.8, 11.3, 6, "White", "Brown", "", "", "LeastConcern", "LC"),
            new(utility, "Yellowlegs", "Lesser Yellowlegs", "Tringa flavipes", 26.7, 61, 79.4, 11, "", "", "", "United States|Mexico", "LeastConcern", "LC"),
            new(utility, "Woodpecker", "Lewis's Woodpecker", "Melanerpes lewis", 27.3, 53.4, 113.4, 7, "", "", "", "United States|Mexico", "LeastConcern", "LC"),
            new(utility, "Albatross", "Light-mantled Albatross", "Phoebetria palpebrata", 88.9, 213.4, 3170, 15, "White", "Grey", "Black", "United States|Mexico", "NearThreatened", "NT"),
            new(utility, "Meadowlark", "Lilian's Meadowlark", "Sturnella magna lilianae", 24.23, 35.6, 90.7, 16, "", "", "", "United States|Mexico", "LeastConcern", "LC"),
            new(utility, "Limpkin", "Limpkin", "Aramus guarauna", 66.04, 101.6, 1090, 10, "", "", "", "United States|Mexico", "LeastConcern", "LC"),
            new(utility, "Sparrow", "Lincoln's Sparrow", "Melospiza lincolnii", 14.6, 19.1, 17, 11, "", "", "", "United States|Mexico", "LeastConcern", "LC"),
            new(utility, "Bunting", "Little Bunting", "Emberiza pusilla", 13.9, 24.1, 14.2, 16, "Brown", "Black", "White|Grey", "", "LeastConcern", "LC"),
            new(utility, "Curlew", "Little Curlew", "Numenius minutus", 35.6, 40.6, 340.2, 7, "Brown", "Black", "White|Grey", "", "LeastConcern", "LC"),
            new(utility, "Egret", "Little Egret", "Egretta garzetta", 63.5, 106.7, 425.2, 6, "Brown", "", "", "", "LeastConcern", "LC"),
            new(utility, "Gull", "Little Gull", "Hydrocoloeus minutus", 28, 61, 119, 18, "Brown", "", "", "", "LeastConcern", "LC"),
            new(utility, "Plover", "Little Ringed Plover", "Charadrius dubius", 15.2, 33, 39.7, 2, "Brown", "", "", "United States|Mexico", "LeastConcern", "LC"),
            new(utility, "Stint", "Little Stint", "Calidris minuta", 15.2, 35.6, 23.8, 7, "Brown", "", "", "United States|Mexico", "LeastConcern", "LC"),
            new(utility, "Kingbird", "Loggerhead Kingbird", "Tyrannus caudifasciatus", 23, 38, 42.5, 14, "Brown", "", "", "United States|Mexico", "LeastConcern", "LC"),
            new(utility, "Shrike", "Loggerhead Shrike", "Lanius ludovicianus", 23, 30.5, 48.2, 3, "Brown", "", "", "United States|Mexico", "LeastConcern", "LC"),
            new(utility, "Duck", "Long-tailed Duck", "Clangula hyemalis", 53.3, 71.1, 952.5, 6, "White", "Black", "Grey", "United States|Mexico", "Vulnerable", "VU"),
            new(utility, "Jaeger", "Long-tailed Jaeger", "Stercorarius longicaudus", 58.4, 83.8, 311.8, 3, "", "", "", "United States|Mexico", "LeastConcern", "LC"),
            new(utility, "Warbler", "Louisiana Waterthrush", "Parkesia motacilla", 15.2, 25.4, 20, 7, "", "", "", "United States|Mexico", "LeastConcern", "LC"),
            new(utility, "Hummingbird", "Lucifer Hummingbird", "Calothorax lucifer", 8.9, 10.2, 3.1, 3, "", "", "", "United States|Mexico", "LeastConcern", "LC"),
            new(utility, "Warbler", "Lucy's Warbler", "Oreothlypis luciae", 10.8, 17.8, 7.1, 5, "", "", "", "United States|Mexico", "LeastConcern", "LC"),
            new(utility, "Frigatebird", "Magnificent Frigatebird", "Fregata magnificens", 101.6, 228.6, 1500, 7, "Brown", "", "", "United States|Mexico", "LeastConcern", "LC"),
            new(utility, "Hummingbird", "Magnificent Hummingbird", "Eugenes fulgens", 13.3, 19, 7, 1, "", "", "", "", "LeastConcern", "LC"),
            new(utility, "Duck", "Mandarin Duck.", "Aix galericulata", 45.7, 74.9, 635, 17, "", "", "", "", "LeastConcern", "LC"),
            new(utility, "Cuckoo", "Mangrove Cuckoo", "Coccyzus minor", 30.5, 43.2, 65.2, 13, "White", "Grey", "", "", "LeastConcern", "LC"),
            new(utility, "Godwit", "Marbled Godwit", "Limosa fedoa", 45.7, 76, 368.5, 16, "Brown", "", "", "", "LeastConcern", "LC"),
            new(utility, "Duck", "Masked Duck", "Nomonyx dominicus", 34.3, 43.2, 340.2, 12, "Brown", "", "", "", "LeastConcern", "LC"),
            new(utility, "Macaw", "Military Macaw", "Ara militaris", 45.7, 76.2, 425.2, 1, "Green", "Blue", "Red|White|Black", "", "Vulnerable", "VU"),
            new(utility, "Plover", "Piping plover", "Charadrius melodus", 15.2, 33, 39.7, 1, "", "", "", "", "NearThreatened", "NT"),
            new(utility, "Shearwater", "Spectacled Petrel", "Procellaria conspicillata", 28, 61, 170, 4, "Black", "White", "", "", "Vulnerable", "VU"),
            new(utility, "Crane", "Whooping crane", "Grus americana", 132, 230, 7300, 1, "White", "", "", "", "Endangered", "EN")
        };

        return birds;
    }

    public static List<Bird> LoadImportedBirds()
    {
        var birds = new List<Bird>();
        var utility = new RandomUtility();

        birds.Add(new(utility, "Weaver", "Ibadan Malimbe", "Malimbus ibadanensis", 20, 33, 39.7, 1, "Yellow", "", "", "Nigeria", "Endangered", "EN"));
        birds.Add(new(utility, "Hummingbird", "Bee Hummingbird", "Mellisuga helenae", 8, 10, 23, 2, "Blue", "Black", "", "Cuba", "NearThreatened", "NT"));
        birds.Add(new(utility, "Sunbird", "Olive-bellied Sunbird", "Nectarinia chloropygia", 9, 14, 45, 1, "Green", "Red", "Black", "Angola|Benin|Burundi|Cameroon|Chad|Congo|Ethiopia|Gabon|Gambia|Ghana|Guinea|Kenya|Liberia|Mali|Nigeria|Rwanda|Senegal|Tanzania|Togo|Uganda", "Vulnerable", "VU"));
        birds.Add(new(utility, "Hawk", "Mantled Hawk", "Pseudastur polionotus", 41.9, 78.7, 453.6, 0, "White", "Black", "", "Brazil|Paraguay|Uruguay", "NearThreatened", "NT"));
        birds.Add(new(utility, "Finch", "Zebra Finch", "Taeniopygia guttata", 13, 16, 34, 1, "White", "Grey", "Black|Orange", "Australia|Puerto Rico|Portugal|Brazil|United States", "LeastConcern", "LC"));
        birds.Add(new(utility, "Wren", "Niceforo's Wren", "Thryothorus nicefori", 28, 61, 170, 4, "Brown", "", "", "Colombia", "CriticallyEngandered", "CR"));
        birds.Add(new(utility, "Flycatcher", "Black-and-white Monjita", "Xolmis dominicanus", 20, 23, 54, 1, "Black", "White", "", "Argentina|Brazil|Uruguay", "Vulnerable", "VU"));
        birds.Add(new(utility, "Piper", "Yungas Manakin", "Chiroxiphia boliviana", 18, 25, 53, 4, "Black", "", "", "Peru|Bolivia", "LeastConcern", "LC"));
        birds.Add(new(utility, "Heron", "Reddish Egret", "Egretta rufescens", 132, 230, 730, 1, "Red", "Brown", "", "Bahamas|United States|Mexico", "NearThreatened", "NT"));
        birds.Add(new(utility, "Kingbird", "Loggerhead Kingbird", "Tyrannus caudifasciatus", 23, 38, 42.5, 14, "Brown", "", "", "United States|Mexico", "LeastConcern", "LC"));
        birds.Add(new(utility, "Sparrow", "Golden-crowned Sparrow", "Zonotrichia atricapilla", 18.4, 24, 28.35, 9, "", "", "", "", "LeastConcern", "LC"));
        birds.Add(new(utility, "Cuckoo", "Common Cuckoo", "Cuculus canorus", 33, 66, 141.7, 11, "Black", "White", "Grey", "", "LeastConcern", "LC"));

        return birds;
    }
}
