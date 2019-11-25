namespace CSharp_InterfacePractice
{
    public interface IWater
    {
        string Name { get; set; }
        string Diet { get; set; }
        bool Poisonous { get; set; }
        int Legs { get; set; }
    }
}