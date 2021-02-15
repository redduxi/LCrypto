namespace ConsoleApp1
{
    
    public static class MyLibraryBuilder
    {
        public static ICryptor Blowfish
        {
            get
            {
                return new MyCryptFactory(new BlowFishConstantKeyProvider("FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF"),null ).CreateCryptor(ECryptAlgorythm.BlowFish);
            }
        }

        public static ICryptFactory WithKey(string key)
        {
            return new MyCryptFactory(new BlowFishConstantKeyProvider(key),null );
        }
    }
}