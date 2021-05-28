using System;
using exercicios_jogador.classes;

namespace exercicios_jogador
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Bem vindo! vamos realizar seu cadastro!");
            
            jogador j = new jogador();
            Jogador_mei m = new Jogador_mei();
            jogador_def d = new jogador_def();
            Jogador_ata a = new Jogador_ata();
             Console.WriteLine(j.CadastroJogador());


             
                 Console.WriteLine($@"
=====================================|
Em qual posição você joga?:          |
                                     |
A- Ataque                            |
D- Defesa                            |
M- Meio                              |
X- Cancelar pagamento");

            string opcao = Console.ReadLine().ToLower();

            switch (opcao)
            {
                case "a":
                    a.CalcularIdade();
                    a.IdadeJogata();
                    a.NomeJogador();
                break;  

                case "d":
                   d.CalcularIdade();
                   d.IdadeJogDef();
                   d.NomeJogador();
                break;  

                case "m":
                   m.CalcularIdade();
                   m.IdadeJogMei();
                   m.NomeJogador();
                break;  

                case "x":
                    Console.WriteLine(j.Cancelar());
                break;  

                default:
                break;
            }
        }
    }
}
