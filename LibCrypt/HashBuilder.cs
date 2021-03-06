﻿namespace ConsoleApp1
{
    public class HashBuilder
    {
        public static IHashing SHA1
        {
            get
            {
                return new MyHashFactory().CreateHashing(EHashAlgorithm.SHA1);
            }
        }
        
        public static IHashing SHA224
        {
            get
            {
                return new MyHashFactory().CreateHashing(EHashAlgorithm.SHA224);
            }
        }
        
        public static IHashing SHA256
        {
            get
            {
                return new MyHashFactory().CreateHashing(EHashAlgorithm.SHA256);
            }
        }
        
        public static IHashing SHA384
        {
            get
            {
                return new MyHashFactory().CreateHashing(EHashAlgorithm.SHA384);
            }
        }
        
        public static IHashing SHA512
        {
            get
            {
                return new MyHashFactory().CreateHashing(EHashAlgorithm.SHA512);
            }
        }
    }
}