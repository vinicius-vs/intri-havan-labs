using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
   public class Verificar
    {
        public static bool verificarStringEmBranco(string dado)
        {
            //if (String.IsNullOrEmpty(dado)) // metado para verificar se a string é null ou vazia  
            if (dado.Trim().Equals(""))
            {
                Console.WriteLine("Valor invalido!. tente novamente.");
                return true;
            }
            return false;
        }
        public static int captarInt()
        {
            int dado = 0;

            while (true)
            {
                try
                {
                    dado = verificarInt(Console.ReadLine());
                    //idade = Convert.ToInt32(Console.ReadLine()); // outro jeito te fazer a converção.
                    Console.Clear();
                    return dado;
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("Valor invalido!. tente novamente ");
                }
            }
        }


        public static int verificarInt(string dado) // função só para dar mais linhas, poderia ser feito tudo na função em cima 
        {

            int inteiro = 0;

            try
            {
                inteiro = int.Parse(dado);
                return inteiro;
            }
            catch
            {
                throw new FormatException("Imposivel converter!!");
            }
        }


    }
}
