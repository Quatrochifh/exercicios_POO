using System;

namespace exercicios_cafeteira.classes
{
    public class MaquinaCafe
    {
         public class MaquinaDeCafe
    {
        public int Disponibilidade = 100;

        public void fazerCafe(int gramas) {

        Console.WriteLine("informe a quantidade que deseja de açúcar: ");
        int quantidade = int.Parse(Console.ReadLine());
        
        if (Disponibilidade < quantidade)
        {
          Console.WriteLine("\nNãotem açúcar suficiente para esta quantidade, deseja um café sem açúcar? (s/n) ");
          string escolha = Console.ReadLine();
          if (escolha == "s")
          {
            Console.WriteLine("Saindo um café sem açúcar");
            Console.WriteLine("seu café sem açúcar está pronto");
          } else if (escolha == "n")
          {
            Console.WriteLine("Okay! desculpe pelo incomodo!");
          }
        } else if (Disponibilidade > quantidade && quantidade > 0)
        {
            Console.WriteLine("Saindo café com açúcar!"); 
            Console.WriteLine($"seu cafézinho com {quantidade}g de açúcar está pronto, volte sempre :D"); 
            
        }

        }
        public void fazerCafe(){
        if (Disponibilidade >= 10)
        {
          Console.WriteLine("Saindo café com açúcar");  
          Console.WriteLine("seu café sem açúcar está pronto");  
          
        } else {
          Console.WriteLine("Não tem açúcar suficiente para esta quantidade, deseja um café sem açúcar? (s/n)");
          string escolha = Console.ReadLine();
          if (escolha == "s")
          {
            Console.WriteLine("Saindo um café sem açúcar");
            Console.WriteLine("seu café sem açúcar está pronto");  

          } else if (escolha == "n")
          {
            Console.WriteLine("Obrigado por utilizar nossa maquina");
          }
        }

        }
        public void fazerCafe(string sem) {
        Console.WriteLine("Saindo cafézinho sem açúcar...");
         Console.WriteLine("seu cafézinho sem açúcar está pronto, volte sempre :D");  
        }

    }
  }
}