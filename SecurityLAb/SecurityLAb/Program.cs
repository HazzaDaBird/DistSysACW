using System;
using System.Security.Cryptography;


namespace SecurityLAb
{
    class Program
    {
        static void Main(string[] args)
        {
            String message;
            message = "";

            byte[] asciiByteMessage = System.Text.Encoding.ASCII.GetBytes(message);

            byte[] sha1ByteMessage;
            SHA1 sha1Provider = new SHA1CryptoServiceProvider();
            sha1ByteMessage = sha1Provider.ComputeHash(asciiByteMessage);
            byte[] encryptedByteMessage;
            byte[] decryptedByteMessage;
            RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
            {
                encryptedByteMessage = RSAEncrypt(asciiByteMessage, RSA.ExportParameters(false));
                Console.Write("Encrypted message: ");
                Console.WriteLine(ByteArrayToHexString(encryptedByteMessage));
                decryptedByteMessage = RSADecrypt(encryptedByteMessage, RSA.ExportParameters(true));
                Console.Write("Decrypted message: ");
                Console.WriteLine(System.Text.Encoding.ASCII.GetString(decryptedByteMessage));
            }
        }
        static string ByteArrayToHexString(byte[] byteArray)
        {
            string hexString = "";
            if (null != byteArray)
            {
                foreach (byte b in byteArray)
                {
                    hexString += b.ToString("x2");
                }
            }
            return hexString;            
            
        }
        static public byte[] RSAEncrypt(byte[] DataToEncrypt, RSAParameters RSAKeyInfo)
        {
            try
            {
                byte[] encryptedData;
                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
                {
                    RSA.ImportParameters(RSAKeyInfo);
                    encryptedData = RSA.Encrypt(DataToEncrypt, false);
                }
                return encryptedData;
            }
            catch (CryptographicException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
        static public byte[] RSADecrypt(byte[] DataToDecrypt, RSAParameters RSAKeyInfo)
        {
            try
            {
                byte[] decryptedData;
                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
                {
                    RSA.ImportParameters(RSAKeyInfo);
                    decryptedData = RSA.Decrypt(DataToDecrypt, false);
                }
                return decryptedData;
            }
            catch (CryptographicException e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
        }

    }

}
