class estacionamiento
{
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
                    Console.WriteLine("");
                    //aca agregen la graficadora
                    Console.WriteLine("seleccione el estacionamiento que desea utilizar");
                    Console.WriteLine("");
                    //aca agregen la opcion para que el usuario eliga el estacionamient

                    break;
                case 2:
                    Console.WriteLine("los estacionamientos disponibles para un vehiculo tipo sedan son los siguientes: ");
                    Console.WriteLine("");
                    //aca agregen la graficadora (literalmente solo copie y pegue ya que es la misma mamada XD
                    Console.WriteLine("seleccione el estacionamiento que desea utilizar");
                    Console.WriteLine("");
                    //aca agregen la opcion para que el usuario eliga el estacionamient

                    break;
                case 3:
                    Console.WriteLine("los estacionamientos disponibles para camioneta son los siguientes: ");
                    Console.WriteLine("");
                    //aca agregen la graficadora
                    Console.WriteLine("seleccione el estacionamiento que desea utilizar");
                    Console.WriteLine("");
                    //aca agregen la opcion para que el usuario eliga el estacionamient
                    break;
                case 4:
                    Console.WriteLine("los estacionamientos disponibles para microbuses son los siguientes: ");
                    Console.WriteLine("");
                    //aca agregen la graficadora
                    Console.WriteLine("seleccione el estacionamiento que desea utilizar");
                    Console.WriteLine("");
                    //aca agregen la opcion para que el usuario eliga el estacionamient
                    break;
                case 5:
                    Console.WriteLine("Gracias por visitarnos esperamos que vuelva pronto :V");
                    salir=true;
                    Console.ReadKey();

                    break;
               

            }



        }
    }
}
