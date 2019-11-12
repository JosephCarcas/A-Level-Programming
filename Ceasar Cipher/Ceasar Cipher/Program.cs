using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ceasar_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Encryption("Cheese Please!", 15);
            Console.WriteLine(message);
            Console.WriteLine(Decryption(message, 15));

        }

        static string Encryption(string plainText, int shiftKey)
        {
            string cipherText = "";

            return cipherText;
        }

        static string Decryption(string cipherText, int shiftKey)
        {
            string plainText = "";

            return plainText;
        }
    }
}
