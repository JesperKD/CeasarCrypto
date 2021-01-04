using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeasarCrypto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cæsar Kryptering:");
            Console.WriteLine();
            Console.WriteLine("Krpteret: " + Encrypter.Encrypt("Abbekat"));
            Console.WriteLine("Dekrypteret: " + Encrypter.Decrypt(Encrypter.Encrypt("Abbekat")));

            Console.ReadKey();
        }
    }
}
