namespace CSharp_InterfacePractice
{
    public interface IUnderground
    {
        string Name { get; set; }
        string Diet { get; set; }
        bool Poisonous { get; set; }
        int Legs { get; set; }
    }
}