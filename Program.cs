using System;
using System.Collections.Generic;

namespace CSharp_InterfacePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IDig> diggers = new List<IDig>();
            List<IUnderground> dwellers = new List<IUnderground>();
            List<ITerrain> grounders = new List<ITerrain>();
            List<IWater> swimmers = new List<IWater>();
            List<IAir> flyers = new List<IAir>();
            List<IDigAndGround> digLanders = new List<IDigAndGround>();

            var parakeets = new Parakeets();
            var earthworms = new Earthworms();
            var terrapins = new Terrapins();
            var timberRattlesnakes = new TimberRattlesnakes();
            var mice = new Mice();
            var ants = new Ants();
            var finches = new Finches();
            var bettaFish = new BettaFish();
            var copperheadSnakes = new CopperheadSnakes();
            var gerbils = new Gerbils();

            diggers.Add(earthworms);
            diggers.Add(ants);

            dwellers.Add(earthworms);
            dwellers.Add(timberRattlesnakes);
            dwellers.Add(copperheadSnakes);
            dwellers.Add(mice);
            dwellers.Add(gerbils);
            dwellers.Add(ants);

            grounders.Add(timberRattlesnakes);
            grounders.Add(mice);
            grounders.Add(ants);
            grounders.Add(copperheadSnakes);
            grounders.Add(gerbils);

            swimmers.Add(timberRattlesnakes);
            swimmers.Add(mice);
            swimmers.Add(bettaFish);
            swimmers.Add(copperheadSnakes);
            swimmers.Add(gerbils);

            flyers.Add(parakeets);
            flyers.Add(terrapins);
            flyers.Add(finches);

            digLanders.Add(ants);
        }
    }
}
