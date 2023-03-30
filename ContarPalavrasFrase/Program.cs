namespace ContarPalavrasFrase
{
     internal class Program
     {
          static void Main(string[] args)
          {
               Console.WriteLine("Escreva uma frase: ");
               string frase = Console.ReadLine();

               string[] palavras = frase.Split(" ");
               Console.WriteLine($"\nSua frase:{frase}");
               Console.WriteLine($"\nNúmero de palavras:{palavras.Length}");
               Console.ReadLine();
          }
     }
}