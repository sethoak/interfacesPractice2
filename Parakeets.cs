namespace CSharp_InterfacePractice
{
    public class Parakeets : IAir
    {
        public string Name { get; set; }
        public string Diet { get; set; }
        public bool Poisonous { get; set; }
        public int Legs { get; set; }
    }
}