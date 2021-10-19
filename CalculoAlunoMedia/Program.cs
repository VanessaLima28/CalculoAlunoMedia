using System;

namespace CalculoAlunoMedia
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, media1;

            Console.WriteLine("Digite a primeira nota:");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota: ");
            n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite a terceira nota:");
            n3 = Convert.ToInt32(Console.ReadLine());

            media1 = (n1 + n2 + n3) / 3;
            
            if (media1 >= 7) 
            {
                Console.WriteLine(" Sua média é {0}.Aluno aprovado!", media1);
            } else
            {
                int nota_exame;

                Console.WriteLine("Digite a nota do exame:");
                nota_exame = Convert.ToInt32(Console.ReadLine());

                int media2; 

                media2 = (media1 + nota_exame) / 2;

                if (media2 >= 5)
                {

                    Console.WriteLine("Sua média é {0}.Aluno aprovado!", media2);
                }

                else
                {
                    Console.WriteLine("Sua média é {0}.Aluno reprovado: ", media2);

                }

                
            }

        }
    }
}
