using System;
using System.Collections.Generic;
using System.Text;

namespace DI_T1_Ej4
{
    class Games
    {
        public Games(int game)
        {
            do {
                switch (game)
                {
                    case 1:
                        Console.WriteLine("Pedir un número al usuario del 1 al X, " +
                            "tirar diez dados mostrando el resultado de cada uno einformar al usuario " +
                            "de cuantas veces ha acertado. " +
                            "X es un parámetro que si no se pasa se inicializa por defecto a 6");
                        Console.ReadLine();

                        this.game1();
                        if (game == 4)
                        {
                            goto case 2;
                        }
                        break;
                    case 2:
                        Console.WriteLine("Juego adivina un número. " +
                            "El ordenador saca un número aleatorio entre 1 y 100. " +
                            "El usuario tiene 5 intentos para adivinarlo." +
                            "Se informa mayor/menor en cada intento así como el número de intentos restantes.");
                        Console.ReadLine();

                        this.game2();
                        if (game == 4)
                        {
                            goto case 3;
                        }
                        break;
                    case 3:
                        Console.WriteLine("Realizar una quiniela: " +
                            "Se deben dar 14 resultados aleatorios como 1, X ó 2 de forma ponderada. " +
                            "La probabilidad de sacar 1 sea del 60%, la de sacar X sea 25% y " +
                            "la de sacar un 2 sea un 15%. " +
                            "Se debe realizar al menos una función que devuelva un 1 una X o un 2 ponderado de la forma anterior, " +
                            "sacando un número de 1 a 100 y seleccionando el valor devuelto con un switch con clausula when.");
                        Console.ReadLine();

                        this.game3();
                        break;
                    case 4:
                        Console.WriteLine("Jugar a todos. El programa pasará por los 3 apartados anteriores. " +
                            "No se puede llamar simplemente a funciones, es necesario jugar con goto case");
                        goto case 1;
                        break;
                    default:
                        if (game != 0){
                            Console.WriteLine("Esta opción existe porque tiene que existir, " +
                            "pero el usuario no tendría que llegar aquí jamás.");

                        }
                        break;
                }
            }
            while (repetir(game));
        }

        public int numLimiteSuperior { get; set; } = 6;

        public void game1() 
        {
            Random rdm = new Random();
            int pickedNum;
            int aciertos = 0;

            try
            {

                Console.WriteLine("¿Quieres determinar hasta qué número quieres tirar? Pulsa s para confirmar.");
                if (Console.ReadLine() == "s")
                {
                    Console.WriteLine("¿Hasta qué número quieres tirar?");
                    this.numLimiteSuperior = Int32.Parse(Console.ReadLine());
                }

                Console.WriteLine("¿Por qué número apuestas?");
                pickedNum = Int32.Parse(Console.ReadLine());

                for (int i = 0; i < 10; i++)
                {
                    int n = rdm.Next(1, numLimiteSuperior + 1);
                    Console.Write("Tirada: {0}, número {1}. ", i + 1, n);

                    if (n == pickedNum)
                    {
                        Console.WriteLine("Has acertado.");
                        aciertos++;
                    }
                    else
                    {
                        Console.WriteLine("No has acertado.");
                    }
                }
                Console.WriteLine("Has acertado {0} veces.", aciertos);
            }
            catch (FormatException fe)
            {
                Console.WriteLine("No has introducido un número el programa se muere.");
            }
            
        }

        public void game2()
        {
            Random rdm = new Random();
            int userNum, generatedNum;
            generatedNum = rdm.Next(1,101);

            Console.WriteLine("Voy a generar un número del 1 al 100 y tienes que adivinarlo. Tienes 5 intentos.");

            try
            {
                for (int i = 0; i<5;i++)
                {
                    Console.WriteLine("\r\nDime un número del 1 al 100. El número es {0}",generatedNum);
                    userNum = Int32.Parse(Console.ReadLine());
                    if (userNum==generatedNum)
                    {
                        i = 5;
                        Console.WriteLine("Has aceptado.");
                    }
                    else
                    {
                        Console.WriteLine("Te quedan {0} intentos.", 4-i);
                    }
                }
            }
            catch (FormatException fe)
            {
                Console.WriteLine("No has introducido un número, el programa se muere.");
            }

        }

        //"Realizar una quiniela: " +
        //"Se deben dar 14 resultados aleatorios como 1, X ó 2 de forma ponderada. " +
        //"La probabilidad de sacar 1 sea del 60%, la de sacar X sea 25% y " +
        //"la de sacar un 2 sea un 15%. " +
        //"Se debe realizar al menos una función que devuelva un 1 una X o un 2 ponderado de la forma anterior, " +
        //"sacando un número de 1 a 100 y seleccionando el valor devuelto con un switch con clausula when.");
        public void game3()
        {
            Random rdmPorcentaje = new Random();

            for (int i = 0; i<14;i++)
            {
                int unoEquisDos = 1;
                int num = rdmPorcentaje.Next(1, 101);

                Console.WriteLine(Games.unoEquisDos(unoEquisDos, num));
            }
        }

        private static char unoEquisDos(int unoEquisDos, int num)
        {
            switch (unoEquisDos)
            {
                case 1 when num <= 60:
                    return '1';
                case 1 when num > 60 && num <= 85:
                    return 'X';
                default:
                    return '2';
            }
        }

        public bool repetir(int game)
        {
            if (game != 0)
            {
                Console.WriteLine("¿Quieres volver a jugar a este juego? Pulsa s para confirmar.");
                return Console.ReadLine() == "s" ? true:false;
            }
            return false;
        }

    }
}