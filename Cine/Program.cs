namespace Cine
{

    using System.Globalization;

    class cinema
    {

        static void Main(string[] args)
        {


            Console.WriteLine("¡Bienvenidos a CinePoberty, donde el presupuesto solo da para 1 película!\n");
            Console.WriteLine("A continuación se le presentará el menú que tiene para darle una experiencia de 5 estrellas (a pesar de que somos pobres)\n");
            Console.WriteLine("---Menú---");
            Console.WriteLine("1- Salir...\n");
            Console.WriteLine("2- Elegir Película\n");
            Console.WriteLine("3- Elegir Boletos y Asientos\n");
            Console.WriteLine("-----------------\n");
            MostrarMenu();
        }
        static void MostrarMenu()
        {
            int op = 1;

            do
            {
                Console.WriteLine("Escoja una opción");
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        Console.WriteLine("Salir...\n");
                        break;
                    case 2:
                        peliculas();
                        break;
                    case 3:
                        boletos();
                        break;
                    default:
                        Console.WriteLine("Escriba una opción válida");
                        break;
                }
            }
            while (op != 1);


        }


        static void boletos()
        {
            int op = 1;
            int bol;
            int total = 0;

            Console.WriteLine("¿Cuántos boletos desea?");
            bol = int.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine("Los rangos de los boletos son: ");
                Console.WriteLine("1) Salir, 2) Niños, 3) Adolescentes, 4) Adultos, 5) Adulto Mayor");
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        Console.WriteLine("Salir...\n");
                        break;
                    case 2:
                        Console.WriteLine("Para los niños la entrada cuesta $3\n");
                        total += 3;
                        break;
                    case 3:
                        Console.WriteLine("Para los adolescentes la entrada cuesta $4\n");
                        total += 4;
                        break;
                    case 4:
                        Console.WriteLine("Para los adultos la entrada cuesta $5\n");
                        total += 5;
                        break;
                    case 5:
                        Console.WriteLine("Para los adultos mayores la entrada cuesta $3\n");
                        total += 3;
                        break;
                    default:
                        Console.WriteLine("A los tiesos no se les cobra");
                        break;
                }

            }
            while (op != 1);
            Console.WriteLine("El total a pagar es :" + "" + total + "\n");
            int a = 1, filas, col;
            int[,] asientos = new int[5, 5];

            while (a <= bol)
            {
                Console.WriteLine("Por favor ingrese el número de fila, ej. (1-5)");
                filas = int.Parse(Console.ReadLine());
                Console.WriteLine("Por favor ingrese el número de columna, ej. (1-5)");
                col = int.Parse(Console.ReadLine());

                if (asientos[filas - 1, col - 1] == 0)
                {
                    asientos[filas - 1, col - 1] = 1;
                    a = a + 1;
                    Console.WriteLine("Reserva exitosa, si se rompe el asiento, nos paga");
                }
                else
                {
                    Console.WriteLine("Asiento ocupado, busque otro cine con mejor presupuesto");
                }
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        Console.Write(asientos[i, j] + "\t");
                    }
                    Console.WriteLine("\n");
                }
            }
            Console.ReadKey();
        }

        static void peliculas()
        {
            int op;
            Console.WriteLine("Las opciones de película que tiene son: ");
            Console.WriteLine("1)'Súper Mario', 2)'Rápidos y furiosos Parte 1000, 3)'Sonic' ");
            op = int.Parse(Console.ReadLine());
            switch (op)
            {
                case 1:
                    Console.WriteLine("Película elegida con éxito");
                    break;
                case 2:
                    Console.WriteLine("Película elegida con éxito");
                    break;
                case 3:
                    Console.WriteLine("Película elegida con éxito");
                    break;
                default:
                    Console.WriteLine("Ya no hubo presupuesto para más películas, ni para la película en sí, solo son créditos");
                    break;
            }

        }

    }

}