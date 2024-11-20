using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using WinForm.Data;

namespace WinForm.Auxiliar
{
    public class Password
    {
        public static Password instance;

        public static Password GetInstance()
        {
            if (instance == null)
                instance = new Password();

            return instance;
        }

        public string GenerarHash(string input)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                //Convierte la entrada de string a array de byte y genera el hash
                byte[] data = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
                //Crear un StringBuilder para convertir el array de bytes a string
                var sBuilder = new StringBuilder();
                //Recorre cada byte del array de byte y lo
                //formatea a un string hexadecimal
                for (int i = 0; i < data.Length; i++)
                {
                    sBuilder.Append(data[i].ToString("x2"));
                }
                // Retorna el string hexadecimal.
                return sBuilder.ToString();
            }
        }
        public bool VerificarHash(string input, string hash)
        {
            // Genera el hash de la entrada
            var hashInput = GenerarHash(input);
            // Compara los hash
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;
            return comparer.Compare(hashInput, hash) == 0;
        }
    }
}
