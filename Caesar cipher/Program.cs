using System;

namespace Caesar_cipher
{
    class Program
    {
        private static int shift_input()
        {
            int shift;

            Console.Write("Enter shift (Positive or Negative number): ");
            while (true)
            {
                try
                {
                    shift = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.Write("Shift must be a number. Try again: ");
                }
                catch (Exception e)
                {
                    Console.Write(e);
                }
            }

            return shift;
        }

        private static string text_input()
        {
            Console.Write("Enter text to encrypt: ");
            string text = Console.ReadLine();

            return text;
        }

        static void Main(string[] args)
        {
            // User input for Shift variable
            CaesarCipher cc = new CaesarCipher();
            int shift = shift_input();
            string text = text_input();

            string encrypted_text = cc.encrypt(text, shift);
            string decrypted_text = cc.decrypt(encrypted_text, shift);

            Console.WriteLine($"Encrypted text: {encrypted_text}");
            Console.WriteLine($"Decrypted text: {decrypted_text}");
        }
    }
}
