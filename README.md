# LCrypto
Cryptography library

# Usage

### BlowFish

#### Case 1:

string value = "a";

ICryptor cryptor = CryptorBuilder.WithKey("FFFFFFFFFF").CreateCryptor(ECryptAlgorithm.BlowFish);

var encrypt = cryptor.Encrypt(value);
            
var decrypt = cryptor.Decrypt(encrypt);

#### Case 2:

string value = "a";

ICryptor cryptor = CryptorBuilder.Blowfish;
            
var encrypt = cryptor.Encrypt(value);
            
var decrypt = cryptor.Decrypt(encrypt);

### SHA1

IHashing cryptor = HashBuilder.SHA1;

cryptor.Hashing("a");

### SHA224

IHashing cryptor = HashBuilder.SHA224;

cryptor.Hashing("a");

### SHA256

IHashing cryptor = HashBuilder.SHA256;

cryptor.Hashing("a");
