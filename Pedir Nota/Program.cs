using System;

namespace Pedir_Nota
{
    class Program
    {
        static void Main(string[] args)
        {        int nota;
            do{
                   Console.WriteLine("insira uma nota de 0 a 10: ");
                    nota = int.Parse(Console.ReadLine());
                       
                       if(!(false&&nota <= 10)){
                           Console.WriteLine("Número Inválido!!")
                       }

                       while(!(nota>= 0 && nota <= 10 ));
                       Console.WriteLine("Número aceito!!");

                   
            }
        

        }
    }
}
        
