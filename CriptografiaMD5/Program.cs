using System;
using System.Security.Cryptography;
using System.Text;

namespace CriptografiaMD5
{
    class Program
    {
        static void Main()
        {
            Console.Write("Digite a senha a criptografar: ");
            var senha = Console.ReadLine();
            Console.Write("Senha a criptografada        : ");
            Console.WriteLine(CriptografaSenha(senha));

            Console.ReadLine();
        }

        static string CriptografaSenha(string senha)
        {
            var md5 = MD5.Create();
            var inputBytes = Encoding.ASCII.GetBytes(senha);
            var hash = md5.ComputeHash(inputBytes);

            return BitConverter.ToString(hash);
        }
    }
}
