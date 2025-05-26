using System;
using System.Reflection.Metadata.Ecma335;

namespace PraticandoConceitos;

public class Program
{
    static void Main()
    {
        bool exit = false;

        while (!exit)
        {
            Console.Clear();

            Console.WriteLine("Escolha umas das  opções abaixo: ");
            Console.WriteLine("1 - Saudações");
            Console.WriteLine("2 - Concatenar primeiro e último nome");
            Console.WriteLine("3 - Operações matemáticas");
            Console.WriteLine("4 - Contar caracteres");
            Console.WriteLine("5 - Validar placa de veículo");
            Console.WriteLine("6 - Formatar data atual");
            Console.Write("Opção: ");

            string? option = Console.ReadLine();

            Console.Clear();

            switch (option)
            {
                case "1":
                    {
                        Ex1Greetings();
                        break;
                    }
                case "2":
                    {
                        Ex2ConcatFirstLastName();
                        break;
                    }
                case "3":
                    {
                        Ex3MathOperations();
                        break;
                    }
                case "4":
                    {
                        Ex4CountChars();
                        break;
                    }
                case "5":
                    {
                        Ex5VeichlePlate();
                        break;
                    }
                case "6":
                    {
                        Ex6FormatCurrentDate();
                        break;
                    }
                default:
                    {
                        exit = true;
                        break;
                    }
            }

            if (exit)
            {
                break;
            }

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();

        }
    }

    private static void Ex1Greetings()
    {
        Console.Write("Digite seu nome: ");
        string? name = Console.ReadLine();
        Console.WriteLine("Olá, " + name + "! Seja muito bem-vindo!");
    }

    private static void Ex2ConcatFirstLastName()
    {
        Console.Write("Digite seu nome: ");
        string? name = Console.ReadLine();
        Console.Write("Digite seu sobrenome: ");
        string? lastname = Console.ReadLine();
        Console.WriteLine("Olá, " + name + " " + lastname + "! Seja muito bem-vindo!");
    }

    private static void Ex3MathOperations()
    {
        double val1, val2;

        Console.Write("Digite o primeiro valor: ");
        string? xVal1 = Console.ReadLine();
        Console.Write("Digite o segundo valor: ");
        string? xVal2 = Console.ReadLine();

        double.TryParse(xVal1, out val1);
        double.TryParse(xVal2, out val2);

        Console.WriteLine("Soma: " + val1.ToString() + " + " + val2.ToString() + " = " + (val1 + val2).ToString());
        Console.WriteLine("Subtração: " + val1.ToString() + " - " + val2.ToString() + " = " + (val1 - val2).ToString());
        Console.WriteLine("Multiplicação: " + val1.ToString() + " * " + val2.ToString() + " = " + (val1 * val2).ToString());
        Console.WriteLine("Divisão: " + (val2 == 0 ? "Impossivel dividir por 0" : val1.ToString() + " / " + val2.ToString() + " = " + (val1 / val2).ToString()));
        
    }

    private static void Ex4CountChars()
    {
        string output = "";
        int numChar = 0;
        char prevChar = '\0';

        Console.Write("Digite um texto: ");
        string? text = Console.ReadLine();

        if (text != null)
        {
            foreach (var item in text)
            {
                if (item != ' ')
                {
                    output += item;
                    numChar++;
                }
                else
                {
                    if (prevChar != ' ')
                    {
                        output += ": " + numChar + "\n";
                        numChar = 0;
                    }
                }

                prevChar = item;
            }

            if (numChar > 0)
            {
                output += ": " + numChar + "\n";
            }

            Console.WriteLine(output);
        }
    }

    private static void Ex5VeichlePlate()
    {
        Console.Write("Digite a placa do veiculo: ");
        string? plate = Console.ReadLine();

        if (plate != null && plate.Length == 7)
        {
            char c1 = plate[0];
            char c2 = plate[1];
            char c3 = plate[2];
            char c4 = plate[3];
            char c5 = plate[4];
            char c6 = plate[5];
            char c7 = plate[6];

            if (
                !char.IsDigit(c1) && !char.IsDigit(c2) && !char.IsDigit(c3) &&
                char.IsDigit(c4) && char.IsDigit(c5) && char.IsDigit(c6) && char.IsDigit(c7)
            )
            {
                Console.WriteLine("Verdadeiro");
            }
            else
            {
                Console.WriteLine("Falso");
            }
        }
        else
        {
            Console.WriteLine("Falso");
        }


    }

    private static void Ex6FormatCurrentDate()
    {
        Console.WriteLine("Selecione uma das opções de data: ");
        Console.WriteLine("1 - Formato completo (dia da semana, dia do mês, mês, ano, hora, minutos, segundos).");
        Console.WriteLine("2 - Apenas a data no formato \"01/03/2024\".");
        Console.WriteLine("3 - Apenas a hora no formato de 24 horas.");
        Console.WriteLine("4 - A data com o mês por extenso.");

        Console.Write("Opcao: ");

        string? option = Console.ReadLine();

        DateTime now = DateTime.Now;

        switch (option)
        {
            case "1":
                {
                    Console.WriteLine(now.ToString("dddd, dd/MM/yyyy HH:mm:ss"));
                    break;
                }
            case "2":
                {
                    Console.WriteLine(now.ToString("dd/MM/yyyy"));
                    break;
                }
            case "3":
                {
                    Console.WriteLine(now.ToString("HH"));
                    break;
                }
            case "4":
                {
                    Console.WriteLine(now.ToString("d MMM yyyy"));
                    break;
                }
            default:
                {
                    Console.WriteLine("Opção inválida");
                    break;
                }
        }
    }
    
}
