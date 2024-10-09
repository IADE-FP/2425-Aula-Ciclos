using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;

class Problems { // Não sabemos para que serve e/ou como funciona (ainda)
    public static void Problem1() { // idem
        bool exit = false;
        while (!exit) {
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1. Quadrado");
            Console.WriteLine("2. Triângulo");
            Console.WriteLine("3. Círculo");
            Console.WriteLine("4. Sair");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option) {
                case 1:
                    Console.WriteLine("Área = lado x lado");
                    break;
                case 2:
                    Console.WriteLine("Área = base x altura / 2");
                    break;
                case 3:
                    Console.WriteLine("Área = 2 x pi x raio");
                    break;
                case 4:
                    Console.WriteLine("Até breve!");
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }
    }

    public static void Problem2() {
        // Escreva um programa que leia um número inteiro e imprima todos os números pares entre 0 e esse número.
        int number = Convert.ToInt32(Console.ReadLine());
        for (int i = 2; i <= number; i += 2) {
            // Console.Write($"{i} ");
            Console.WriteLine(i);
        }
        Console.WriteLine();
    }

    public static void Problem3() {
        // Escreva um programa que pede ao utilizador para introduzir um número primo. O programa deve repetir o pedido até o utilizador introduzir um número válido.
        while (true) {
            Console.Write("Introduza um número: ");
            int n = Convert.ToInt32(Console.ReadLine());
            bool isPrime = true;
            for (int i = 2; i < n; i++) {
                if (n % i == 0) {
                    // Não é primo!
                    isPrime = false;
                }
            }
            if (isPrime) {
                // É primo!
                Console.WriteLine($"O número {n} é primo.");
                break;
            }
        }
    }

    public static void Problem4() {
        // Escreva um programa que permite introduzir um número real por linha até encontrar uma linha vazia. O programa mostra a média do valores introduzidos.
        double values = 0.0;
        int counter = 0;
        while (true) {
            string line = Console.ReadLine();
            if (line.Length == 0) {
                // Mostrar a média!
                Console.WriteLine($"Média: {values / counter}");
                break;
            }
            else {
                // Somar valores.
                values += Convert.ToDouble(line);
                // Aumentar a contagem.
                counter++;
            }
        }
    }

    public static void Problem5() {
        Console.Write("Introduza um número inteiro positivo: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int result = 1;
        for (int i = n; i > 0; i--) {
            result *= i;
        }
        Console.WriteLine($"Fatorial de {n} é {result}.");
    }

    public static void Problem6a() {
        Console.Write("Introduza um valor para infinito: ");
        int limit = Convert.ToInt32(Console.ReadLine());
        double result = 0.0;
        for (double n = 1; n < limit; n++) {
            // Console.WriteLine(result);
            result += 1 / (n * (n + 1));
        }
        Console.WriteLine(result);
    }
}