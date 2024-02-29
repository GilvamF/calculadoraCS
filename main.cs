using System;

class Calculadora
{
    static void Main(string[] args)
    {
        double num1, num2, resultado;
        char operador;

        Console.WriteLine("Opa mano,tome um cafe e faça calculos!");

        Console.Write("Digite o primeiro número Lucas: ");
        num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o operador Everaldo (+, -, *, /): ");
        operador = Convert.ToChar(Console.ReadLine());

        Console.Write("Digite o segundo número Allysson: ");
        num2 = Convert.ToDouble(Console.ReadLine());

        switch (operador)
        {
            case '+':
                resultado = num1 + num2;
                Console.WriteLine($"O resultado da adição é: {resultado} entendeu?");
                break;
            case '-':
                resultado = num1 - num2;
                Console.WriteLine($"O resultado da subtração é: {resultado} entendeu?");
                break;
            case '*':
                resultado = num1 * num2;
                Console.WriteLine($"O resultado da multiplicação é: {resultado} entendeu?");
                break;
            case '/':
                if (num2 != 0)
                {
                    resultado = num1 / num2;
                    Console.WriteLine($"O resultado da divisão é: {resultado} entendeu?");
                }
                else
                {
                    Console.WriteLine("Nao é possível dividir por zero burro!");
                }
                break;
            default:
                Console.WriteLine("Operador invalido,rapaz!");
                break;
        }

        Console.WriteLine("Va embora!...");
        Console.ReadKey();
    }
}
