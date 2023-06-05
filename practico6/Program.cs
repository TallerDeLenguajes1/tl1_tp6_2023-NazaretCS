// See https://aka.ms/new-console-template for more information
using System.Text.RegularExpressions;
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

/* int num = 0;
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
} */




/*
PUNTO 4

Conversor de tipo: ToString():  permite obtener una representacion en cadena de texto de un objeto

Comparador de cadenas: Compare(), CompareTo() == y !=
    * Compare(cad1, cad2): sirve para comparar las longuitudes de las cadenas, devuelve 1 si cad1 es mayor, un valor negativo en caso contrario y 0 si son iguales.
    * cad1.CompareTo(cad2): es igual al anterior solo q se compara desde cad1.
    * == y != retorna true o false segund si las cadenas son iguales o no, es CaseSensitivity

Mayúsculas y minúsculas: 
    cad1.ToUpper(): Convierte la cadena en mayusuclas
    cad.1ToLower(): convierte la cadena en minusculas

Acceso a los caracteres individuales: 
    * SubString(arg1, arg2): sirve para trar una subcadena de una cadena, sus argumentos son la posicion del caracter desde el cual queremos que empieze la subcadena, y la longitud que queremos que tenga. 
    * Replace():se utiliza para reemplazar todas las ocurrencias de un carácter o una cadena en una cadena de texto por otra cadena especificada, retorna una nueva cadena de texto, no modifica la anterior.
    * Split(): se utiliza para dividir una cadena de texto en subcadenas más pequeñas en función de un separador especificado. Retorna un arreglo de cadenas con las subcadenas resultantes.
    * Trim():se utiliza para eliminar los espacios en blanco al inicio y al final de una cadena de texto. Retorna una nueva cadena sin los espacios en blanco.

Búsqueda y manipulación de una cadena: 
    * IndexOf(): se utiliza para encontrar la posición de la primera ocurrencia de un carácter o una subcadena dentro de una cadena de texto. Retorna el índice de la primera aparición del carácter o subcadena, o -1 si no se encuentra
    * LastIndexOf(): lo mismo que el anterior solo que en lugar de buscar la primera ocurrencia busca la ultima
    * StartsWith():se utiliza para verificar si una cadena de texto comienza con un prefijo especificado. Retorna true si la cadena comienza con el prefijo, de lo contrario retorna false.
    * EndsWith(): lo mismo que el anterior solo que corrovora el sufijo
*/

Console.Write("\nIngrese una cadena de texto: ");
string cadena = Console.ReadLine();

// Obtener la longitud de la cadena y muestre por pantalla.
Console.WriteLine($"Tienen {cadena.Length} diguitos de longitud");

//A partir de una segunda cadena ingresada por el usuario, concatene ambas cadenas distintas.
Console.Write("\nIngrese una cadena de texto: ");
string cadena2 = Console.ReadLine();

Console.WriteLine($"La cadena total formada es: {cadena} {cadena2}");


//Extraer una subcadena de la cadena ingresada
string cadena3 = cadena+ " "+cadena2;
int finCadena = cadena3.Length;
Console.WriteLine($"\nLa subcadena extraida es: {cadena3.Substring(7)}");// si a substring no le paso otro argumento me tomara desde la posicion ingresada hasta el final de la cadena 

//Recorrer la cadena de texto con un ciclo Foreach e ir mostrando elemento por elemento en pantalla
Console.WriteLine("\nReimpreción de la cadena pero esta vez con uso del foreach");
foreach (char caracter in cadena3){
    Console.Write(caracter);
}


//Buscar la ocurrencia de una palabra determinada en la cadena ingresada
string palabraABuscar = "Nazaret";
if (cadena3.IndexOf(palabraABuscar) == -1)
{
    Console.WriteLine("\nLo buscado no se encuentra en la cadena");
} else {
    Console.WriteLine("\nLa palabra buscada empieza en: "+cadena3.IndexOf(palabraABuscar));
}


//Convierta la cadena a mayúsculas y luego a minúsculas.
Console.WriteLine("\nCadena en mayusculas: "+ cadena3.ToUpper());
Console.WriteLine("\nCadena en minusculas: "+ cadena3.ToLower());


//Ingrese una cadena separada por caracteres que usted determine y muestre por pantalla los resultados (Revisar el comportamiento de split())
string cadena4 = "Campos. Nestor. Nazaret. ";
string[] subcadena4 = cadena4.Split('.');

// Recorrer las subcadenas resultantes
foreach (string cadenaa in subcadena4)
{
    Console.WriteLine(cadenaa);
}


//PUNTO 5: 
/*
Expresiones Regulares
    * ¿Funcionan únicamente en C#?
      No, las expresiones regulares no están limitadas solo a C#. on un estándar ampliamente utilizado en muchos lenguajes y entornos, incluyendo C#, Python, Java, JavaScript, PHP, Ruby y muchos otros. Cada lenguaje puede tener su propia implementación y sintaxis para trabajar con expresiones regulares, pero el concepto subyacente y la mayoría de los patrones y metacaracteres son similares en todos los lenguajes.

    * ¿En qué casos le parecen útiles?
       - Filtrado y validación de entradas de usuario
       - Validación de formatos
       - Sustitución y manipulación de texto
    
    * ¿Cómo se hace uso de estas en C#?
       En C#, puedes hacer uso de expresiones regulares utilizando la clase Regex del espacio de nombres System.Text.RegularExpressions. Esta clase proporciona métodos estáticos para trabajar con expresiones regulares.
*/


// Construir un programa que permita identificar de forma sencilla si la cadena ingresada es una dirección web y otro que una cadena ingresada sea un mail válido

// Definir una expresión regular
string emailPattern = @"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$";
string urlPattern = @"^(https?://)?[\w.-]+\.[a-zA-Z]{2,}(\/\S*)?$";

// Crear un objeto Regex
Regex regex = new Regex(emailPattern);
Regex regex2 = new Regex(urlPattern);

// Realizar una búsqueda en una cadena de texto
string input = "nazaretcampos27@gmail.com";
Match match = regex.Match(input);

if (match.Success)
{
    Console.WriteLine("El correo ingresado es valido");
} else {
    Console.WriteLine("El correo ingresado no es valido");
}