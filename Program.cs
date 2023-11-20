// lambda = funcion anonima
// estructura (parametro) => cuerpo de la funcion
// no necita la palabra reservada return
// El primer valor dentro de func es el tipo de dato a utilizar y el segundo es el cvalor a retornar
// Funciones con mas de 1 parametro van dentro de parentesis.
// Cuandop se crea un funcion lambda que ejecuta mas de una sentencia deben de ir en llaves
//Cuando la funcion retorne un valor usamos FUNC y si no retorna Action.
//Actios solo define los tipos para los parametros


Func<int,bool> par =  numero => numero % 2 == 0;
Console.WriteLine("El numero es par : "  + par(5));

Func<int,int, int> sum = (num1 , num2) => num1 + num2;
Console.WriteLine("El resultado de la suma es = " + sum(10,20));


Func<string, bool> validador = correo =>
{
    if (!correo.EndsWith("@gmail.com", StringComparison.CurrentCulture))
    {
        Console.WriteLine("El correo es invalido");
    }
    return false;
};

Console.WriteLine("El correo es valido = " + validador("smartm@hotmail.com"));

Action <string> saludar =  mensaje => Console.WriteLine(mensaje);
saludar("Saludar desde una funion anonima!");

Action<int, int> suma = (num1, num2) =>
{
    Console.WriteLine(num1 + num2);
   // Console.WriteLine(num2);
};
suma( 2, 2);