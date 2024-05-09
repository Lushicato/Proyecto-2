class Estacionamiento
{
    public class grafica
    {
        bool[] estacionamientos = new bool[30]; 
        public void dibujar()
        {
          
            Console.WriteLine("Estacioamientos dispobibles");

            for (int i = 0; i < estacionamientos.Length; i++)
            {
                Console.Write("estacionamiento " + (i + 1) + ": ");
                if (estacionamientos[i])
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                Console.WriteLine(Rectangulo(5, 3)); 
                Console.ResetColor(); 
            }
        }

        private string Rectangulo(int altura, int ancho)
        {
            string rectangulo = "";
            for (int i = 0; i < altura; i++)
            {
                for (int j = 0; j < ancho ; j++)
                {
                    rectangulo += "*";
                }
                rectangulo += "\n"; 
            }
           
        }
    }

}

static void Main(string[] args
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