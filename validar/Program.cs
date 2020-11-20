using System;

namespace validar
{
    class Program
    {
        static void Main(string[] args)
        { string nome;
            int idade;
            double salario;
            char estadocivil;
           
           do{
               Console.WriteLine("insira seu nome: ");
               nome = Console.ReadLine(); 


           }while(nome =="" || nome=="");

           do{
               Console.WriteLine("insira sua idade: ");
               idade = int.Parse(Console.ReadLine()); 


        }while(idade <= 0 || idade > 150);

        do{
               Console.WriteLine("insira seu salario: ");
               salario = double.Parse(Console.ReadLine());

    }while( salario > 0);

     do{
               Console.WriteLine("insira seu estado civil : "s" (solteiro), "c" (casado), "d" (divorsiado) e "v" (viuvo)");
                string estado = Console.ReadLine();
               estadocivil = estado.ToCharArray()[0];
               
}while(estadocivil!= "S" && estadocivil!= "c" && estadocivil!= "d" && estadocivil!= "v");
Console.WriteLine("valores aceitos");
        }
    }
