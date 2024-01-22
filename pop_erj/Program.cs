using System;

namespace PoPRefactoring
{
    public class PopProject
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Introdueix el dia, mes i any");

            int dia = Convert.ToInt32(Console.ReadLine());
            int mes = Convert.ToInt32(Console.ReadLine());
            int any = Convert.ToInt32(Console.ReadLine());

            bool esDataValida = ValidarData(dia, mes, any);
            if (esDataValida)
            {
                Console.WriteLine("La data és correcta");
            }
            else
            {
                Console.WriteLine("El format no és correcte");
            }
        }

        public static bool ValidarData(int dia, int mes, int any)
        {
     
            if (dia < 1 || dia > 31 || mes < 1 || mes > 12)
            {
                return false;
            }

            int totalDiesMes = DeterminarDiesMes(mes, any);

            return dia <= totalDiesMes;
        }

        private static int DeterminarDiesMes(int mes, int any)
        {
            switch (mes)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    return 31;

                case 4:
                case 6:
                case 9:
                case 11:
                    return 30;

                case 2:
                    return (any % 400 == 0) || ((any % 4 == 0) && (any % 100 != 0)) ? 29 : 28;

                default:
                    return 0; 
            }
        }
    }
}
