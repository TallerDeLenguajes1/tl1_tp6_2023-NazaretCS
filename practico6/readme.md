# RESPUESTAS DEL EJERCICIO 4
<br>

*¿String es un tipo por valor o un tipo por referencia.?*

En C#, el tipo string es un tipo de dato por referencia. Esto significa que cuando asignas un valor de tipo string a una variable, en realidad estás almacenando una referencia a ese valor en memoria en lugar de los propios datos.
Cuando creas una variable de tipo string y le asignas un valor, se reserva un espacio en memoria para almacenar la cadena de caracteres y la variable contiene una referencia a ese espacio de memoria. Si luego asignas esa variable a otra variable, ambas variables apuntarán al mismo espacio de memoria donde se almacena la cadena.
<br>  
<br>  

*¿Que secuencias de escape tiene el tipo string.?*

\\\": Comillas dobles (").<br> 
\\': Comilla simple (').<br> 
\\\\: Barra invertida (\\).<br> 
\\n: Nueva línea.<br> 
\\r: Retorno de carro.<br> 
\\t: Tabulación horizontal.<br> 
\\b: Retroceso.<br> 
\\f: Avance de página.<br> 
<br>
<br>

*¿Que sucede cuando se utiliza el caracter "@" y "$" antes de una cadena de texto.?*

Cuando se utiliza el carácter "@" antes de una cadena de texto en C#, se trata como una cadena de texto literal, esto significa que la cadena se interpreta tal como está escrita, sin evaluar las secuencias de escape.
Al utilizar el carácter "@", se omite la necesidad de duplicar las barras invertidas para representar secuencias de escape, como \n o \". Esto puede hacer que las cadenas de texto con muchas secuencias de escape sean más legibles y fáciles de mantener.
un ejemplo de aplicacion: 
    string path = "C:\\Users\\Usuario\\Documents\\archivo.txt";
    string path = @"C:\Users\Usuario\Documents\archivo.txt";

El carácter "$", por otro lado, se utiliza para formatear cadenas de texto de forma más conveniente mediante la interpolación de cadenas. Al preceder una cadena con el carácter "$", se indica que se desea realizar interpolación de cadenas, lo que permite incluir expresiones y variables dentro de la cadena sin necesidad de concatenación manual.
