using System;

namespace functions
{
    class Program
    {
        static void Main(string[] args)
        {
           string[] nomes = new string[10];
           float[] nota1 = new float[10];
            float[] nota2 = new float[10];
            float[] nota3 = new float[10];
             float[] nota4 = new float[10];
             float[] media = new float[10];
         
         for(var i = 0 ; i < 10; i++)
                  {
             Console.WriteLine("digite o nome do aluno:");
            nomes[i] = Console.ReadLine();
            //------------------------------------------------------------

            Console.WriteLine("digite a primeira nota");
            nota1[i]= float.Parse(Console.ReadLine());

             Console.WriteLine("digite a segunda nota");
            nota2[i]= float.Parse(Console.ReadLine());

             Console.WriteLine("digite a terceira nota");
            nota3[i]= float.Parse(Console.ReadLine());

             Console.WriteLine("digite a quarta nota");
            nota4[i]= float.Parse(Console.ReadLine());

            //-------------------------------------------------------------
            //média
            media[i]= (nota1[i] + nota2[i] + nota3[i] + nota4[i]) /4;
         }

         for( var i = 0; i < 10 ; i++){
             Console.WriteLine($"O aluno {nomes[i]}  possui media de {media[i]}");
         }

        }
    }
}
