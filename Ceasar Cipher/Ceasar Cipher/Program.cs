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
            string inputMessage = "";
            int inputKey;

            Console.Write("Enter message to encrypt: ");
            inputMessage = Console.ReadLine();

            Console.Write("Enter cipher key: ");
            int.TryParse(Console.ReadLine(), out inputKey);

            Console.Clear();

            string message = Encryption(inputMessage, inputKey);
            Console.WriteLine("Encrypted Message: {0}", message);
            Console.WriteLine("Decrypted Message: {0}", Decryption(message, inputKey));

            Console.ReadLine();

        }

        static string Encryption(string plainText, int shiftKey)
        {
            char[] TempChars = plainText.ToCharArray();

            for (int i = 0; i < TempChars.Length; i++)
            {
                int asciiValue = (int)TempChars[i];

                if (char.IsUpper(TempChars[i]) == true)
                {
                    asciiValue = asciiValue - 65;

                    asciiValue = asciiValue + shiftKey;

                    asciiValue = asciiValue % 26;

                    asciiValue = asciiValue + 65;
                }

                if (char.IsLower(TempChars[i]) == true)
                {
                    asciiValue = asciiValue - 97;

                    asciiValue = asciiValue + shiftKey;

                    asciiValue = asciiValue + 26; //prevents negative numbers by adding a multiple of the mod.

                    asciiValue = asciiValue % 26;

                    asciiValue = asciiValue + 97;
                }

                TempChars[i] = (char)asciiValue;
            }

            return new string(TempChars);
        }

        static string Decryption(string cipherText, int shiftKey)
        {
            char[] TempChars = cipherText.ToCharArray();

            for (int i = 0; i < TempChars.Length; i++)
            {
                int asciiValue = (int)TempChars[i];

                if (char.IsUpper(TempChars[i]) == true)
                {
                    asciiValue = asciiValue - 65;

                    asciiValue = asciiValue - shiftKey;
                    asciiValue = asciiValue + 26; //prevents negative numbers by adding a multiple of the mod.

                    asciiValue = asciiValue % 26;

                    asciiValue = asciiValue + 65;
                }

                if (char.IsLower(TempChars[i]) == true)
                {
                    asciiValue = asciiValue - 97;

                    asciiValue = asciiValue - shiftKey;

                    asciiValue = asciiValue + 26; //prevents negative numbers by adding a multiple of the mod.

                    asciiValue = asciiValue % 26;

                    asciiValue = asciiValue + 97;
                }

                TempChars[i] = (char)asciiValue;
            }

            return new string(TempChars);
        }
    }
}
