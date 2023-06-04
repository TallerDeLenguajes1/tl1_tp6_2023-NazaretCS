//  PUNTO 2
using System.Data;  // para poder usar a DataTable

string[] operacionesSimbol = { "+", "-", "*", "/" };
string respuesta;

do
{
    Console.WriteLine("\n\nSeleccione la operación a Realizar:");
    Console.WriteLine("\t1 - Suma \n\t2 - Resta\n\t3 - Multiplicación\n\t4 - Divición\n\t");
    int.TryParse(Console.ReadLine(), out int operacionRealizar);
    
    // Obtengo los numeros a operar...
    Console.WriteLine("Ingrese el primer valor a operar:");
    float.TryParse(Console.ReadLine(), out float valor1);

    Console.WriteLine("\nIngrese el segundo valor a operar:");
    float.TryParse(Console.ReadLine(), out float valor2);

    // formulo la exprecion como string
    string expresion = $"{valor1} {operacionesSimbol[operacionRealizar - 1]} {valor2}";

    DataTable dt = new DataTable();
    object resultado = dt.Compute(expresion, ""); // ejecuto la operacion y la almaceno en resultado
    Console.WriteLine("\nEl resutado es: " + resultado);

    Console.Write("¿Desea realizar otro cálculo?  1 = Si, 0 = No \n");
    respuesta = Console.ReadLine();
} while (respuesta == "1");