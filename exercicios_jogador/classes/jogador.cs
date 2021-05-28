using System;
namespace exercicios_jogador.classes
{
    public class jogador
    {
          public string Nome;
        public int Datanasc;
        public string nascionalidade;
        public string Altura;
        public string Peso;
        public int IdadeJogador;
        public int anoAtual;

        public string Cancelar(){

            return "Cadastro cancelado";
        }

         public string CalcularIdade(){

        anoAtual = DateTime.Now.Year;
        IdadeJogador = anoAtual - Datanasc;
        Console.WriteLine($"o jogador tem {IdadeJogador} anos");

        return "";
    
        }

        public string CadastroJogador(){
            
            Console.WriteLine("Digite o seu nome");
            Nome = Console.ReadLine();

            Console.WriteLine("Qual a sua nascionalidade?");
            nascionalidade = Console.ReadLine();
            
            
            Console.WriteLine("Qual seu ano de nascimento?");
            Datanasc = int.Parse (Console.ReadLine());

             Console.WriteLine("Digite a sua altura (exemplo 1,87 m)");
            Altura = Console.ReadLine();

            Console.WriteLine("Digite o seu peso (exemplo 84 kg)");
            Peso = Console.ReadLine();

            return $"Obrigado {Nome}!!!";
        }

        public void NomeJogador(){
            Console.WriteLine($"Seu nome é: {Nome}");
            Console.WriteLine($"Sua nascionalidade é: {nascionalidade}");
            Console.WriteLine($"Você nasceu em: {Datanasc}");
            Console.WriteLine($"Sua altura é de {Altura}");
            Console.WriteLine($"Seu peso é: {Peso}");

        }
    }
}