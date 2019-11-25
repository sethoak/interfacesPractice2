namespace CSharp_InterfacePractice
{
    public interface IDig
    {
        string Name { get; set; }
        string Diet { get; set; }
        bool Poisonous { get; set; }
        int Legs { get; set; }
    }
}