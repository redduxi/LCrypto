namespace ConsoleApp1
{
    public interface ICryptFactory
    {
        ICryptor CreateCryptor(ECryptAlgorithm crypt);
    }
}