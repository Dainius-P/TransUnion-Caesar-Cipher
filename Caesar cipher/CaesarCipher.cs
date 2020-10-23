using System;
using System.Collections.Generic;
using System.Text;

namespace Caesar_cipher
{
    public class CaesarCipher
    {
        public string encrypt(string text, int shift)
        {
            var output = new StringBuilder();
            char encryptedLetter;

            foreach (char letter in text)
            {
                if (char.IsLetter(letter))
                {
                    char range_start = char.IsUpper(letter) ? 'A' : 'a';

                    // En(x) = ((x+n) - start_element_ascii_code)mod26 + start_element_ascii_code
                    // x - letter ascii code
                    // n - shift
                    encryptedLetter = (char)(((letter + shift) - range_start) % 26 + range_start);

                    if (encryptedLetter < range_start)
                    {
                        encryptedLetter = (char)(encryptedLetter + 26);
                    }
                }
                else
                {
                    encryptedLetter = letter;
                }

                output.Append(encryptedLetter);
            }
            return output.ToString();
        }

        public string decrypt(string text, int shift)
        {
            // En(x) = (x-n)*mod26
            return encrypt(text, -shift);
        }
    }
}
