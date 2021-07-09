using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;

namespace exercicio01
{
    class CadastroUsuario
    {

        public string nome = String.Empty;
        public string sobrenome = String.Empty;
        public int idade = 0;
        public string email = String.Empty;
        public string endereco = String.Empty;


        public void Cadastro()
        {
            // 1 - Crie um projeto do tipo console aplication em c# com .NET framework v4.7.2
            // 2 - Crie uma aplicação para cadastrar um usuario com os seguintes dados
            //         nome, sobrenome, idade, E - MAIL, endereço
            // 3 - Exiba os dados do usuario cadastrados ao final da execução.
            // 4 - a exibição deve ser feita em uma unica linha. 

            Console.WriteLine("Digite o nome do usuario:");
            this.nome = captarString();


            //nome.Trim // tirar os espaços de uma String. só no começo ou final.


            Console.WriteLine("Digite o sobrenome do usuario:");
            this.sobrenome = captarString();


            //do
            //{
            //    Console.WriteLine("Digite o sobrenome do usuario:");
            //    sobrenome = Console.ReadLine();
            //    Console.Clear();
            //} while (verificarStringEmBranco(sobrenome));

            Console.WriteLine("Digite a idade do usuario!!");
            this.idade = Verificar.captarInt();


            Console.WriteLine("Digite o email do usuario:");
            this.email = captarString();

            Console.WriteLine("Digite o endereço do usuario");
            this.endereco = captarString();


            mostraDados();

            Console.ReadKey();
        }

        private static string captarString()
        {
            string dado = String.Empty;

            do
            {
                dado = Console.ReadLine();
            } while (Verificar.verificarStringEmBranco(dado));

            return dado;
        }


        public void mostraDados()
        {
            Console.WriteLine($"\n\tNome: {nome}, sobrenome: {sobrenome}, \n\tidade: {idade}, \n\tE-mail: {email}, \n\tendereço: {endereco}");
        }

    }




}
