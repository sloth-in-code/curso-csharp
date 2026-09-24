// Bucles: While y For.
// ejercicio A
Console.WriteLine("Calculadora de edad Mejorado");
Console.WriteLine("================================");
// aqui pedimos los datos al usuario.
Console.Write("¿Cuál es tu nombre? ");
string? nombreUsuario = Console.ReadLine();
Console.Write("¿Cuál es tu Año de nacimiento? ");
int anioNacimiento = int.TryParse(Console.ReadLine(), out int parsedAnioNacimiento) ? parsedAnioNacimiento : 0;
int anioActual = DateTime.Now.Year;

// Validamos que el año de nacimiento sea válido
while (anioNacimiento <= 0 || anioNacimiento > anioActual)
{
    Console.WriteLine("Por favor, ingresa un año de nacimiento válido.");
    Console.Write("¿Cuál es tu Año de nacimiento? ");
    anioNacimiento = int.TryParse(Console.ReadLine(), out parsedAnioNacimiento) ? parsedAnioNacimiento : 0;
}

// Calculamos la edad del usuario. y si es mayor o menor de edad.
int edad = anioActual - anioNacimiento;

// Mostramos el resultado al usuario.
if (edad >= 18)
{
    Console.WriteLine($"Hola {nombreUsuario}, eres mayor de edad y tienes {edad} años.");
}
else
{
    Console.WriteLine($"Hola {nombreUsuario}, eres menor de edad y tienes {edad} años.");
}

// Ejercicio B
// Tabla de multiplicar
Console.Write("Ingrese un número para ver su tabla de multiplicar: ");
int numero = int.TryParse(Console.ReadLine(), out int parsedNumero) ? parsedNumero : 0;
while (numero <= 0)
{
    Console.WriteLine("Por favor, ingresa un número positivo para la tabla de multiplicar.");
    Console.Write("Ingrese un número para ver su tabla de multiplicar: ");
    numero = int.TryParse(Console.ReadLine(), out parsedNumero) ? parsedNumero : 0;
}
for (int i = 1; i <= 12; i++)
{
    Console.WriteLine($"{numero} x {i} = {numero * i}");
}



// For y while: ejercicio cuenta regresiva
Console.Write("Ingrese un número para hacer una cuenta regresiva: ");
int numeroRegresivo = int.TryParse(Console.ReadLine(), out int parsedNumeroRegresivo) ? parsedNumeroRegresivo : 0;

while (numeroRegresivo <= 0)
{
    Console.WriteLine("Por favor, ingresa un número positivo para la cuenta regresiva.");
    Console.Write("Ingrese un número para hacer una cuenta regresiva: ");
    numeroRegresivo = int.TryParse(Console.ReadLine(), out parsedNumeroRegresivo) ? parsedNumeroRegresivo : 0;
}
for (int i = numeroRegresivo; i >= 0; i--)
{
    Console.WriteLine($"Despegando en {i}");
}
Console.WriteLine("¡Despegue! 🚀");