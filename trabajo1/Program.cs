using System;

namespace trabajo1
{
    class Program
    {
        static void Main(string[] args)
        {

            float indice=0;
            float suma=0;
            float credito=0;
            Console.Write("Bienvenido al sistema de calculo de promedio ponderado de O&M\n\nDigite la cantidad de materias a evular:");
            int opcion = int.Parse(Console.ReadLine());
            for(int i=0;i<opcion;i++)
            {
                Console.Write("Ingrese el credito de la materia "+(i+1)+":");
                float auxcredito = float.Parse(Console.ReadLine());
                credito=credito+auxcredito;
                Console.Write("Las notas de las materias son del 0 al 100\nIngresa la nota de la materia "+(i+1)+":");
                float nota = float.Parse(Console.ReadLine());
                float auxnota=0;
                if (nota >=90 && nota <= 100 )
                {
                    auxnota=4;
                }
                if  (nota >=80 && nota <=89 )
                {
                    auxnota=3;
                }
                if (nota >=75 && nota <=79 )
                {
                    auxnota=2;
                }
                if  (nota >=70 && nota <=74 )
                {
                    auxnota=1;
                }
                if  (nota < 70)
                {
                    auxnota=0;
                }
                suma = suma+(auxnota*auxcredito);
                Console.WriteLine();
            }
            indice=suma/credito;
            Console.WriteLine("El promedio ponderado es:"+indice);
        }
    }
}
