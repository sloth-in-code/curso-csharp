// Primer ejercicio de C#
Console.WriteLine("Este es mi primer programa en C#");
Console.WriteLine("Calculadora de edad");
Console.WriteLine("================================");
// aqui pedimos los datos al usuario.
Console.Write("¿Cuál es tu nombre? ");
string? nombreUsuario = Console.ReadLine();
Console.Write("¿Cuál es tu Año de nacimiento? ");
int anioNacimiento = int.TryParse(Console.ReadLine(), out int parsedAnioNacimiento) ? parsedAnioNacimiento : 0;
int anioActual = DateTime.Now.Year;
// Validamos que el año de nacimiento sea válido
if (anioNacimiento > anioActual)
{
    Console.WriteLine("Aun no has nacido, por favor ingresa un año de nacimiento válido.");
}
else if (anioNacimiento <= 0)
{
    Console.WriteLine("Por favor ingresa un año de nacimiento válido.");
}
else
{
    int edad = anioActual - anioNacimiento;
    if (edad >= 18)
    {
        Console.WriteLine($"Hola {nombreUsuario}, eres mayor de edad y tienes {edad} años.");
    }
    else
    {
        Console.WriteLine($"Hola {nombreUsuario}, eres menor de edad y tienes {edad} años.");
    }
}
