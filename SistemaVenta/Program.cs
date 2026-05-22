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

    Action accion = opcion switch
    {
        1 => RegistrarProductos,
        2 => MostrarProductos,
        3 => CalcularTotal,
        4 => ProductoMasVendido,
        5 => PromedioVentas,
        6 => () => Console.WriteLine("Saliendo..."),
        _ => () => Console.WriteLine("Opción inválida.")
    };
    
    accion();

} while (opcion != 6);

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
    while (!double.TryParse(Console.ReadLine(), out precio) || precio is not > 0);

    precios[contador] = precio;

    int cantidad;
    do
    {
        Console.Write("Ingrese la cantidad vendida: ");
    }
    while (!int.TryParse(Console.ReadLine(), out cantidad) || cantidad is < 0);

    cantidades[contador] = cantidad;
    contador++;

    Console.WriteLine("Producto registrado correctamente.");
}

void CalcularTotal()
{
    if (contador == 0)
    {
        Console.WriteLine("\nTotal vendido: $0.00");
        return;
    }

    double total = ObtenerTotalVendido();
    Console.WriteLine($"\nTotal vendido: ${total:F2}");
}

void ProductoMasVendido()
{
    if (contador == 0)
    {
        Console.WriteLine("No hay productos registrados.");
        return;
    }

    int posicionMayor = 0;

    for (int i = 1; i < contador; i++)
    {
        if (cantidades[i] > cantidades[posicionMayor])
        {
            posicionMayor = i;
        }
    }

    Console.WriteLine("\nProducto más vendido:");
    Console.WriteLine($"Producto: {productos[posicionMayor]}");
    Console.WriteLine($"Cantidad: {cantidades[posicionMayor]}");
}

void PromedioVentas()
{
    if (contador == 0)
    {
        Console.WriteLine("No hay productos registrados.");
        return;
    }

    double promedio = ObtenerTotalVendido() / contador;
    Console.WriteLine($"\nPromedio de ventas por producto: ${promedio:F2}");
}

void MostrarProductos()
{
    if (contador == 0)
    {
        Console.WriteLine("No hay productos registrados.");
        return;
    }

    Console.WriteLine("\n========================================");
    Console.WriteLine("PRODUCTO\t\tPRECIO\t\tCANTIDAD");
    Console.WriteLine("========================================");

    for (int i = 0; i < contador; i++)
    {
        Console.WriteLine($"{productos[i],-15}\t\t${precios[i],-10:F2}\t{cantidades[i]}");
    }
}

double ObtenerTotalVendido()
{
    double total = 0;
    for (int i = 0; i < contador; i++)
    {
        total += precios[i] * cantidades[i];
    }
    return total;
}