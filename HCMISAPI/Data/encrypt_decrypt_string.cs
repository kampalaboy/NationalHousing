using Blazor.SubtleCrypto;
using System.Security.Cryptography;
using System.Text;

namespace HCMISAPI.Data
{
    public class encrypt_decrypt_string
    {
        private readonly ICryptoService Crypto;
        //private string publickey = "**Root@1";
        //private string secretkey = "1@tooR**";
        public encrypt_decrypt_string(/*IConfiguration config,*/ICryptoService crypto)
        {
            Crypto = crypto;
            //publickey = config.GetSection("EncreptionKeys")["publickey"];
            //secretkey = config.GetSection("EncreptionKeys")["secretkey"];
        }

        public async Task<string> Encrypt(string textToEncrypt)
        {
            try
            {
                CryptoResult encrypted = await Crypto.EncryptAsync(textToEncrypt);
                return encrypted.Value;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }
        public async Task<string> Decrypt(string textToDecrypt)
        {
            try
            {
                string decrypted = await Crypto.DecryptAsync(textToDecrypt);
                return decrypted;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }

        //public string Encrypt(string encryptString)
        //{
        //    byte[] clearBytes = Encoding.Unicode.GetBytes(encryptString);
        //    using (Aes encryptor = Aes.Create())
        //    {
        //        Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(secretkey, new byte[] {
        //            0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76
        //        });
        //        encryptor.Key = pdb.GetBytes(32);
        //        encryptor.IV = pdb.GetBytes(16);
        //        using (MemoryStream ms = new MemoryStream())
        //        {
        //            using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
        //            {
        //                cs.Write(clearBytes, 0, clearBytes.Length);
        //                cs.Close();
        //            }
        //            encryptString = Convert.ToBase64String(ms.ToArray());
        //        }
        //    }
        //    return encryptString;
        //}

        //public string Decrypt(string cipherText)
        //{
        //    cipherText = cipherText.Replace(" ", "+");
        //    byte[] cipherBytes = Convert.FromBase64String(cipherText);
        //    using (Aes encryptor = Aes.Create())
        //    {
        //        Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(secretkey, new byte[] {
        //            0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76
        //        });
        //        encryptor.Key = pdb.GetBytes(32);
        //        encryptor.IV = pdb.GetBytes(16);
        //        using (MemoryStream ms = new MemoryStream())
        //        {
        //            using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
        //            {
        //                cs.Write(cipherBytes, 0, cipherBytes.Length);
        //                cs.Close();
        //            }
        //            cipherText = Encoding.Unicode.GetString(ms.ToArray());
        //        }
        //    }
        //    return cipherText;
        //}

        //public string Encrypt(string textToEncrypt)
        //{
        //    try
        //    {
        //        string ToReturn = "";
        //        byte[] secretkeyByte = { };
        //        secretkeyByte = System.Text.Encoding.UTF8.GetBytes(secretkey);
        //        byte[] publickeybyte = { };
        //        publickeybyte = System.Text.Encoding.UTF8.GetBytes(publickey);
        //        MemoryStream ms = null;
        //        CryptoStream cs = null;
        //        byte[] inputbyteArray = System.Text.Encoding.UTF8.GetBytes(textToEncrypt);
        //        using (Aes des = Aes.Create())
        //        {
        //            ms = new MemoryStream();
        //            cs = new CryptoStream(ms, des.CreateEncryptor(publickeybyte, secretkeyByte), CryptoStreamMode.Write);
        //            cs.Write(inputbyteArray, 0, inputbyteArray.Length);
        //            cs.FlushFinalBlock();
        //            ToReturn = Convert.ToBase64String(ms.ToArray());
        //        }
        //        return ToReturn;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message, ex.InnerException);
        //    }
        //}

        //public string Decrypt(string textToDecrypt)
        //{
        //    try
        //    {
        //        string ToReturn = "";
        //        byte[] privatekeyByte = { };
        //        privatekeyByte = System.Text.Encoding.UTF8.GetBytes(secretkey);
        //        byte[] publickeybyte = { };
        //        publickeybyte = System.Text.Encoding.UTF8.GetBytes(publickey);
        //        MemoryStream ms = null;
        //        CryptoStream cs = null;
        //        byte[] inputbyteArray = new byte[textToDecrypt.Replace(" ", "+").Length];
        //        inputbyteArray = Convert.FromBase64String(textToDecrypt.Replace(" ", "+"));
        //        using (Aes des = Aes.Create())
        //        {
        //            ms = new MemoryStream();
        //            cs = new CryptoStream(ms, des.CreateDecryptor(publickeybyte, privatekeyByte), CryptoStreamMode.Write);
        //            cs.Write(inputbyteArray, 0, inputbyteArray.Length);
        //            cs.FlushFinalBlock();
        //            Encoding encoding = Encoding.UTF8;
        //            ToReturn = encoding.GetString(ms.ToArray());
        //        }
        //        return ToReturn;
        //    }
        //    catch (Exception ae)
        //    {
        //        throw new Exception(ae.Message, ae.InnerException);
        //    }
        //}
    }
}
