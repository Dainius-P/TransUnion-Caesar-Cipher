using Microsoft.VisualStudio.TestTools.UnitTesting;
using Caesar_cipher;

namespace Caesar_cipher_Tests
{
    [TestClass]
    public class CaesarUnitTests
    {
        private CaesarCipher cc = new CaesarCipher();
        [TestMethod]
        public void TestMethod1()
        {
            string input = "ABC";
            string output = "CDE";
            int shift = 2;

            string encrypted = cc.encrypt(input, shift);
            string decrypted = cc.decrypt(encrypted, shift);

            Assert.AreEqual(encrypted, output);
            Assert.AreEqual(decrypted, input);
        }

        [TestMethod]
        public void TestMethod2()
        {
            string input = "THE QUICK BROWN FOX JUMPS OVER THE LAZY DOG";
            string output = "QEB NRFZH YOLTK CLU GRJMP LSBO QEB IXWV ALD";
            int shift = -3;

            string encrypted = cc.encrypt(input, shift);
            string decrypted = cc.decrypt(encrypted, shift);

            Assert.AreEqual(encrypted, output);
            Assert.AreEqual(decrypted, input);
        }

        [TestMethod]
        public void TestMethod3()
        {
            string input = "THE#QUICK1BROWN0FOX!JUMPS15VERTHE@#$LAZY DOG";
            // Output is from https://cryptii.com/pipes/caesar-cipher
            string output = "XLI#UYMGO1FVSAR0JSB!NYQTW15ZIVXLI@#$PEDC HSK";
            int shift = -100;

            string encrypted = cc.encrypt(input, shift);
            string decrypted = cc.decrypt(encrypted, shift);

            Assert.AreEqual(encrypted, output);
            Assert.AreEqual(decrypted, input);
        }
    }
}
