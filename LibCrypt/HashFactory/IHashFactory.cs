namespace ConsoleApp1
{
    public interface IHashFactory
    {
        IHashing CreateHashing(EHashAlgorithm hash);
    }
}