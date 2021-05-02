using System;

namespace Heron_Se_Triangle
{
    class Program
    {
        static void Main(string[] args)

        {
            double a1, b1, c1, area1;

            Console.Clear();
            Console.ForegroundColor=ConsoleColor.Green;
            Console.Write(
                "\nOLÁ! ESTE PROGRAMA CALCULARÁ O SEMIPERÍMETRO, ÁREA"); 
            Console.WriteLine(" E O MAIOR TRIÂNGULO PARA VOCÊ, DE FORMA RÁPIDA E FÁCIL!");
            Console.ResetColor();
  
            a1= TypeSide("'A' DO PROMEIRO TRIÂNGULO");
            b1= TypeSide("'B' DO PROMEIRO TRIÂNGULO");
            c1= TypeSide("'C' DO PROMEIRO TRIÂNGULO");

            if (ValidTriangle(a1, b1, c1))
            {
                //é um triângulo.
                area1= CalculateArea(a1, b1, c1);
                DisplaysArea(area1);

                //segundo triângulo.
                double a2, b2, c2, area2;
                a2 = TypeSide ("'A' DO SEGUNDO TRIÂNGULO");
                b2 = TypeSide ("'B' DO SEGUNDO TRIÂNGULO");
                c2 = TypeSide ("'C' DO SEGUNDO TRIÂNGULO");

                if (ValidTriangle(a2, b2, c2))
                {
                    area2= CalculateArea(a2, b2, c2);
                    DisplaysArea(area2);

                    //exibir o maior 
                    if(area1 > area2)
                    {
                        Console.Clear();
                        Console.ForegroundColor=ConsoleColor.Cyan;
                        Console.WriteLine("\n\nO SEGUNDO TRIÂNGULO É MAIOR.");
                        Console.ResetColor();
                    }
                    else if(area2 > area1)
                    {
                        Console.Clear();
                        Console.ForegroundColor=ConsoleColor.Cyan;
                        Console.WriteLine("\n\nO SEGUNDO TRIÂNGULO É MAIOR.");
                        Console.ResetColor();
                    }
                    else 
                    {
                        Console.Clear();
                        Console.ForegroundColor=ConsoleColor.Cyan;
                        Console.WriteLine(
                            "\n\nOS  TRIÂNGULOS POSSUEM A MESMA ÁREA.");
                        Console.ResetColor();  
                    }
                }
                else 
                {
                    //não é um triângulo.
                    DisplaysNo(a2, b2, c2);
                }
            }
            else
            { 
                //não é um triângulo.
                DisplaysNo(a1, b1, c1);
            }

            Console.ForegroundColor=ConsoleColor.Green;
            Console.WriteLine("\n\nOBRIGADA POR ULTILIZAR NOSSO PROGRAMA!");
            Console.ResetColor();
            Environment.Exit(-1);
        }
        static double CalculateArea(double l1, double l2, double l3)
        {
            double sp= (l1 + l2 + l3) / 2;
            double area= Math.Sqrt(sp * (sp-l1) * (sp-l2) * (sp-l3));
            return area;
        }

        static bool ValidTriangle(double l1, double l2, double l3)
        {
            return (l1 < (l2 + l3) &&
                l1 > Math.Abs(l2 - l3) &&
                l2 < (l1 + l3) &&
                l2 > Math.Abs(l1 - l3) &&
                l3 < (l1 + l2) &&
                l3 > Math.Abs(l1 - l2));
        }
        static double TypeSide ( string sideName)
        {
            Console.ForegroundColor=ConsoleColor.Magenta;
            Console.Write($"\nDIGITE O LADO {sideName}..:");
            Console.ResetColor();
            return Convert.ToDouble(Console.ReadLine());
        }

        static void DisplaysArea (double area)
        {
            Console.ForegroundColor=ConsoleColor.Cyan;
            Console.WriteLine($"\n\nA área é {area}.");
            Console.ResetColor();
        }
    
        static void DisplaysNo(double l1, double l2, double l3)
        {
            Console.Clear();
            Console.ForegroundColor=ConsoleColor.Red;
            Console.WriteLine(
                $"\nOS LADOS {l1}, {l2} E {l3} NÃO FORMAM UM TRIÂNGULO!");
            Console.ResetColor();
            Environment.Exit(-1);
        }
    }
}
