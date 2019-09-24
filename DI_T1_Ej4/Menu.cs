using System;
using System.Collections.Generic;
using System.Text;

namespace DI_T1_Ej4
{
    class Menu
    {
        public string menu;
        public Menu()
        {
            this.menu = "========================================\r\n" +
                "Bienvenido\r\n" +
                "========================================\r\n" +
                "Juego 1: Dados - Pulsa 1.\r\n" +
                "Juego 2: Adivina - Pulsa 2.\r\n" +
                "Juego 3: Quiniela - Pulsa 3.\r\n" +
                "Juego 4: Jugar todo.\r\n" +
                "Salir: Pulsa 0.\r\n" +
                "========================================\r\n" +
                "\r\n";
        }

        public void launchMenu()
        {
            string selection = "";

            while (selection != "0")
            {
                try
                {
                    Console.WriteLine(this.menu);

                    selection = Console.ReadLine();
                    Games onGoingGame = new Games(Int32.Parse(selection));
                }
                catch (FormatException fe)
                {
                    Console.WriteLine("Opción no implementada. Le rogamos que introduzca una opción existente.");
                }
            }
        }
    }
}
