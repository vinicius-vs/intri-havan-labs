using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Usuario
    {

        // meio de como declara propriedade da classe 
        //public string nome = String.Empty;
        //public int idade = 0;
        //public string sobrenome = String.Empty;
        //public string email = String.Empty;
        //public string endereco = String.Empty;

        // outro meio de daclarar propreidades quando se tem condições 
        /*  public int _idade;

          public int Idade {
              get
              {
                  return this._idade;
                      }
              set
              {

                  if (value > 0)
                  {
                      this._idade=value;
                  }
                  else
                  {
                      throw new Exception("Valor invalido!!");
                  }



              }
          }*/


        // outro metado de criar o paramentro, só funciona em c#


        [Key]

        public int Id { get; set; }

        public string Nome { get; set; }

        public string Sobrenome { get; set; }
        
        public int Idade { get; set; }

        public string Email { get; set; }

        public string Endereco { get; set; }



        public Usuario(string nome, string sobrenome, int idade, string email, string endereco)
        {
            this.Nome = nome;
            this.Sobrenome = sobrenome;
            this.Idade = idade;
            this.Email = email;
            this.Endereco = endereco;

        }


        public Usuario()
        {

        }

/*
        public void Cadastro()
        {
            // 1 - Crie um projeto do tipo console aplication em c# com .NET framework v4.7.2
            // 2 - Crie uma aplicação para cadastrar um usuario com os seguintes dados
            //         nome, sobrenome, idade, E - MAIL, endereço
            // 3 - Exiba os dados do usuario cadastrados ao final da execução.
            // 4 - a exibição deve ser feita em uma unica linha. 

            /* Console.WriteLine("Digite o nome do usuario:");
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





        }

   */


        public static string captarString()
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
            Console.WriteLine($"\n\tNome: {Nome}, sobrenome: {Sobrenome}, \n\tidade: {Idade}, \n\tE-mail: {Email}, \n\tendereço: {Endereco}");
        }

    }




}
