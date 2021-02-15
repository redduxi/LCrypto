namespace ConsoleApp1
{
    public interface ICryptFactory
    {
        ICryptor CreateCryptor(ECryptAlgorythm crypt);
    }
}