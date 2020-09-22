using System;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alphabet = new char[] {‘a’, ‘b’, ‘c’, ‘d’, ‘e’, ‘f’, ‘g’, ‘h’, ‘i’, ‘j’, ‘k’, ‘l’, ‘m’, ‘n’, ‘o’, ‘p’, ‘q’, ‘r’, ‘s’, ‘t’, ‘u’, ‘v’, ‘w’, ‘x’, ‘y’, ‘z’};

            Console.Write("Input secret message: ");
            string message = Console.ReadLine();
            char[] secretMessage = message.ToCharArray();

            char[] encryptedMessage = new char[25];

            for (int i = 0; i < 26; i++)
            {
                char secretItem = secretMessage[i];
                int index = Array.IndexOf(alphabet, secretItem);
                int letterPosition = (index += 3 % 26);

                char encryptedLetter = alphabet[letterPosition];
                encryptedMessage[i] = encryptedLetter;
            }

            string superSecretMessage = String.Join("", encryptedMessage);




        }
    }
}