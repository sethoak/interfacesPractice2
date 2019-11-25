namespace CSharp_InterfacePractice
{
    public interface ITerrain
    {
        string Name { get; set; }
        string Diet { get; set; }
        bool Poisonous { get; set; }
        int Legs { get; set; }
    }
}