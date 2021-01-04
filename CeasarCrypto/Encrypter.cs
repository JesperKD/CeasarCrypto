using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeasarCrypto
{
    class Encrypter
    {

        public static string Encrypt(string msg)
        {
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            msg = msg.ToUpper();
            string alphabet2 = "DEFGHIJKLMNOPQRSTUVWXYZABC";

            string newString = "";

            foreach (Char item in msg)
            { 
                foreach(char letter in alphabet)
                {
                    if (item == letter)
                    {

                        int alphIndex = alphabet.IndexOf(letter);

                        newString = newString + (alphabet2.ElementAt(alphIndex));
                    }
                }
            }

            return newString;
        }

        public static string Decrypt(string msg)
        {

            string alphabet = "DEFGHIJKLMNOPQRSTUVWXYZABC";
            string alphabet2 = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            msg = msg.ToUpper();

            string newString = "";

            foreach (Char item in msg)
            {
                foreach (char letter in alphabet)
                {
                    if (item == letter)
                    {

                        int alphIndex = alphabet.IndexOf(letter);

                        newString = newString + (alphabet2.ElementAt(alphIndex));
                    }
                }
            }

            return newString;
        }
    }
}
