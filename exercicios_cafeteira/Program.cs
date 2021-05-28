using System;
using static exercicios_cafeteira.classes.MaquinaCafe;

namespace exercicios_cafeteira
{
    class Program
    {
        static void Main(string[] args)
        {
              MaquinaDeCafe m = new MaquinaDeCafe();
              


          Console.WriteLine(@"
|Cafeteira Tabajaras Plus++
|===========================|
|Deseja um café? (s/n) |
|============================");
          string cafe = Console.ReadLine();

          if (cafe == "s")
          {

             Console.WriteLine(@"
|=========================|
|Com açúcar ou sem açúcar?|
|digite com ou sem:       |
==========================|");
             string acucar = Console.ReadLine();

             if (acucar == "com")
             {
               Console.WriteLine("Deseja inserir uma quantidade específica de açúcar? (s/n)");
               string cafeacuca = Console.ReadLine();

               if (cafeacuca == "s")
               {
                m.fazerCafe(0); 
               } else if (cafeacuca == "n"){
                m.fazerCafe();
               }

             } else if (acucar == "sem")
             {
               m.fazerCafe("seu café sem açucar esta pronto!!");  
             }

          } else {
           Console.WriteLine("Obrigado!");   
          }
        }
    }
}
