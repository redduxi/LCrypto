# LCrypto
Cryptography library include:
- Symmetric encryption algorithms: BlowFish
- Cryptographic hash functions: SHA-1, SHA-224, SHA-256, SHA-384, SHA-512

# Usage

### BlowFish

#### Case 1:
```c#
string value = "a";
ICryptor cryptor = CryptorBuilder.WithKey("FFFFFFFFFF").CreateCryptor(ECryptAlgorithm.BlowFish);
var encrypt = cryptor.Encrypt(value);       
var decrypt = cryptor.Decrypt(encrypt);
```
#### Case 2:
```c#
string value = "a";
ICryptor cryptor = CryptorBuilder.Blowfish;      
var encrypt = cryptor.Encrypt(value);      
var decrypt = cryptor.Decrypt(encrypt);
```
### SHA1
```c#
IHashing hash = HashBuilder.SHA1;
hash.Hashing("a");
```
### SHA224
```c#
IHashing hash = HashBuilder.SHA224;
hash.Hashing("a");
```
### SHA256
```c#
IHashing hash = HashBuilder.SHA256;
hash.Hashing("a");
```
### SHA384
```c#
IHashing hash = HashBuilder.SHA384;
hash.Hashing("a");
```
### SHA512
```c#
IHashing hash = HashBuilder.SHA512;
hash.Hashing("a");
```
## Links to libraries

[BlowFish.cs](https://github.com/redduxi/LCrypto/blob/master/LibCrypt/Libraries/BlowFish/BlowFish.cs)

[SHA1.dll](https://github.com/redduxi/SHA1)

[SHA224.dll](https://github.com/redduxi/SHA224)

[SHA256.dll](https://github.com/redduxi/SHA256)

[SHA384.dll](https://github.com/redduxi/SHA-512)

[SHA512.dll](https://github.com/redduxi/SHA-512)
