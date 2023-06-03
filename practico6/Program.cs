// See https://aka.ms/new-console-template for more information

/**
Console.WriteLine("Hello, World!5");

int a;

int b;

a = 10;

b = a;

Console.WriteLine("Valor de la variable a:"+a);
Console.WriteLine("valor de b:"+b);
*/


//  PUNTO 1

int num = 0;
Console.WriteLine("Por favor ingrese el numero a convertir...");
string cadena = Console.ReadLine();
bool control = int.TryParse(cadena, out num); 


if (control){
    if (num > 0){
        Console.WriteLine("El numero invertido es: ");
        for (int i = 0; i < cadena.Length; i++)
        {
            Console.Write(num%10);
            num = num /10;
        }
    } else {
        Console.WriteLine("El numero ingresado es menor a 0...");
    }
} else {
    Console.WriteLine("Se ingreso un valor que no corresponde...");
}