using System;

namespace CaesarCipher
{
  class Program
  {
    static void Main(string[] args)
    {
      char[] alphabet = new char[] {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
      
      Console.WriteLine("please provide text to be encrypted: ");
      string toBeEnc = Console.ReadLine();

      char[] secretMessage = toBeEnc.ToCharArray();

      char[] encryptedMessage = new char[secretMessage.Length];      

      for (int i = 0; i < secretMessage.Length; i++)
      {
        char temp = secretMessage[i];
        int tempAlphaPlace = (Array.IndexOf(alphabet, temp) + 3) % 26;
        char encryptedChar = alphabet[tempAlphaPlace];
        encryptedMessage[i] = encryptedChar;
      }

      string encodedText = String.Join("", encryptedMessage);
      Console.WriteLine(encodedText);    

    }
  }
}
