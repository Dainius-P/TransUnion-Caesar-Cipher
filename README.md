# Homework for TransUnion internship - Caesar cipher

[Caesar cipher Wiki](https://en.wikipedia.org/wiki/Caesar_cipher)

## Built with
C# .Net

## Idea
Shift letters by value **x** in **ascii** code space.
### Encryption
``En(x) = ((x + n) - first_letter_ascii_code)mod26 + first_letter_ascii_code``
Where:
* **x** - letter ascii code.
* **n** - shift value
* **first_letter_ascii_code** - either 65(A) or 97(a). This is determined by if the letter is lower or upper case.
### Decryption
``En(x) = ((x - n) - first_letter_ascii_code)mod26 + first_letter_ascii_code``
### Example
**text** - defend the east wall of the castle

**shift** - 1

**encrypted** - efgfoe uif fbtu xbmm pg uif dbtumf