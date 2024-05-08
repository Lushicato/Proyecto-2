class Estacionamiento
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bienvenido al estacionamiento UNICAES");
        Console.WriteLine("Por favor elija una opcion de su tipo de vehiculo");
        bool salir=false;
        while(!salir)
        {
            Console.WriteLine("1. Motocicleta");
            Console.WriteLine("2. Sedan");
            Console.WriteLine("3. Camioneta");
            Console.WriteLine("4. Microbus");
            Console.WriteLine("5. Salir");
            int Opcion = Convert.ToInt32(Console.ReadLine());

            switch (Opcion)
            {

            }
        }
    }
}