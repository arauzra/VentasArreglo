string[] productos = new string[10];
double[] precios = new double[10];
int[] cantidades = new int[10];

int contador = 0;
int opcion;

do
{
    Console.WriteLine("\n===== MENÚ =====");
    Console.WriteLine("1. Registrar productos");
    Console.WriteLine("2. Mostrar productos");
    Console.WriteLine("3. Calcular total vendido");
    Console.WriteLine("4. Mostrar producto más vendido");
    Console.WriteLine("5. Mostrar promedio de ventas");
    Console.WriteLine("6. Salir");

    Console.Write("Seleccione una opción: ");

    int.TryParse(Console.ReadLine(), out opcion);

    switch (opcion)
    {
        case 1:
            RegistrarProductos();
            break;

        case 2:
            MostrarProductos();
            break;

        case 3:
            CalcularTotal();
            break;

        case 4:
            ProductoMasVendido();
            break;

        case 5:
            PromedioVentas();
            break;

        case 6:
            Console.WriteLine("Saliendo...");
            break;

        default:
            Console.WriteLine("Opción inválida.");
            break;
    }

} while (opcion != 6);

void RegistrarProductos()
{

}

void MostrarProductos()
{

}

void CalcularTotal()
{

}

void ProductoMasVendido()
{

}

void PromedioVentas()
{

}