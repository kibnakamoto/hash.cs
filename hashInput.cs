using System;
using System.Security.Cryptography;
using System.Text;

namespace HashAlgs
{
    public class SHAKE
    {
        public string Sha256(string Data)
        {
            using (SHA256 Shake256 = SHA256.Create())
            {
                // bytearray
                byte[] HashedSha256Data = Shake256.ComputeHash(Encoding.UTF8.
                                                                GetBytes(Data));
               StringBuilder BToS = new StringBuilder();
                // convert to string
                for (uint c=0;c<HashedSha256Data.Length;c++)
                {
                    BToS.Append(HashedSha256Data[c].ToString("x2"));
                }
            return BToS.ToString();
            }
        }
        public string Sha512(string Data)
        {
                // bytearray
               SHA512 sha512 = new SHA512Managed();
                byte[] ByteData = sha512.ComputeHash(Encoding.UTF8.GetBytes(Data));
               StringBuilder BToS = new StringBuilder();
                // convert to string
                for (uint c=0;c<ByteData.Length;c++)
                {
                    BToS.Append(ByteData[c].ToString("x2"));
                }
            return BToS.ToString();
            
        }
    }
    public class Output
    {
        public static void Main(string[] args)
        {
            SHAKE HashAlg = new SHAKE();
            Console.Write("input hashing Algorithm\ninput:\t");
            string Choice = Console.ReadLine();
            Console.Write("\n");
            Console.Write("input what to hash\ninput:\t");
            string input = Console.ReadLine();
/* string.Equals(Choice, "sha256", StringComparision.CurrentCultureIgnoreCase); */
            if (Choice == "sha256" || Choice == "Sha256" || Choice == "SHA256")
            {
                Console.WriteLine(HashAlg.Sha256(input)); // hash user input
            }
            else if (Choice == "sha512")
            {
                Console.WriteLine(HashAlg.Sha512(input));
            }
            else
            {
                Console.WriteLine("Unknown Algorithm");
                // Console.WriteLine(); // print existing algorithms from list or string[]
            }
            return;
        }
    }
}
