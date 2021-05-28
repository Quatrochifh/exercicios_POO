using System;

namespace exercicio_elevador.classes
{
    public class Elevador
    {
        public int andarAtual;
        public int quantidadeAndares;
        public int capacidadeElevador;
        public int subirAndar;
        
        public int descerAndar;
  

        public virtual void Inicializar()
        {
            Console.WriteLine("Quantos andares há no prédio?");
            quantidadeAndares = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual a capacidade máxima do elevador?");
            capacidadeElevador = int.Parse(Console.ReadLine());
        }

       
        
        public void Subir()
        {
            Console.WriteLine("Quantos andares você deseja subir?");
            subirAndar = int.Parse(Console.ReadLine());

            andarAtual = andarAtual + subirAndar;

            if (andarAtual <= quantidadeAndares)
            {
                Console.WriteLine($"Você chegou no {andarAtual}º andar");
            }
            else
            {
                Console.WriteLine("Não é possível subir essa quantidade de andares!");
            }
        }

        public void Descer()
        {

            Console.WriteLine("Quantos andares você deseja descer?");
            descerAndar = int.Parse(Console.ReadLine());

            andarAtual = andarAtual - descerAndar;

            if (andarAtual <= quantidadeAndares && andarAtual >= 0)
            {
                Console.WriteLine($"Você chegou no {andarAtual}º andar");
            }
            else
            {
                Console.WriteLine("Não é possível descer essa quantidade de andares!");
            }
        }
    }
}
