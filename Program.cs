using System;

class Program 
{
    static void Main(string[] Args) 
    {
        Console.WriteLine("Digita algum numero");

        int numero1 = Convert.ToInt32(Console.ReadLine());
        int numero2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Selecione o tipo da operaçao:");

        Console.WriteLine("1 - +");
        Console.WriteLine("2 - -");
        Console.WriteLine("3 - *");
        Console.WriteLine("4 - /");

        int operaçao = Convert.ToInt32(Console.ReadLine());
        int resultado = 0;

        switch(operaçao)
        {
            case 1:
            resultado = numero1 + numero2;
            break;

            case 2:
            resultado = numero1 - numero2;
            break;

            case 3:
            resultado = numero1 * numero2;
            break;

            case 4:
            resultado = numero1 / numero2;
            break;
            default:

            Console.WriteLine("operaçao invalida.");
            break;
        }
        
        Console.WriteLine("O resultado é "  + resultado);
    }
}