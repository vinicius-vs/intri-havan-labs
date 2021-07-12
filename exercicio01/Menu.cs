using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;


namespace exercicio01
{
    class Menu
    {



        List<Data.Usuario> lista = new List<Data.Usuario>(); // lista para gravar os usuarios utilizando List

        public void MenuUsuario()
        {

            // cabeçalho
            Cabecalho();
            //rodapé 
            Opcoes();
            Rodape();
            // escolha 
            escolha();


        }


        private static void Cabecalho()
        {
            Console.WriteLine("************** Hava Lab **************");
            Console.WriteLine("**************   Menu   **************");

        }


        private static void Opcoes()
        {

            Console.Clear();
            Console.WriteLine("\t0 - sair");
            Console.WriteLine("\t1 - cadastrar usuario");
            Console.WriteLine("\t2 - cadastrar produto");
            Console.WriteLine("\t3 - mostra usuario");
        }

        private static void Rodape()
        {
            Console.Write("Escolha uma opção: ");
        }

        private void escolha()
        {


            //CadastroUsuario[] lista = new CadastroUsuario[999];


            int opcao = 0;

            do
            {

                Cabecalho();

                Opcoes();

                opcao = Verificar.captarInt();
                switch (opcao)
                {
                    case 0:
                        Console.WriteLine("tchau");

                        break;
                    case 1:

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


                            Data.Usuario usuario = new Data.Usuario(nome, sobrenome, idade, email, endereco);
                            lista.Add(usuario);// adiciona mais um item na lista 

                            Console.Write("Deseja inserir outro usuario(y/n): ");
                            resposta = Console.ReadLine();

                        } while (resposta == "y");

                        mostrarUsuario();

                        break;
                    case 2:
                        Console.WriteLine("Em costrução");
                        Console.ReadKey();
                        break;
                    case 3:
                        mostrarUsuario();
                        break;
                    default:
                        Console.WriteLine("Opção invalida!, opções de escolha: 0 - sair, 1 - cadastro de usuario, 2 - cadastro de produdos, 3 - mostrar usuarios ");
                        break;
                }

            } while (opcao > 0 || opcao < 3);


        }

        private void mostrarUsuario()
        {

            //CadastroUsuario user = lista.FirstOrDefault(u => u.nome.Equals("test")); // procurar se na lista se encontra o nome teste 
            //CadastroUsuario user1 = (from u in lista where u.nome == "test" select u).FirstOrDefault(); // outro jeito de achar um nome numa lista 



            foreach (Usuario usuario in lista) // laço para percorrer um lista de forma mais eficiente 
            {

                Console.WriteLine("***********************************");
                usuario.mostraDados();

            }
            Console.ReadKey();
        }
    }
}
