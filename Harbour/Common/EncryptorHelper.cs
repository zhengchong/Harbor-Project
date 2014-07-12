using System;
using System.Security.Cryptography;
using System.IO;
using System.Text;

namespace Common
{
    public class EncryptorHelper
    {
        //密钥应注意一点：3DES算法，如果1重、2重和3重密钥(每8位)有一个相同，算法会退化为2重或1重，运行报错
        private static string _rgbKey = "thisishelloworld";
        private static byte[] _rgbIV = new byte[] { 0x12, 0x34, 0x56, 0x78, 0x90, 0xAB, 0xCD, 0xEF };

        public static string Encryptor(string plainText)
        {
            TripleDESCryptoServiceProvider provider = new TripleDESCryptoServiceProvider();//创建provider,利用其产生加密器
            provider.Key = Encoding.Default.GetBytes(_rgbKey);
            provider.IV = _rgbIV;
            ICryptoTransform encryptor = provider.CreateEncryptor();//加密器
            byte[] plainBytes = Encoding.GetEncoding("gb2312").GetBytes(plainText);
            MemoryStream plainStream = new MemoryStream(plainBytes);//创建明文流
            MemoryStream cipherStream = new MemoryStream();//创建密文流
            CryptoStream enCryptoStream = new CryptoStream(cipherStream, encryptor, CryptoStreamMode.Write);//创建加密中介
            int maxSize = 10;
            byte[] buffer = new byte[maxSize];
            int bytesRead = 0;
            do
            {
                bytesRead = plainStream.Read(buffer, 0, maxSize);
                enCryptoStream.Write(buffer, 0, bytesRead);//谨记这里应该是写入读出的长度，而不是buffer本身的长度
            } while (bytesRead > 0);
            enCryptoStream.FlushFinalBlock();
            return Convert.ToBase64String(cipherStream.ToArray());

        }


        public static string Decryptor(string cipherText)
        {
            TripleDESCryptoServiceProvider provider = new TripleDESCryptoServiceProvider();
            provider.Key = Encoding.Default.GetBytes(_rgbKey);
            provider.IV = _rgbIV;
            ICryptoTransform decryptor = provider.CreateDecryptor();
            byte[] cipherByte = Convert.FromBase64String(cipherText);
            MemoryStream plainStream = new MemoryStream();
            MemoryStream cipherStream = new MemoryStream(cipherByte);
            CryptoStream deCryptoStream = new CryptoStream(cipherStream, decryptor, CryptoStreamMode.Read);
            int maxSize = 10;
            byte[] buffer = new byte[maxSize];
            int bytesRead = 0;
            do
            {
                bytesRead = deCryptoStream.Read(buffer, 0, maxSize);
                plainStream.Write(buffer, 0, bytesRead);
            } while (bytesRead > 0);

            deCryptoStream.Dispose();
            return Encoding.GetEncoding("gb2312").GetString(plainStream.ToArray());
        }
    }
}