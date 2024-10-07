using System.Diagnostics.Contracts;

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
        for(int i = 2; i <= number; i+=2) {
            // Console.Write($"{i} ");
            Console.WriteLine(i);
        }
        Console.WriteLine();
    }
}