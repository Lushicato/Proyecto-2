class estacionamiento
{
    static bool[,,] espaciosOcupados;
    static void Graficar()
    {
        int filas = 3;
        int columnas = 3;
        int niveles = 4;
        int numEspacios = 8;

        espaciosOcupados = new bool[filas, numEspacios, niveles];

        DibujarEstacionamiento(filas, columnas, niveles, numEspacios);

        Console.WriteLine("Seleccione el número de nivel:");
        int nivelSeleccionado = int.Parse(Console.ReadLine());

        Console.WriteLine("Seleccione el número de espacio que desea ocupar:");
        int espacioSeleccionado = int.Parse(Console.ReadLine());

        for (int i = 0; i < filas; i++)
        {
            espaciosOcupados[i, espacioSeleccionado - 1, nivelSeleccionado - 1] = true;
        }

        DibujarEstacionamiento(filas, columnas, niveles, numEspacios);
    }

    static void DibujarEstacionamiento(int filas, int columnas, int niveles, int numEspacios)
    {
        for (int k = 0; k < niveles; k++)
        {
            Console.WriteLine($"Nivel {k + 1}:");
            for (int i = 0; i < filas; i++)
            {
                for (int e = 0; e < numEspacios; e++)
                {
                    if (espaciosOcupados[i, e, k])
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }

                    for (int j = 0; j < columnas; j++)
                    {
                        if (i == 0 || i == filas - 1 || j == 0 || j == columnas - 1)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    Console.Write("  ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        Console.ResetColor();
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Bienvenido al estacionamiento UNICAES");
        Console.WriteLine("Por favor elija una opcion de su tipo de vehiculo");
        bool salir = false;

        while (!salir)
        {
            Console.WriteLine("1. Motocicleta");
            Console.WriteLine("2. Sedan");
            Console.WriteLine("3. Camioneta");
            Console.WriteLine("4. Microbus");
            Console.WriteLine("5. Salir");

            int opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("los estacionamientos disponibles para motocicleta son los siguientes:");
                    Graficar();
                    break;
                case 2:
                    Console.WriteLine("los estacionamientos disponibles para un vehiculo tipo sedan son los siguientes: ");
                    Graficar();
                    Console.WriteLine("seleccione el estacionamiento que desea utilizar");
                    Console.WriteLine("");
                    break;
                case 3:
                    Console.WriteLine("los estacionamientos disponibles para camioneta son los siguientes: ");
                    Console.WriteLine("");
                    Graficar();
                    Console.WriteLine("seleccione el estacionamiento que desea utilizar");
                    Console.WriteLine("");
                    break;
                case 4:
                    Console.WriteLine("los estacionamientos disponibles para microbuses son los siguientes: ");
                    Console.WriteLine("");
                    Graficar();
                    Console.WriteLine("seleccione el estacionamiento que desea utilizar");
                    Console.WriteLine("");
                    break;
                case 5:
                    Console.WriteLine("Gracias por visitarnos esperamos que vuelva pronto");
                    salir = true;
                    Console.ReadKey();

                    break;


            }



        }
    }
}