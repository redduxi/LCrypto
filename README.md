# LCrypto
Cryptography library

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
IHashing cryptor = HashBuilder.SHA1;
cryptor.Hashing("a");
```
### SHA224
```c#
IHashing cryptor = HashBuilder.SHA224;
cryptor.Hashing("a");
```
### SHA256
```c#
IHashing cryptor = HashBuilder.SHA256;
cryptor.Hashing("a");
```
## Links to libraries

[SHA1.dll](https://github.com/redduxi/SHA1)

[SHA224.dll](https://github.com/redduxi/SHA224)

[SHA256.dll](https://github.com/redduxi/SHA256)
