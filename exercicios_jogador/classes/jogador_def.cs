using System;
namespace exercicios_jogador.classes
{
    public class jogador_def : jogador
    {
        

        // public string idadeDef; 
        // public string aposentarDef;

         public void IdadeJogDef(){
        
         int year = 40 - this.IdadeJogador;

         if (year <= 40)
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