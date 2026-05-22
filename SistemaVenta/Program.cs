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
void RegistrarProductos()
{
    if (contador >= productos.Length)
    {
        Console.WriteLine("No se pueden registrar más productos.");
        return;
    }

    Console.Write("Ingrese el nombre del producto: ");
    productos[contador] = Console.ReadLine()!;

    double precio;

    do
    {
        Console.Write("Ingrese el precio: ");
    }
    while (!double.TryParse(Console.ReadLine(), out precio) || precio <= 0);

    precios[contador] = precio;

    int cantidad;

    do
    {
        Console.Write("Ingrese la cantidad vendida: ");
    }
    while (!int.TryParse(Console.ReadLine(), out cantidad) || cantidad < 0);

    cantidades[contador] = cantidad;

    contador++;

    Console.WriteLine("Producto registrado correctamente.");
}