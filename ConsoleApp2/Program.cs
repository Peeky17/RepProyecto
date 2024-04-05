/* Calcular el area de un circulo:

double radio = 3;
double CalcularAreaCirculo(double radio)
{
    double area = radio * radio * 3.14;
    return area;
}
//Console.WriteLine("El radio del circulo es de: " + radio +"cm\nSu area es: " + CalcularAreaCirculo(radio) + "cm²");
*/

/* Factorial de un numero:
int num = 10;
void FactorialDeUnNumero(int numero)
{
    int factorial = 1;
    int i = 1;

    while (i <= numero)
    {
        factorial = factorial * i;
        i++;
    }
    Console.WriteLine("El factorial de " + num + " es: " + factorial);
}

FactorialDeUnNumero(num);
*/

/* Sumar los pares de un numero:
int num = 5;
int SumarPares(int num)
{
    int par = 0, i;
    i = 1;

    while (i <= num)
    {
        // Si {i} es divisible entre 2 (par), lo sumamos en la variable {par}
        if ((i % 2) == 0) 
        {
            par = par + i; 
        }
        i++;
    }
    return par;
}
Console.WriteLine("Las sumas de los pares del numero " + num + " es: " + SumarPares(num));
*/

/* Convertir temperatura ºC a ºF y de ºF a ºC
int tempCelsius = 18;
int tempFahrenheit = 40;

int ConvertirEnCelsius(int tempFahrenheit) 
{
    int i = ((tempFahrenheit - 32) * 5 / 9);
    return i;
}

int ConvertirEnFahrenheit(int tempCelsius)
{
    int i = ((tempCelsius * 9 / 5) + 32);
    return i;
}

// Convirtiendo temperatura Fahrenheit a Celsius
Console.WriteLine(tempFahrenheit + "ºF Fahrenheit son " + ConvertirEnCelsius(tempFahrenheit) + "ºC en Celsius\n");

// Convirtiendo temperatura Celsius a Fahrenheit
Console.WriteLine(tempCelsius + "ºC Celsius son " + ConvertirEnFahrenheit(tempCelsius) + "ºF en Fahrenheit");
*/