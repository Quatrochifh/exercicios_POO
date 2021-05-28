using System;
namespace exercicios_jogador.classes
{
    public class Jogador_ata : jogador
    {
        // public string idadeata; 
        // public string aposentarata;

         public void IdadeJogata(){
        
         int year = 35 - this.IdadeJogador;

         if (year <= 35)
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