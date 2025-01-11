using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using WebfishingGuide.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebfishingGuide.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FishController : ControllerBase
    {
        List<Fish> fish = new List<Fish>();

        public FishController() 
        {
            fish.Add(new Fish {
				Species = "Alligator", Description = "The alligator is a type of fish that can only be caught in freshwater.",
				Category = "Freshwater",
				BaseCatchRate = 0.00511,
				SparklingLureRate = 0.01439,
				FlyHookRate = 0.00031,
				LargeLureRate = 0.01433,
				MagnetHookRate = 0.00448,
				GoldenHookRate = 0.00509
			});

            fish.Add(new Fish { 
				Species = "Axolotl", Description = "The axolotl is a type of fish that can only be caught in freshwater.",
				Category = "Freshwater",
				BaseCatchRate = 0.00715,
				SparklingLureRate = 0.02015,
				FlyHookRate = 0.00598,
				LargeLureRate = 0.00571,
				MagnetHookRate = 0.00627,
				GoldenHookRate = 0.00713 
			});

            fish.Add(new Fish { 
				Species = "Bluegill", Description = "The bluegill is a type of fish that can only be caught in freshwater.",
				Category = "Freshwater",
				BaseCatchRate = 0.05873,
				SparklingLureRate = 0.03293,
				FlyHookRate = 0.08575,
				LargeLureRate = 0.01955,
				MagnetHookRate = 0.05148,
				GoldenHookRate = 0.05854 
			});

            fish.Add(new Fish { 
				Species = "Bowfin", Description = "The bowfin is a type of fish that can only be caught in freshwater.",
				Category = "Freshwater",
				BaseCatchRate = 0.02553,
				SparklingLureRate = 0.05472,
				FlyHookRate = 0.00656,
				LargeLureRate = 0.04856,
				MagnetHookRate = 0.02238,
				GoldenHookRate = 0.02545 
			});

            fish.Add(new Fish { 
				Species = "Bull Shark", Description = "The bull shark is a type of fish that can only be caught in freshwater.",
				Category = "Freshwater",
				BaseCatchRate = 0.00409,
				SparklingLureRate = 0.01151,
				FlyHookRate = 0.00026,
				LargeLureRate = 0.01142,
				MagnetHookRate = 0.00358,
				GoldenHookRate = 0.00407 
			});

            fish.Add(new Fish { 
				Species = "Carp", Description = "The carp is a type of fish that can only be caught in freshwater.",
				Category = "Freshwater",
				BaseCatchRate = 0.06384,
				SparklingLureRate = 0.03579,
				FlyHookRate = 0.02608,
				LargeLureRate = 0.09423,
				MagnetHookRate = 0.05595,
				GoldenHookRate = 0.06363 
			});

            fish.Add(new Fish { 
				Species = "Catfish", Description = "The catfish is a type of fish that can only be caught in freshwater.",
				Category = "Freshwater",
				BaseCatchRate = 0.01787,
				SparklingLureRate = 0.01002,
				FlyHookRate = 0.00572,
				LargeLureRate = 0.0305,
				MagnetHookRate = 0.01567,
				GoldenHookRate = 0.01782 
			});

            fish.Add(new Fish { 
				Species = "Crab", Description = "The crab is a type of fish that can only be caught in freshwater.",
				Category = "Freshwater",
				BaseCatchRate = 0.0332,
				SparklingLureRate = 0.07113,
				FlyHookRate = 0.06744,
				LargeLureRate = 0.00391,
				MagnetHookRate = 0.02909,
				GoldenHookRate = 0.03309 
			});

            fish.Add(new Fish { 
				Species = "Crappie", Description = "The crappie is a type of fish that can only be caught in freshwater.",
				Category = "Freshwater",
				BaseCatchRate = 0.02809,
				SparklingLureRate = 0.06019,
				FlyHookRate = 0.0278,
				LargeLureRate = 0.01827,
				MagnetHookRate = 0.02462,
				GoldenHookRate = 0.028 
			});

            fish.Add(new Fish { 
				Species = "Crayfish", Description = "The crayfish is a type of fish that can only be caught in freshwater.",
				Category = "Freshwater",
				BaseCatchRate = 0.04086,
				SparklingLureRate = 0.02291,
				FlyHookRate = 0.07508,
				LargeLureRate = 0.00714,
				MagnetHookRate = 0.03581,
				GoldenHookRate = 0.04072 
			});

            fish.Add(new Fish { 
				Species = "Drum", Description = "The drum is a type of fish that can only be caught in freshwater.",
				Category = "Freshwater",
				BaseCatchRate = 0.04086,
				SparklingLureRate = 0.02291,
				FlyHookRate = 0.04043,
				LargeLureRate = 0.02658,
				MagnetHookRate = 0.03581,
				GoldenHookRate = 0.04072 
			});

            fish.Add(new Fish { 
				Species = "Frog", Description = "The frog is a type of fish that can only be caught in freshwater.",
				Category = "Freshwater",
				BaseCatchRate = 0.02043,
				SparklingLureRate = 0.01145,
				FlyHookRate = 0.0462,
				LargeLureRate = 0.00137,
				MagnetHookRate = 0.0179,
				GoldenHookRate = 0.02036 
			});

            fish.Add(new Fish { 
				Species = "Gar", Description = "The gar is a type of fish that can only be caught in freshwater.",
				Category = "Freshwater",
				BaseCatchRate = 0.00919,
				SparklingLureRate = 0.0259,
				FlyHookRate = 0.00076,
				LargeLureRate = 0.02457,
				MagnetHookRate = 0.00806,
				GoldenHookRate = 0.00916 
			});

            fish.Add(new Fish { 
				Species = "Golden Bass", Description = "The golden bass is a type of fish that can only be caught in freshwater.",
				Category = "Freshwater",
				BaseCatchRate = 0.00153,
				SparklingLureRate = 0.00432,
				FlyHookRate = 0.00082,
				LargeLureRate = 0.00187,
				MagnetHookRate = 0.00134,
				GoldenHookRate = 0.00459 
			});

            fish.Add(new Fish { 
				Species = "Goldfish", Description = "The goldfish is a type of fish that can only be caught in freshwater.",
				Category = "Freshwater",
				BaseCatchRate = 0.04596,
				SparklingLureRate = 0.02577,
				FlyHookRate = 0.06711,
				LargeLureRate = 0.0153,
				MagnetHookRate = 0.04029,
				GoldenHookRate = 0.04581 
			});

            fish.Add(new Fish { 
				Species = "Guppy", Description = "The guppy is a type of fish that can only be caught in freshwater.",
				Category = "Freshwater",
				BaseCatchRate = 0.0332,
				SparklingLureRate = 0.01861,
				FlyHookRate = 0.08422,
				LargeLureRate = 0.00086,
				MagnetHookRate = 0.02909,
				GoldenHookRate = 0.03309 
			});

            fish.Add(new Fish { 
				Species = "King Salmon", Description = "The king salmon is a type of fish that can only be caught in freshwater.",
				Category = "Freshwater",
				BaseCatchRate = 0.01634,
				SparklingLureRate = 0.04605,
				FlyHookRate = 0.0021,
				LargeLureRate = 0.03963,
				MagnetHookRate = 0.01432,
				GoldenHookRate = 0.01629 
			});

            fish.Add(new Fish { 
				Species = "Koi", Description = "The koi is a type of fish that can only be caught in freshwater.",
				Category = "Freshwater",
				BaseCatchRate = 0.01277,
				SparklingLureRate = 0.00716,
				FlyHookRate = 0.01068,
				LargeLureRate = 0.0102,
				MagnetHookRate = 0.01119,
				GoldenHookRate = 0.01273 
			});

            fish.Add(new Fish { 
				Species = "Largemouth Bass", Description = "The largemouth bass is a type of fish that can only be caught in freshwater.",
				Category = "Freshwater",
				BaseCatchRate = 0.06384,
				SparklingLureRate = 0.03579,
				FlyHookRate = 0.03412,
				LargeLureRate = 0.07773,
				MagnetHookRate = 0.05595,
				GoldenHookRate = 0.06363 
			});

            fish.Add(new Fish { 
				Species = "Leech", Description = "The leech is a type of fish that can only be caught in freshwater.",
				Category = "Freshwater",
				BaseCatchRate = 0.02043,
				SparklingLureRate = 0.04377,
				FlyHookRate = 0.0489,
				LargeLureRate = 0.00092,
				MagnetHookRate = 0.0179,
				GoldenHookRate = 0.02036 
			});

            fish.Add(new Fish { 
				Species = "Mooneye", Description = "The mooneye is a type of fish that can only be caught in freshwater.",
				Category = "Freshwater",
				BaseCatchRate = 0.00715,
				SparklingLureRate = 0.02015,
				FlyHookRate = 0.00598,
				LargeLureRate = 0.00571,
				MagnetHookRate = 0.00627,
				GoldenHookRate = 0.00713 
			});

            fish.Add(new Fish { 
				Species = "Muskellunge", Description = "The muskellunge is a type of fish that can only be caught in freshwater.",
				Category = "Freshwater",
				BaseCatchRate = 0.00766,
				SparklingLureRate = 0.01642,
				FlyHookRate = 0.00127,
				LargeLureRate = 0.01724,
				MagnetHookRate = 0.00671,
				GoldenHookRate = 0.00764 
			});

            fish.Add(new Fish { 
				Species = "Perch", Description = "The perch is a type of fish that can only be caught in freshwater.",
				Category = "Freshwater",
				BaseCatchRate = 0.05873,
				SparklingLureRate = 0.03293,
				FlyHookRate = 0.06987,
				LargeLureRate = 0.02907,
				MagnetHookRate = 0.05148,
				GoldenHookRate = 0.05854 
			});

            fish.Add(new Fish { 
				Species = "Pike", Description = "The pike is a type of fish that can only be caught in freshwater.",
				Category = "Freshwater",
				BaseCatchRate = 0.02553,
				SparklingLureRate = 0.05472,
				FlyHookRate = 0.01044,
				LargeLureRate = 0.03769,
				MagnetHookRate = 0.02238,
				GoldenHookRate = 0.02545 
			});

            fish.Add(new Fish { 
				Species = "Pupfish", Description = "The pupfish is a type of fish that can only be caught in freshwater.",
				Category = "Freshwater",
				BaseCatchRate = 0.00715,
				SparklingLureRate = 0.02015,
				FlyHookRate = 0.01531,
				LargeLureRate = 0.00065,
				MagnetHookRate = 0.00627,
				GoldenHookRate = 0.00713 
			});

            fish.Add(new Fish { 
				Species = "Rainbow Trout", Description = "The rainbow trout is a type of fish that can only be caught in freshwater.",
				Category = "Freshwater",
				BaseCatchRate = 0.06384,
				SparklingLureRate = 0.03579,
				FlyHookRate = 0.02303,
				LargeLureRate = 0.10183,
				MagnetHookRate = 0.05595,
				GoldenHookRate = 0.06363 
			});

            fish.Add(new Fish { 
				Species = "Salmon", Description = "The salmon is a type of fish that can only be caught in freshwater.",
				Category = "Freshwater",
				BaseCatchRate = 0.0766,
				SparklingLureRate = 0.04295,
				FlyHookRate = 0.02194,
				LargeLureRate = 0.13853,
				MagnetHookRate = 0.06714,
				GoldenHookRate = 0.07635 
			});

            fish.Add(new Fish { 
				Species = "Snail", Description = "The snail is a type of fish that can only be caught in freshwater.",
				Category = "Freshwater",
				BaseCatchRate = 0.03064,
				SparklingLureRate = 0.01718,
				FlyHookRate = 0.0778,
				LargeLureRate = 0.00079,
				MagnetHookRate = 0.02686,
				GoldenHookRate = 0.03054 
			});

            fish.Add(new Fish { 
				Species = "Sturgeon", Description = "The sturgeon is a type of fish that can only be caught in freshwater.",
				Category = "Freshwater",
				BaseCatchRate = 0.01021,
				SparklingLureRate = 0.00573,
				FlyHookRate = 0.001,
				LargeLureRate = 0.02643,
				MagnetHookRate = 0.00895,
				GoldenHookRate = 0.01018 
			});

            fish.Add(new Fish { 
				Species = "Toad", Description = "The toad is a type of fish that can only be caught in freshwater.",
				Category = "Freshwater",
				BaseCatchRate = 0.01787,
				SparklingLureRate = 0.0383,
				FlyHookRate = 0.03285,
				LargeLureRate = 0.00312,
				MagnetHookRate = 0.01567,
				GoldenHookRate = 0.01782 
			});

            fish.Add(new Fish { 
				Species = "Turtle", Description = "The turtle is a type of fish that can only be caught in freshwater.",
				Category = "Freshwater",
				BaseCatchRate = 0.01787,
				SparklingLureRate = 0.0383,
				FlyHookRate = 0.01833,
				LargeLureRate = 0.01108,
				MagnetHookRate = 0.01567,
				GoldenHookRate = 0.01782 
			});

            fish.Add(new Fish { 
				Species = "Walleye", Description = "The walleye is a type of fish that can only be caught in freshwater.",
				Category = "Freshwater",
				BaseCatchRate = 0.05873,
				SparklingLureRate = 0.03293,
				FlyHookRate = 0.01685,
				LargeLureRate = 0.10621,
				MagnetHookRate = 0.05148,
				GoldenHookRate = 0.05854 
			});

            fish.Add(new Fish { 
				Species = "Angelfish", Description = "The angelfish is a type of fish that can only be caught in saltwater.",
				Category = "Saltwater",
				BaseCatchRate = 0.04684,
				SparklingLureRate = 0.02214,
				FlyHookRate = 0.08153,
				LargeLureRate = 0.01037,
				MagnetHookRate = 0.04105,
				GoldenHookRate = 0.04668 
			});

            fish.Add(new Fish { 
				Species = "Atlantic Salmon", Description = "The atlantic salmon is a type of fish that can only be caught in saltwater.",
				Category = "Saltwater",
				BaseCatchRate = 0.06245,
				SparklingLureRate = 0.02952,
				FlyHookRate = 0.07172,
				LargeLureRate = 0.0336,
				MagnetHookRate = 0.05473,
				GoldenHookRate = 0.06224 
			});

            fish.Add(new Fish { 
				Species = "Bluefish", Description = "The bluefish is a type of fish that can only be caught in saltwater.",
				Category = "Saltwater",
				BaseCatchRate = 0.03903,
				SparklingLureRate = 0.01845,
				FlyHookRate = 0.01919,
				LargeLureRate = 0.04869,
				MagnetHookRate = 0.03421,
				GoldenHookRate = 0.0389 
			});

            fish.Add(new Fish { 
				Species = "Clownfish", Description = "The clownfish is a type of fish that can only be caught in saltwater.",
				Category = "Saltwater",
				BaseCatchRate = 0.05204,
				SparklingLureRate = 0.0246,
				FlyHookRate = 0.10626,
				LargeLureRate = 0.00627,
				MagnetHookRate = 0.04561,
				GoldenHookRate = 0.05187 
			});

            fish.Add(new Fish { 
				Species = "Coelacanth", Description = "The coelacanth is a type of fish that can only be caught in saltwater.",
				Category = "Saltwater",
				BaseCatchRate = 0.0052,
				SparklingLureRate = 0.01455,
				FlyHookRate = 0.001,
				LargeLureRate = 0.01043,
				MagnetHookRate = 0.00456,
				GoldenHookRate = 0.00519 
			});

            fish.Add(new Fish { 
				Species = "Dogfish", Description = "The dogfish is a type of fish that can only be caught in saltwater.",
				Category = "Saltwater",
				BaseCatchRate = 0.01561,
				SparklingLureRate = 0.00738,
				FlyHookRate = 0.0082,
				LargeLureRate = 0.01859,
				MagnetHookRate = 0.01368,
				GoldenHookRate = 0.01556 
			});

            fish.Add(new Fish { 
				Species = "Eel", Description = "The eel is a type of fish that can only be caught in saltwater.",
				Category = "Saltwater",
				BaseCatchRate = 0.01821,
				SparklingLureRate = 0.00861,
				FlyHookRate = 0.01397,
				LargeLureRate = 0.01587,
				MagnetHookRate = 0.01596,
				GoldenHookRate = 0.01815 
			});

            fish.Add(new Fish { 
				Species = "Flounder", Description = "The flounder is a type of fish that can only be caught in saltwater.",
				Category = "Saltwater",
				BaseCatchRate = 0.05985,
				SparklingLureRate = 0.02829,
				FlyHookRate = 0.05522,
				LargeLureRate = 0.04295,
				MagnetHookRate = 0.05245,
				GoldenHookRate = 0.05965 
			});

            fish.Add(new Fish { 
				Species = "Golden Manta Ray", Description = "The golden manta ray is a type of fish that can only be caught in saltwater.",
				Category = "Saltwater",
				BaseCatchRate = 0.00156,
				SparklingLureRate = 0.00437,
				FlyHookRate = 0.00009,
				LargeLureRate = 0.00434,
				MagnetHookRate = 0.00137,
				GoldenHookRate = 0.00468 
			});

            fish.Add(new Fish { 
				Species = "Great White Shark", Description = "The great white shark is a type of fish that can only be caught in saltwater.",
				Category = "Saltwater",
				BaseCatchRate = 0.00624,
				SparklingLureRate = 0.01747,
				FlyHookRate = 0.0012,
				LargeLureRate = 0.01251,
				MagnetHookRate = 0.00547,
				GoldenHookRate = 0.00622 
			});

            fish.Add(new Fish { 
				Species = "Grouper", Description = "The grouper is a type of fish that can only be caught in saltwater.",
				Category = "Saltwater",
				BaseCatchRate = 0.04684,
				SparklingLureRate = 0.02214,
				FlyHookRate = 0.01707,
				LargeLureRate = 0.07031,
				MagnetHookRate = 0.04105,
				GoldenHookRate = 0.04668 
			});

            fish.Add(new Fish { 
				Species = "Hammerhead Shark", Description = "The hammerhead shark is a type of fish that can only be caught in saltwater.",
				Category = "Saltwater",
				BaseCatchRate = 0.01821,
				SparklingLureRate = 0.03604,
				FlyHookRate = 0.00183,
				LargeLureRate = 0.0446,
				MagnetHookRate = 0.01596,
				GoldenHookRate = 0.01815 
			});

            fish.Add(new Fish { 
				Species = "Herring", Description = "The herring is a type of fish that can only be caught in saltwater.",
				Category = "Saltwater",
				BaseCatchRate = 0.06245,
				SparklingLureRate = 0.02952,
				FlyHookRate = 0.08135,
				LargeLureRate = 0.0273,
				MagnetHookRate = 0.05473,
				GoldenHookRate = 0.06224 
			});

            fish.Add(new Fish { 
				Species = "Krill", Description = "The krill is a type of fish that can only be caught in saltwater.",
				Category = "Saltwater",
				BaseCatchRate = 0.04163,
				SparklingLureRate = 0.01968,
				FlyHookRate = 0.11265,
				LargeLureRate = 0.00039,
				MagnetHookRate = 0.03649,
				GoldenHookRate = 0.04149 
			});

            fish.Add(new Fish { 
				Species = "Lionfish", Description = "The lionfish is a type of fish that can only be caught in saltwater.",
				Category = "Saltwater",
				BaseCatchRate = 0.02602,
				SparklingLureRate = 0.05149,
				FlyHookRate = 0.0339,
				LargeLureRate = 0.01138,
				MagnetHookRate = 0.02281,
				GoldenHookRate = 0.02593 
			});

            fish.Add(new Fish { 
				Species = "Lobster", Description = "The lobster is a type of fish that can only be caught in saltwater.",
				Category = "Saltwater",
				BaseCatchRate = 0.03643,
				SparklingLureRate = 0.01722,
				FlyHookRate = 0.02051,
				LargeLureRate = 0.04125,
				MagnetHookRate = 0.03193,
				GoldenHookRate = 0.03631 
			});

            fish.Add(new Fish { 
				Species = "Man O War", Description = "The man o' war is a type of fish that can only be caught in saltwater.",
				Category = "Saltwater",
				BaseCatchRate = 0.01041,
				SparklingLureRate = 0.02911,
				FlyHookRate = 0.01195,
				LargeLureRate = 0.0056,
				MagnetHookRate = 0.00912,
				GoldenHookRate = 0.01037 
			});

            fish.Add(new Fish { 
				Species = "Manta Ray", Description = "The manta ray is a type of fish that can only be caught in saltwater.",
				Category = "Saltwater",
				BaseCatchRate = 0.00937,
				SparklingLureRate = 0.0262,
				FlyHookRate = 0.00052,
				LargeLureRate = 0.02604,
				MagnetHookRate = 0.00821,
				GoldenHookRate = 0.00934 
			});

            fish.Add(new Fish { 
				Species = "Marlin", Description = "The marlin is a type of fish that can only be caught in saltwater.",
				Category = "Saltwater",
				BaseCatchRate = 0.03122,
				SparklingLureRate = 0.06179,
				FlyHookRate = 0.00391,
				LargeLureRate = 0.07201,
				MagnetHookRate = 0.02737,
				GoldenHookRate = 0.03112 
			});

            fish.Add(new Fish { 
				Species = "Octopus", Description = "The octopus is a type of fish that can only be caught in saltwater.",
				Category = "Saltwater",
				BaseCatchRate = 0.03122,
				SparklingLureRate = 0.06179,
				FlyHookRate = 0.01277,
				LargeLureRate = 0.04388,
				MagnetHookRate = 0.02737,
				GoldenHookRate = 0.03112 
			});

            fish.Add(new Fish { 
				Species = "Oyster", Description = "The oyster is a type of fish that can only be caught in saltwater.",
				Category = "Saltwater",
				BaseCatchRate = 0.04163,
				SparklingLureRate = 0.01968,
				FlyHookRate = 0.07722,
				LargeLureRate = 0.00746,
				MagnetHookRate = 0.03649,
				GoldenHookRate = 0.04149 
			});

            fish.Add(new Fish { 
				Species = "Sawfish", Description = "The sawfish is a type of fish that can only be caught in saltwater.",
				Category = "Saltwater",
				BaseCatchRate = 0.00781,
				SparklingLureRate = 0.00369,
				FlyHookRate = 0.00098,
				LargeLureRate = 0.018,
				MagnetHookRate = 0.00684,
				GoldenHookRate = 0.00778 
			});

            fish.Add(new Fish { 
				Species = "Sea Turtle", Description = "The sea turtle is a type of fish that can only be caught in saltwater.",
				Category = "Saltwater",
				BaseCatchRate = 0.01301,
				SparklingLureRate = 0.03639,
				FlyHookRate = 0.00532,
				LargeLureRate = 0.01828,
				MagnetHookRate = 0.0114,
				GoldenHookRate = 0.01297 
			});

            fish.Add(new Fish { 
				Species = "Seahorse", Description = "The seahorse is a type of fish that can only be caught in saltwater.",
				Category = "Saltwater",
				BaseCatchRate = 0.03643,
				SparklingLureRate = 0.07208,
				FlyHookRate = 0.05452,
				LargeLureRate = 0.01203,
				MagnetHookRate = 0.03193,
				GoldenHookRate = 0.03631 
			});

            fish.Add(new Fish { 
				Species = "Shrimp", Description = "The shrimp is a type of fish that can only be caught in saltwater.",
				Category = "Saltwater",
				BaseCatchRate = 0.05204,
				SparklingLureRate = 0.0246,
				FlyHookRate = 0.10628,
				LargeLureRate = 0.00626,
				MagnetHookRate = 0.04561,
				GoldenHookRate = 0.05187 
			});

            fish.Add(new Fish { 
				Species = "Squid", Description = "The squid is a type of fish that can only be caught in saltwater.",
				Category = "Saltwater",
				BaseCatchRate = 0.01301,
				SparklingLureRate = 0.03639,
				FlyHookRate = 0.00182,
				LargeLureRate = 0.02907,
				MagnetHookRate = 0.0114,
				GoldenHookRate = 0.01297 
			});

            fish.Add(new Fish { 
				Species = "Sting Ray", Description = "The sting ray is a type of fish that can only be caught in saltwater.",
				Category = "Saltwater",
				BaseCatchRate = 0.03122,
				SparklingLureRate = 0.06179,
				FlyHookRate = 0.00768,
				LargeLureRate = 0.05683,
				MagnetHookRate = 0.02737,
				GoldenHookRate = 0.03112 
			});

            fish.Add(new Fish { 
				Species = "Sunfish", Description = "The sunfish is a type of fish that can only be caught in saltwater.",
				Category = "Saltwater",
				BaseCatchRate = 0.02082,
				SparklingLureRate = 0.00984,
				FlyHookRate = 0.00375,
				LargeLureRate = 0.04281,
				MagnetHookRate = 0.01824,
				GoldenHookRate = 0.02075 
			});

            fish.Add(new Fish { 
				Species = "Swordfish", Description = "The swordfish is a type of fish that can only be caught in saltwater.",
				Category = "Saltwater",
				BaseCatchRate = 0.03383,
				SparklingLureRate = 0.06693,
				FlyHookRate = 0.00372,
				LargeLureRate = 0.08109,
				MagnetHookRate = 0.02965,
				GoldenHookRate = 0.03371 
			});

            fish.Add(new Fish { 
				Species = "Tuna", Description = "The tuna is a type of fish that can only be caught in saltwater.",
				Category = "Saltwater",
				BaseCatchRate = 0.03643,
				SparklingLureRate = 0.01722,
				FlyHookRate = 0.00897,
				LargeLureRate = 0.0663,
				MagnetHookRate = 0.03193,
				GoldenHookRate = 0.03631 
			});

            fish.Add(new Fish { 
				Species = "Whale", Description = "The whale is a type of fish that can only be caught in saltwater.",
				Category = "Saltwater",
				BaseCatchRate = 0.00572,
				SparklingLureRate = 0.01601,
				FlyHookRate = 0.00022,
				LargeLureRate = 0.01677,
				MagnetHookRate = 0.00502,
				GoldenHookRate = 0.00571 
			});

            fish.Add(new Fish { 
				Species = "Wolffish", Description = "The wolffish is a type of fish that can only be caught in saltwater.",
				Category = "Saltwater",
				BaseCatchRate = 0.01821,
				SparklingLureRate = 0.03604,
				FlyHookRate = 0.00567,
				LargeLureRate = 0.02973,
				MagnetHookRate = 0.01596,
				GoldenHookRate = 0.01815 
			});

            fish.Add(new Fish { 
				Species = "Anomalocaris", Description = "The anomalocaris is a type of fish that can only be caught when it is raining.",
				Category = "Rain",
				BaseCatchRate = 0.0324,
				SparklingLureRate = 0.02213,
				FlyHookRate = 0.03869,
				LargeLureRate = 0.02238,
				MagnetHookRate = 0.03174,
				GoldenHookRate = 0.02926 
			});

            fish.Add(new Fish { 
				Species = "Helicoprion", Description = "The helicoprion is a type of fish that can only be caught when it is raining.",
				Category = "Rain",
				BaseCatchRate = 0.00972,
				SparklingLureRate = 0.02305,
				FlyHookRate = 0.00083,
				LargeLureRate = 0.02277,
				MagnetHookRate = 0.00952,
				GoldenHookRate = 0.00878 
			});

            fish.Add(new Fish { 
				Species = "Horseshoe Crab", Description = "The horseshoe crab is a type of fish that can only be caught when it is raining.",
				Category = "Rain",
				BaseCatchRate = 0.0324,
				SparklingLureRate = 0.02213,
				FlyHookRate = 0.03872,
				LargeLureRate = 0.02237,
				MagnetHookRate = 0.03174,
				GoldenHookRate = 0.02926 
			});

            fish.Add(new Fish { 
				Species = "Leedsichthys", Description = "The leedsichthys is a type of fish that can only be caught when it is raining.",
				Category = "Rain",
				BaseCatchRate = 0.00389,
				SparklingLureRate = 0.01109,
				FlyHookRate = 0.00017,
				LargeLureRate = 0.01088,
				MagnetHookRate = 0.00381,
				GoldenHookRate = 0.01109 
			});

            fish.Add(new Fish { 
				Species = "Bone", Description = "The Bone is a type of trash item that can be caught while fishing.",
				Category = "Junk",
				BaseCatchRate = 0.00207,
				SparklingLureRate = 0.00207,
				FlyHookRate = 0.00195,
				LargeLureRate = 0.00124,
				MagnetHookRate = 0.00607,
				GoldenHookRate = 0.00194 
			});

            fish.Add(new Fish { 
				Species = "Branch", Description = "The Branch is a type of trash item that can be caught while fishing.",
				Category = "Junk",
				BaseCatchRate = 0.00826,
				SparklingLureRate = 0.00826,
				FlyHookRate = 0.00038,
				LargeLureRate = 0.01949,
				MagnetHookRate = 0.02428,
				GoldenHookRate = 0.00777 
			});

            fish.Add(new Fish { 
				Species = "Diamond", Description = "The Diamond is a type of trash item that can be caught while fishing.",
				Category = "Junk",
				BaseCatchRate = 0.00149,
				SparklingLureRate = 0.00149,
				FlyHookRate = 0,
				LargeLureRate = 0.00433,
				MagnetHookRate = 0.00437,
				GoldenHookRate = 0.00433 
			});

            fish.Add(new Fish { 
				Species = "Drink Rings", Description = "The Drink Rings is a type of trash item that can be caught while fishing.",
				Category = "Junk",
				BaseCatchRate = 0.00826,
				SparklingLureRate = 0.00826,
				FlyHookRate = 0.00276,
				LargeLureRate = 0.01141,
				MagnetHookRate = 0.02428,
				GoldenHookRate = 0.00777 
			});

            fish.Add(new Fish { 
				Species = "Old Boot", Description = "The Old Boot is a type of trash item that can be caught while fishing.",
				Category = "Junk",
				BaseCatchRate = 0.00413,
				SparklingLureRate = 0.00413,
				FlyHookRate = 0.00138,
				LargeLureRate = 0.00571,
				MagnetHookRate = 0.01214,
				GoldenHookRate = 0.00388 
			});

            fish.Add(new Fish { 
				Species = "Plastic Bag", Description = "The Plastic Bag is a type of trash item that can be caught while fishing.",
				Category = "Junk",
				BaseCatchRate = 0.00826,
				SparklingLureRate = 0.00826,
				FlyHookRate = 0.00779,
				LargeLureRate = 0.00495,
				MagnetHookRate = 0.02428,
				GoldenHookRate = 0.00777 
			});

            fish.Add(new Fish { 
				Species = "Soda Can", Description = "The Soda Can is a type of trash item that can be caught while fishing.",
				Category = "Junk",
				BaseCatchRate = 0.00826,
				SparklingLureRate = 0.00826,
				FlyHookRate = 0.02084,
				LargeLureRate = 0.00023,
				MagnetHookRate = 0.02428,
				GoldenHookRate = 0.00777 
			});

            fish.Add(new Fish { 
				Species = "Weed", Description = "The Weed is a type of trash item that can be caught while fishing.",
				Category = "Junk",
				BaseCatchRate = 0.00826,
				SparklingLureRate = 0.00826,
				FlyHookRate = 0.01389,
				LargeLureRate = 0.00164,
				MagnetHookRate = 0.02428,
				GoldenHookRate = 0.00777 
			});

            fish.Add(new Fish { 
				Species = "CREATURE", Description = "The CREATURE is a type of fish that can only be caught in the Void. The Void can be accessed via a Void Portal.",
				Category = "Miscellaneous",
				BaseCatchRate = 0.02328,
				SparklingLureRate = 0.02328,
				FlyHookRate = 0.02328,
				LargeLureRate = 0.02328,
				MagnetHookRate = 0.0204,
				GoldenHookRate = 0.02328 
			});

            fish.Add(new Fish { 
				Species = "Unidentified Fish Object", Description = "The Unidentified Fish Object is a type of fish that can only be caught from meteor events. Meteor events occur randomly. When a meteor event occurs, a message will appear in the chat that reads, \"What was that...?\" You then have 2 minutes to locate the meteor in the water and catch the Unidentified Fish Object before the meteor will despawn.",
				Category = "Miscellaneous",
				BaseCatchRate = 1,
				SparklingLureRate = 1,
				FlyHookRate = 1,
				LargeLureRate = 1,
				MagnetHookRate = 1,
				GoldenHookRate = 1 
			});

        }//end constructor


        // GET: api/<FishController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<FishController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<FishController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<FishController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<FishController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }


        // GET api/FishController/GetFishByName/speciesName
        [HttpGet, Route("GetFishByName/{speciesName}")]
        public string GetFishByName(string speciesName)
        {
            foreach(Fish currFish in fish)
            {
                if(currFish.Species == speciesName)
                    return JsonSerializer.Serialize(currFish);
            }
            return "Error--No such fish.";            
        }

        // GET api/FishController/GetAllFish
        [HttpGet, Route("GetAllFish")]
        public IEnumerable<Fish> GetAllFish()
        {
            return fish;
        }

    }
}
