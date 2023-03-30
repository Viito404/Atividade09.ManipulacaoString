namespace P08.ManipulacaoString
{
     internal class Program
     {
          static void Main(string[] args)
          {
               string frase = "olá, bem-vindos";

               string[] palavras = frase.Split(' ');

               for(int i = 0; i < palavras.Length; i++)
               {
                    palavras[i] = palavras[i].Substring(0, 1).ToUpper() + palavras[i].Substring(1).ToLower();
               }

               string palavrasTitulo = string.Join(" ", palavras);

               Console.Write(palavrasTitulo);
               Console.ReadLine();
          }
     }
}