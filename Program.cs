  bool continuar = true;

while (continuar)
{
    Console.Write("Ingrese el primer número: ");
    double num1 = Convert.ToDouble(Console.ReadLine());

    Console.Write("Ingrese el operador (+, -, *, /): ");
    string? operador = Console.ReadLine();

    Console.Write("Ingrese el segundo número: ");
    double num2 = Convert.ToDouble(Console.ReadLine());

    double resultado = 0;
    bool valido = true;

    switch (operador)
    {
        case "+":
            resultado = num1 + num2;
            break;
        case "-":
            resultado = num1 - num2;
            break;
        case "*":
            resultado = num1 * num2;
            break;
        case "/":
            if (num2 == 0)
            {
                Console.WriteLine("No se puede dividir por cero.");
                valido = false;
            }
            else
            {
                resultado = num1 / num2;
            }
            break;
        default:
            Console.WriteLine("Operador no válido.");
            valido = false;
            break;
    }

    if (valido)
    {
        Console.WriteLine("Resultado: " + resultado);
    }

    Console.Write("¿Desea realizar otra operación? (s/n): ");
    string? respuesta = Console.ReadLine();
    if (respuesta?.ToLower() != "s")
    {
        continuar = false;
    }

    Console.WriteLine();
}