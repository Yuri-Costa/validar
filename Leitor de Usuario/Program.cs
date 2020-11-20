using System;

namespace Leitor_de_Usuario
{
    class Program
    {
    
        static void Main(string[] args)
        {

            string username;
            string senha; 

            do{
                Console.WriteLine("digite seu username:");
                username = Console.ReadLine();

                Console.WriteLine("digite sua senha:");
                senha = Console.ReadLine();

                if(senha == username){ 
                Console.WriteLine("a senha não pode ser igual o nome de usuario:");

                }

            }while(senha == username);
            Console.WriteLine("usuario e senha aceitos!!");
              

        }
    }
}
