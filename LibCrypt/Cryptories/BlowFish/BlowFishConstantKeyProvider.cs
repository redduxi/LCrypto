namespace ConsoleApp1
{
    public class BlowFishConstantKeyProvider : IBlowfishKeyProvider
    {
        private string _key;

        public BlowFishConstantKeyProvider(string key)
        {
            _key = key;
        }

        public string GetBlowFishKey()
        {
            return _key;
        }
    }
}