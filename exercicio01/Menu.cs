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



        List<CadastroUsuario> lista = new List<CadastroUsuario>();

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

                        CadastroUsuario usuario = new CadastroUsuario();

                        usuario.Cadastro();

                        lista.Add(usuario);

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

            CadastroUsuario user = lista.FirstOrDefault(u => u.nome.Equals("test"));
            CadastroUsuario user1 = (from u in lista where u.nome == "test" select u).FirstOrDefault();



            foreach (CadastroUsuario usuario in lista)
            {

                Console.WriteLine("***********************************");
                usuario.mostraDados();

            }
            Console.ReadKey();
        }


    }
}
