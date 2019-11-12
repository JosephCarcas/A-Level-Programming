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
            int inputKey1;
            int inputKey2;

            Console.Write("Enter message to encrypt: ");
            inputMessage = Console.ReadLine();

            Console.Write("Enter first cipher key: ");
            int.TryParse(Console.ReadLine(), out inputKey1);

            Console.Write("Enter second cipher key: ");
            int.TryParse(Console.ReadLine(), out inputKey2);

            Console.Clear();

            string message = Encryption(inputMessage, inputKey1, inputKey2);
            Console.WriteLine("Encrypted Message: {0}", message);
            Console.WriteLine("Decrypted Message: {0}", Decryption(message, inputKey1, inputKey2));

            Console.ReadLine();

        }

        static string Encryption(string plainText, int shiftKey1, int shiftKey2)
        {
            char[] TempChars = plainText.ToCharArray();

            for (int i = 0; i < TempChars.Length; i++)
            {
                int asciiValue = (int)TempChars[i];

                if (char.IsUpper(TempChars[i]) == true)
                {
                    for (int chooseKey = 0; chooseKey < TempChars.Length; chooseKey++)
                    {
                        asciiValue = asciiValue - 65;

                        if ((chooseKey % 2) == 0)
                        {
                            asciiValue = asciiValue + shiftKey1;
                        }
                        else
                        {
                            asciiValue = asciiValue + shiftKey2;
                        }

                        asciiValue = asciiValue % 26;

                        asciiValue = asciiValue + 65;
                    }
                    
                }

                if (char.IsLower(TempChars[i]) == true)
                {
                    for (int chooseKey = 0; chooseKey < TempChars.Length; chooseKey++)
                    {
                        asciiValue = asciiValue - 97;

                        if ((chooseKey % 2) == 0)
                        {
                            asciiValue = asciiValue + shiftKey1;
                        }
                        else
                        {
                            asciiValue = asciiValue + shiftKey2;
                        }

                        asciiValue = asciiValue + 26; //prevents negative numbers by adding a multiple of the mod.

                        asciiValue = asciiValue % 26;

                        asciiValue = asciiValue + 97;
                    }

                }

                TempChars[i] = (char)asciiValue;
            }

            return new string(TempChars);
        }

        static string Decryption(string cipherText, int shiftKey1, int shiftKey2)
        {
            char[] TempChars = cipherText.ToCharArray();

            for (int i = 0; i < TempChars.Length; i++)
            {
                int asciiValue = (int)TempChars[i];

                if (char.IsUpper(TempChars[i]) == true)
                {
                    for (int chooseKey = 0; chooseKey < TempChars.Length; chooseKey++)
                    {
                        asciiValue = asciiValue - 65;

                        if ((chooseKey % 2) == 0)
                        {
                            asciiValue = asciiValue + shiftKey1;
                        }
                        else
                        {
                            asciiValue = asciiValue + shiftKey2;
                        }
                        asciiValue = asciiValue + 26; //prevents negative numbers by adding a multiple of the mod.

                        asciiValue = asciiValue % 26;

                        asciiValue = asciiValue + 65;
                    }

                }

                if (char.IsLower(TempChars[i]) == true)
                {
                    for (int chooseKey = 0; chooseKey < TempChars.Length; chooseKey++)
                    {
                        asciiValue = asciiValue - 97;

                        if ((chooseKey % 2) == 0)
                        {
                            asciiValue = asciiValue + shiftKey1;
                        }
                        else
                        {
                            asciiValue = asciiValue + shiftKey2;
                        }

                        asciiValue = asciiValue + 26; //prevents negative numbers by adding a multiple of the mod.

                        asciiValue = asciiValue % 26;

                        asciiValue = asciiValue + 97;
                    }

                }

                TempChars[i] = (char)asciiValue;
            }

            return new string(TempChars);
        }
    }
}
