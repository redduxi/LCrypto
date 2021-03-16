using System;
using ConsoleApp1.Libraries;
using ConsoleApp1.Libraries.SHA224;
using ConsoleApp1.Libraries.SHA256;
using ConsoleApp1.Libraries.SHA384;

namespace ConsoleApp1
{
    public class MyHashFactory : IHashFactory
    {
        public string Hashing(string text)
        {
            throw new System.NotImplementedException();
        }
        
        public IHashing CreateHashing(EHashAlgorithm hash)
        {
            switch (hash)
            {
                case EHashAlgorithm.SHA1:
                    return new SHA1Adapter();
                    break;
                case EHashAlgorithm.SHA224:
                    return new SHA224Adapter();
                break;
                case EHashAlgorithm.SHA256:
                    return new SHA256Adapter();
                break;
                case EHashAlgorithm.SHA512:
                    return new SHA512Adapter();
                break;
                case EHashAlgorithm.SHA384:
                    return new SHA384Adapter();
                default:
                    throw new ArgumentOutOfRangeException(nameof(hash), hash, null);
            }
        }

    }
}