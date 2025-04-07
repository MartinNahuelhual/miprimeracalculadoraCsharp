using System; // Importe Librerias Básicas

class Program
{
static void Main(string[] args) // Todo el código debe ir dentro del método Main
    {

    // Aca muestra el Menu
    Console.WriteLine("=== Calculadora en C# ===");
    Console.WriteLine("Seleccione una operación");
    Console.WriteLine("1. Sumar");
    Console.WriteLine("2. Restar");
    Console.WriteLine("3. Multiplicar");
    Console.WriteLine("4. Dividir");
    Console.Write("Opción: ");

    // Opcion de usuario
    int opcion = Convert.ToInt32(Console.ReadLine());

    // Pedira los dos numeros
    Console.Write("Ingrese el primer número: ");
    double num1 = Convert.ToDouble(Console.ReadLine());

    Console.Write("Ingrese el segundo numero: ");
    double num2 = Convert.ToDouble(Console.ReadLine());

    // Variable donde guardamos el resultado
    double resultado = 0;

    // Segun la opción, realizamos la operación
    switch (opcion)
    {
        case 1:
            resultado = num1 + num2;
            Console.WriteLine($"Resultado: {resultado}");
            break;
        case 2:
        resultado = num1 - num2;
        Console.WriteLine($"Resultado: {resultado}");
            break;
        case 3:
            resultado = num1 * num2;
            Console.WriteLine($"Resultado: {resultado}");
            break;
        case 4:
        // Validamos que no se divida por cero
        if (num2 !=0)
        {
            resultado = num1 / num2;
            Console.WriteLine($"Resultado: {resultado}");
        }
        else
        {
            Console.WriteLine("Error: No se puede dividir por cero.");
        }
        break;
    default:
        Console.WriteLine("Opción inválida.");
        break;
}

    // Esperamos una tecla antes de salir
    Console.WriteLine("Presione cualquier tecla para salir...");
    Console.ReadKey();
    }
}