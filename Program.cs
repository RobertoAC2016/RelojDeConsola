
//  Vamos a realizar un reloj muy especial en consola el cual mostrara los numeros actuales de tu sistema

bool empezar = true;
//Con el random seleccionaremos el color de una lista
List<ConsoleColor> colores = new List<ConsoleColor>
{
    ConsoleColor.Red,
    ConsoleColor.DarkGreen,
    ConsoleColor.DarkBlue,
    ConsoleColor.Blue,
    ConsoleColor.Gray,
    ConsoleColor.DarkRed,
    ConsoleColor.DarkGray,
    ConsoleColor.Green,
};
Random rnd = new Random();

string marcador = "|";
while (empezar)
{
    var tiempo = DateTime.Now;

    var micolor = colores[rnd.Next(colores.Count)];
    //Ahora solo extraemos el tiempo de la variable tiempo, Indicaremos q al presionar una tecla se detendra
    Console.Write("Presiona una tecla para salir: ");
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine();
    Console.ForegroundColor = micolor;

    Console.WriteLine($"                             {tiempo.Hour} : {tiempo.Minute} : {tiempo.Second}       {marcador}");

    Console.ForegroundColor = ConsoleColor.White;

    //Timer     500 es igual a medio segundo, 1000 es igual a un segundo
    Thread.Sleep(1000);

    if (Console.KeyAvailable) break;

    Console.Clear();
    //usaremos la variable marcador para mostrar un simbolo q indique q esta cambiando aparte del color
    if (marcador.Equals("\\")) marcador = "|";
    if (marcador.Equals("-")) marcador = "\\";
    if (marcador.Equals("/")) marcador = "-";
    if (marcador.Equals("|")) marcador = "/";
    //Veremos como se comporta modificando el timer
}





































