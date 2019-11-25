namespace CSharp_InterfacePractice
{
    public class Gerbils : IUnderground, ITerrain, IWater
    {
        public string Name { get; set; }
        public string Diet { get; set; }
        public bool Poisonous { get; set; }
        public int Legs { get; set; }
    }
}