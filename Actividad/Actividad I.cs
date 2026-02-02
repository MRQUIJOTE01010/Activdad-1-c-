
//Aqui declare el tipo de variables que voy a utilizar
string nombre, Apellido;
int edad;
float Altura;

// En esta parte es donde el usuario podra ingresar sus datos

Console.WriteLine("Introduzca sus datos: ");
Console.WriteLine("");

Console.WriteLine("Ingrese su nombre: ");
nombre = Console.ReadLine();

Console.WriteLine("Por favor Introduzca su apellido : ");
Apellido = Console.ReadLine();

Console.WriteLine("Introduzca su edad: ");
edad = int.Parse(Console.ReadLine());

Console.WriteLine("Introduzca su altura: ");
Altura = float.Parse(Console.ReadLine());
///Quise utilizar esto para darle mas formato dejando 
/// una linea para que no este todo pegado
Console.WriteLine("");

// Aqui donde pre imprimira todo de forma ordenada 
Console.WriteLine($"Su nombre completo es, {nombre  +  Apellido}");
Console.WriteLine("Su edad es: " + edad);
Console.WriteLine("Su altura es:" +  Altura);

// Aqui no era necesario pero queria hacer algo diferente
if (edad > 18)
{
    Console.WriteLine($"su edad es {edad} eres mayor de edad..");
}
else
{
    Console.WriteLine($" Su edad es {edad} eres menor de edad");
}

Console.WriteLine($"{nombre  +  Apellido}, sus datos han sido guardados correctamente...");
