// Listas Foreach y Switch
bool salir = false;
List<decimal> gastos = new List<decimal>();
while (salir == false)
{
    Console.WriteLine("=== MIS GASTOS ===");
    Console.WriteLine("1. Agregar gasto");
    Console.WriteLine("2. Ver gastos");
    Console.WriteLine("3. Ver total");
    Console.WriteLine("4. Salir");
    Console.WriteLine("Elige una opcion del Menu: ");
    
    string? opcion = Console.ReadLine();

    switch (opcion)
    {
        case "1":
            Console.WriteLine("Ingrese el monto del gasto:");
            string? input = Console.ReadLine();
            if (decimal.TryParse(input, out decimal monto) && monto > 0)
            {
                // Agregar gasto a la lista
                gastos.Add(monto);
                Console.WriteLine("Gasto agregado.");
            }
            else
            {
                Console.WriteLine("Monto inválido. Intente de nuevo.");
            }
            break;
        case "2":
            if (gastos.Count == 0)
            {
                Console.WriteLine("No hay gastos registrados.");
            }
            else
            {
                Console.WriteLine("Gastos registrados:");
                foreach (var gasto in gastos)
                {
                    Console.WriteLine($"- {gasto}");
                }
            }
            break;
        case "3":
            // Lógica del total con foreach
            decimal total = 0;
            foreach (var gasto in gastos)
            {
                total += gasto;
            }
            Console.WriteLine($"Total de gastos: {total}");
            break;
        case "4":
            salir = true;
            Console.WriteLine("Adios 👋🏽");
            break;
        default:
            Console.WriteLine("Opción no válida. Intente de nuevo.");
            break;
    }
    
}
