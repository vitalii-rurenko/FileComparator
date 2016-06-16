using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using HashLib;

namespace FileComparator
{
    public class HashProvider
    {
        private string filePath { get; set; }

        public HashProvider(string filepath)
        {
            filePath = filepath;
        }

        /// <summary>
        /// Метод возвращает строку, которая представляет хеш-сумму файла по указанному пути для алгоритма SHA-256. 
        /// </summary>
        /// <returns></returns>
        public string GetSHA256Hash()
        {
            string strHash = string.Empty;
            byte[] HashValue;
            byte[] MessageBytes = File.ReadAllBytes(filePath);
            SHA256Managed SHhash = new SHA256Managed();
            HashValue = SHhash.ComputeHash(MessageBytes);
            foreach (byte b in HashValue)
            {
                strHash += String.Format("{0:x2}", b);
            }
            return strHash;
        }

        /// <summary>
        /// Метод возвращает строку, которая представляет хеш-сумму файла по указанному пути для алгоритма RIPEMD-160.
        /// </summary>
        /// <returns></returns>
        public string GetRIPEMD160Hash()
        {
            StringBuilder sb = new StringBuilder();
            try
            {
                FileStream file = new FileStream(filePath, FileMode.Open);
                RIPEMD160 ripeMD = new RIPEMD160Managed();
                byte[] retVal = ripeMD.ComputeHash(file);
                file.Close();
                for (int i = 0; i < retVal.Length; i++)
                {
                    sb.Append(retVal[i].ToString("x2"));
                }
            }
            catch (Exception e)
            {
                System.Windows.MessageBox.Show(e.Message);
            }
            return sb.ToString();
        }

        /// <summary>
        /// Метод возвращает строку, которая представляет хеш-сумму файла по указанному пути для алгоритма MD5.
        /// </summary>
        /// <returns></returns>
        public string GetMD5Hash()
        {
            StringBuilder sb = new StringBuilder();
            try
            {
                FileStream file = new FileStream(filePath, FileMode.Open);

                MD5 md5 = new MD5CryptoServiceProvider();
                byte[] retVal = md5.ComputeHash(file);
                file.Close();
                for (int i = 0; i < retVal.Length; i++)
                {
                    sb.Append(retVal[i].ToString("x2"));
                }
            }
            catch (Exception e)
            {
                System.Windows.MessageBox.Show(e.Message);
            }
            return sb.ToString();
        }

        /// <summary>
        /// Метод возвращает строку, которая представляет хеш-сумму файла по указанному пути для алгоритма SHA-1.
        /// </summary>
        /// <returns></returns>
        public string GetSHA1Hash()
        {
            string sendCheckSum = string.Empty;
            try
            {
                using (FileStream stream = File.OpenRead(filePath))
                {
                    SHA1Managed sha = new SHA1Managed();
                    byte[] checksum = sha.ComputeHash(stream);
                    sendCheckSum = BitConverter.ToString(checksum).Replace("-", string.Empty);
                }
            }
            catch (Exception e)
            {
                System.Windows.MessageBox.Show(e.Message);
            }
            return sendCheckSum.ToLower();
        }

        /// <summary>
        /// Метод возвращает строку, которая представляет хеш-сумму файла по указанному пути для алгоритма CRC-32.
        /// </summary>
        /// <returns></returns>
        public string GetCRCHash()
        {
            CRC32 crc32 = new CRC32();
            String hash = String.Empty;
            try
            {
                using (FileStream fs = File.Open(filePath, FileMode.Open))
                    foreach (byte b in crc32.ComputeHash(fs))
                        hash += b.ToString("x2").ToLower();
            }
            catch (Exception e)
            {
                System.Windows.MessageBox.Show(e.Message);
            }
            return hash;
        }

        /// <summary>
        /// Метод возвращает строку, которая представляет хеш-сумму файла по указанному пути для алгоритма Keccak-224.
        /// </summary>
        /// <returns></returns>
        public string GetKeccak224Hash()
        {
            IHash hash = HashFactory.Crypto.SHA3.CreateKeccak(HashSize.HashSize224);
            HashResult result = hash.ComputeFile(filePath,)
            return result.ToString().ToLower().Replace("-", string.Empty);
        }

        /// <summary>
        /// Метод возвращает строку, которая представляет хеш-сумму файла по указанному пути для алгоритма Keccak-256.
        /// </summary>
        /// <returns></returns>
        public string GetKeccak256Hash()
        {
            IHash hash = HashFactory.Crypto.SHA3.CreateKeccak256();
            HashResult result = hash.ComputeFile(filePath);
            return result.ToString().ToLower().Replace("-", string.Empty);
        }

        /// <summary>
        /// Метод возвращает строку, которая представляет хеш-сумму файла по указанному пути для алгоритма Keccak-384.
        /// </summary>
        /// <returns></returns>
        public string GetKeccak384Hash()
        {
            IHash hash = HashFactory.Crypto.SHA3.CreateKeccak384();
            HashResult result = hash.ComputeFile(filePath);
            return result.ToString().ToLower().Replace("-", string.Empty);
        }

        /// <summary>
        /// Метод возвращает строку, которая представляет хеш-сумму файла по указанному пути для алгоритма Keccak-512.
        /// </summary>
        /// <returns></returns>
        public string GetKeccak512Hash()
        {
            IHash hash = HashFactory.Crypto.SHA3.CreateKeccak512();
            HashResult result = hash.ComputeFile(filePath);
            return result.ToString().ToLower().Replace("-", string.Empty);
        }

    }
}
