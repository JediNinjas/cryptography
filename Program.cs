using System;
using System.Configuration;
using System.Text;

namespace System.Security.Cryptography
{
    class MainClass
    {

        protected static void Main(string[] args)
        {
            // This is the provided encoded input
            string keyString = "ABvAsOKcGXqc5uQ4O5Z53isJaH31Pa8+PeddljE4mSU=";

            Console.WriteLine("This is the encoded string: "+ keyString);

            // Here I am decoding the encoded input
            byte[] data = Encoding.UTF8.GetBytes(keyString);                   
            string decodedString = Encoding.Unicode.GetString(data);

            //printing the decoded text
            Console.WriteLine("\nThis is the encoded string decoded: "+ decodedString);

            //creating TripleDes call name
            TripleDES decoder = TripleDES.Create();

            //Setting the key and vector parameters
            byte[] key = Encoding.UTF8.GetBytes("0123456789ABCDEF");
            int keySize = 128; // could not figure out where to place the key size :(
            byte[] vector = Encoding.UTF8.GetBytes("ABCDEFGH");

            // setting the decryptor to type ICryptoTransform
            ICryptoTransform decryptor;

            // creates the decryptor
            decryptor = decoder.CreateDecryptor(key, vector);
            decodedString = decryptor.ToString();

            Console.WriteLine("");

            //Is supposed to print the results
            Console.WriteLine("This is the decoded string decrypted: "+ decodedString);

        }
    }

}
