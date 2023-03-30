namespace ImpressaoFuncoesString
{
     internal class Program
     {
          static void Main(string[] args)
          {
               Console.Write("Entre com uma frase:\n> ");
               string frase = Console.ReadLine();

               string[] palavrasFrase = frase.Split(" ");
               char[] letrasFrase = frase.ToCharArray();

               Console.WriteLine($"\nFrase: {frase}");
               Console.WriteLine($"\nFrase em letras maiúsculas: {frase.ToUpper()}");
               Console.WriteLine($"\nFrase em letras minúsculas: {frase.ToLower()}");
               Console.WriteLine($"\nQuantidade de caracteres da frase: {letrasFrase.Length}");
               Console.WriteLine($"\nPrimeira palavra da frase: {palavrasFrase[0]}");
               Console.WriteLine($"\nPrimeira palavra da frase: {palavrasFrase[palavrasFrase.Length - 1]}");
               Console.ReadLine();
          }
     }
}