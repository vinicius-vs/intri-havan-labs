using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;


namespace exercicio01
{
    class ModuloUsuario
    {

        UsuarioRepository repository = new UsuarioRepository();

        public  void Create()
        {
            string resposta = "";

            do
            {

                Console.WriteLine("Digite o nome do usuario:");
                string nome = Data.Usuario.captarString();

                Console.WriteLine("Digite o sobrenome do usuario:");
                string sobrenome = Data.Usuario.captarString();

                Console.WriteLine("Digite o idade do usuario:");
                int idade = Data.Verificar.captarInt();

                Console.WriteLine("Digite o endereco do usuario:");
                string endereco = Data.Usuario.captarString();

                Console.WriteLine("Digite o email do usuario:");
                string email = Data.Usuario.captarString();


                Data.Usuario model = new Data.Usuario(nome, sobrenome, idade, email, endereco);


                repository.Create(model);

                Console.Write("Deseja inserir outro usuario(y/n): ");
                resposta = Console.ReadLine();

            } while (resposta == "y");
        }

    }
}
