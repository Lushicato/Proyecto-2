class Program
{
    static bool[,,] espaciosOcupados;

    static void InicializarEspacios(int filas, int numEspacios, int niveles)
    {
        if (espaciosOcupados == null)
        {
            espaciosOcupados = new bool[filas, numEspacios, niveles];
        }
    }

    static void Graficar(int filas, int columnas, int niveles, int numEspacios, int tipoVehiculo, string placas)
    {
        DibujarEstacionamiento(filas, columnas, niveles, numEspacios);

        int nivelSeleccionado = ObtenerNivel(niveles);
        int espacioSeleccionado = ObtenerEspacio(numEspacios);

        Pago.Cobrar(tipoVehiculo);

        DateTime horaIngreso = DateTime.Now;

        for (int i = 0; i < filas; i++)
        {
            espaciosOcupados[i, espacioSeleccionado - 1, nivelSeleccionado - 1] = true;
        }

        DibujarEstacionamiento(filas, columnas, niveles, numEspacios);

        Console.WriteLine($"Recibo de estacionamiento:");
        Console.WriteLine($"Número de placas: {placas}");
        Console.WriteLine($"Hora de ingreso: {horaIngreso}");
    }

    static int ObtenerNivel(int niveles)
    {
        int nivelSeleccionado;
        while (true)
        {
            Console.WriteLine("Seleccione el número de nivel:");
            if (int.TryParse(Console.ReadLine(), out nivelSeleccionado) && nivelSeleccionado > 0 && nivelSeleccionado <= niveles)
            {
                break;
            }
            else
            {
                Console.WriteLine("Nivel inválido. Por favor, ingrese un número entre 1 y " + niveles + ".");
            }
        }
        return nivelSeleccionado;
    }

    static int ObtenerEspacio(int numEspacios)
    {
        int espacioSeleccionado;
        while (true)
        {
            Console.WriteLine("Seleccione el número de espacio que desea ocupar:");
            if (int.TryParse(Console.ReadLine(), out espacioSeleccionado) && espacioSeleccionado > 0 && espacioSeleccionado <= numEspacios)
            {
                break;
            }
            else
            {
                Console.WriteLine("Espacio inválido. Por favor, ingrese un número entre 1 y " + numEspacios + ".");
            }
        }
        return espacioSeleccionado;
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
                    Console.Write(" ");
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
        bool salir = false;

        int filas = 3;
        int columnas = 3;
        int niveles = 4;
        int numEspacios = 8;

        InicializarEspacios(filas, numEspacios, niveles);

        while (!salir)
        {
            Console.WriteLine("Por favor elija una opción de su tipo de vehículo:");
            Console.WriteLine("1. Motocicleta");
            Console.WriteLine("2. Sedan");
            Console.WriteLine("3. Camioneta");
            Console.WriteLine("4. Microbus");
            Console.WriteLine("5. Salir");

            int opcion;
            if (int.TryParse(Console.ReadLine(), out opcion))
            {
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Los estacionamientos disponibles para motocicleta son los siguientes:");
                        Console.WriteLine("Ingrese el número de placas:");
                        string placasMoto = Console.ReadLine();
                        Graficar(filas, columnas, niveles, numEspacios, opcion, placasMoto);
                        break;
                    case 2:
                        Console.WriteLine("Los estacionamientos disponibles para un vehículo tipo sedan son los siguientes:");
                        Console.WriteLine("Ingrese el número de placas:");
                        string placasSedan = Console.ReadLine();
                        Graficar(filas, columnas, niveles, numEspacios, opcion, placasSedan);
                        break;
                    case 3:
                        Console.WriteLine("Los estacionamientos disponibles para camioneta son los siguientes:");
                        Console.WriteLine("Ingrese el número de placas:");
                        string placasCamioneta = Console.ReadLine();
                        Graficar(filas, columnas, niveles, numEspacios, opcion, placasCamioneta);
                        break;
                    case 4:
                        Console.WriteLine("Los estacionamientos disponibles para microbuses son los siguientes:");
                        Console.WriteLine("Ingrese el número de placas:");
                        string placasMicrobus = Console.ReadLine();
                        Graficar(filas, columnas, niveles, numEspacios, opcion, placasMicrobus);
                        break;
                    case 5:
                        Console.WriteLine("Gracias por visitarnos. ¡Esperamos que vuelva pronto!");
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Opción inválida. Por favor, seleccione una opción entre 1 y 5.");
                        break;
                }

                if (!salir)
                {
                    Console.WriteLine("\nPresione cualquier tecla para continuar...");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            else
            {
                Console.WriteLine("Opción inválida. Por favor, ingrese un número.");
            }
        }
    }
}

class Pago
{
    public static void Cobrar(int tipoVehiculo)
    {
        double tarifa = 0;
        switch (tipoVehiculo)
        {
            case 1:
                tarifa = 2.0;
                break;
            case 2:
                tarifa = 5.0;
                break;
            case 3:
                tarifa = 7.0;
                break;
            case 4:
                tarifa = 10.0;
                break;
            default:
                Console.WriteLine("Tipo de vehículo inválido.");
                return;
        }

        Console.WriteLine($"La tarifa para el vehículo seleccionado es: ${tarifa}");
        double montoInsertado;
        while (true)
        {
            Console.WriteLine("Por favor, inserte el monto:");
            if (double.TryParse(Console.ReadLine(), out montoInsertado) && montoInsertado >= 0)
            {
                break;
            }
            else
            {
                Console.WriteLine("Monto inválido. Por favor, ingrese un monto válido.");
            }
        }

        if (montoInsertado >= tarifa)
        {
            double cambio = montoInsertado - tarifa;
            Console.WriteLine($"Pago exitoso. Su cambio es: ${cambio}");
        }
        else
        {
            Console.WriteLine("Monto insuficiente. Por favor, inserte el monto completo.");
        }
    }
}