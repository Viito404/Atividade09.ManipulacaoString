using System.Net.Http.Headers;

namespace CifraDeCesar
{
     internal class Program
     {
          static void Main(string[] args)
          {

               Console.WriteLine("Entre com uma palavra: ");
               string palavra = Console.ReadLine().ToUpper();

               char[] novaPalavra = palavra.ToCharArray();

               Console.WriteLine("\nEntre com o valor de deslocamento do alfabeto (x = 1 letras para a direita): ");
               int valorDeslocamento = Convert.ToInt32(Console.ReadLine());
     
               for(int i = 0; i < palavra.Length; i++)
               {
                   char novasLetras = Convert.ToChar((int)palavra[i] + valorDeslocamento);
                    novaPalavra[i] = novasLetras;
               }

               string novaPalavraFormatada = string.Join("", novaPalavra);

               Console.WriteLine($"\nPalavra Antiga: {palavra}");

               Console.WriteLine($"\nPalavra Nova: {novaPalavraFormatada}");

               Console.ReadLine();
          }
     }
}