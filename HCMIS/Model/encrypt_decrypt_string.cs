using System.Security.Cryptography;
using System.Text;
using Blazor.SubtleCrypto;

namespace HCMIS.Model
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

        public async Task<string> EncryptCredentials(SystemCredentials data)
        {
            try
            {
                CryptoResult encrypted = await Crypto.EncryptAsync(data);
                return encrypted.Value;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }
        public async Task<SystemCredentials> DecryptCredentials(string textToDecrypt)
        {
            try
            {
                SystemCredentials decrypted = await Crypto.DecryptAsync<SystemCredentials>(textToDecrypt);
                return decrypted;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }

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
