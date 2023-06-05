//  PUNTO 3
using System;
using System.Collections.Generic;

string[] arrayOperaciones = {"Math.Abs(num1)", "Math.Pow(num1, 2)", "Math.Sqrt(numero)", "Math.Sin(angRadianes)", "Math.Cos(angRadianes)" };

// En lugar de almacenar las operaciones en un arreglo como en calculadora1 las almaceno en un diccionario ya que considero que es una estructura de datos mas adecuada
Dictionary<string, Func<double, double>> operaciones = new Dictionary<string, Func<double, double>>();

//agrego las operaciones al diccionario haciando uso de .Add
operaciones.Add("Valor Absoluto", Math.Abs);
operaciones.Add("Cuadrado", x => Math.Pow(x, 2));
operaciones.Add("Raiz Cuadrada", Math.Sqrt);
operaciones.Add("Seno", Math.Sin);
operaciones.Add("Coseno", Math.Cos);
operaciones.Add("Parte Entera", Math.Floor);

Console.WriteLine("\nPor favor ingrese un numero para operar:");
double.TryParse(Console.ReadLine(), out double num1);
Console.WriteLine();  // devo buscar otra froma de dejar los espacios jajajsd

foreach (var operacion in operaciones)
{
    string nombreOperacion = operacion.Key;
    Func<double, double> funcionOperacion = operacion.Value; 
    Console.WriteLine($"Operación: {nombreOperacion}");
    Console.WriteLine($"Resultado: {funcionOperacion(num1)} \n"); 
}


Console.Write("\nPor favor ingrese un numero: \nNum1 = ");
double.TryParse(Console.ReadLine(), out double num2);

Console.Write("\nPor favor ingrese un numero: \nNum2 = ");
double.TryParse(Console.ReadLine(), out double num3);

double[] numeros = {num2, num3};

Console.Write($"\nEl valor máximo es: {numeros.Min()}\n");
Console.Write($"El valor mínimo es: {numeros.Min()}");