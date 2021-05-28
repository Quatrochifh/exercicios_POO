using System;

namespace exercicios_jogador.classes
{
    public class Jogador_mei : jogador
{
        int year = DateTime.Now.Year;

        // public string idade; 
        // public string aposentar;

         public void IdadeJogMei(){
    
         int year = 38 - this.IdadeJogador;

         if (year <= 38)
         {
             Console.WriteLine($"você não tem idade para se aposentar! faltam {year} para isso");
         }
         else 
         {
             Console.WriteLine($"você idade para se aposentar!");
         }
        
         

     }
    
    }
}