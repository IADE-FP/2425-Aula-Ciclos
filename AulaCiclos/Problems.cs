using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Schema;

class Problems{
    
    public static void Problem1(){
        int option;

        do{
            Console.WriteLine("\nEscolhe uma das opções: \n 1 - Quadrado\n 2 - Triângulo\n 3 - Circulo\n 4 - Sair");
            option = Convert.ToInt16(Console.ReadLine());

            switch(option){
                case 1:
                    Console.WriteLine("Formula Área Quadrado: Lado x Lado");
                    break;

                case 2:
                    Console.WriteLine("Formula Área Triângulo: Base x Altura");
                    break;
                
                case 3:
                    Console.WriteLine("Formula Área Circulo: PI * Raio^2");
                    break;

                case 4:
                    Console.WriteLine("Sair");
                    break;

                default:
                    Console.WriteLine("Erro");
                    break;
            }
        }
        while(option != 4);
    }
    
    public static void Problem2(){
        int numero;

        do{
            Console.Write("Introduz um numero: ");
            numero = Convert.ToInt16(Console.ReadLine());
        }
        while(numero <= 0);

        for(int i = 0; i <= numero; i++){
            if(i % 2 == 0){
                Console.Write($"{i} ");
            }
        }
    }
   
    public static void Problem3(){
        int number;
        bool number_prime;
        
        do{
            Console.Write("Introduz um numero: ");
            number = Convert.ToInt16(Console.ReadLine());
            number_prime = true;

            for(int i = 2; i < number; i++){
                if(number % i == 0){
                    number_prime = false;
                    break;
                }
            }
        }
        while(!number_prime);

        
    }
    public static void Problem4(){
        double media = 0.0;
        int count = 0;

        while(true){
            Console.Write("Introduz um numero: ");
            string line = Console.ReadLine();

            if(line.Length == 0){
                Console.WriteLine($"\nA média dos valores é: {media / count}");
                break;
            }
            else{
                media += Convert.ToDouble(line);
                count++;
            }
        }        
    }
    public static void Problem5(){
        Console.Write("\nIntroduz um numero: ");
        int num = Convert.ToInt16(Console.ReadLine());
        int total = 1;

        for (int i = num; i > 0; i--){
            total *= i;
        }

        Console.WriteLine($"\nFatorial de {num} é: {total}");
    }

    public static void Problem6a(){
        Console.Write("\nIntroduz um numero: ");
        int limit = Convert.ToInt32(Console.ReadLine());
        double total = 0.0;

        for (double n = 1; n < limit; n++){
            total += 1 / (n * (n + 1));
        }

        Console.WriteLine($"\n Soma é: {total}");
    }

    public static void Problem6b(){
        Console.Write("\nIntroduz um numero: ");
        int limit = Convert.ToInt32(Console.ReadLine());
        double total = 1;

        for (double n = 1; n < limit; n++){
            total += Math.Pow(n, 1/4) * (1/Math.Sqrt(n+1) - 1/Math.Sqrt(n));
        }

        Console.WriteLine($"\n Soma é: {total}");
    }
    
    public static void Problem6c(){
        Console.Write("\nIntroduz um numero: ");
        int num = Convert.ToInt32(Console.ReadLine());
        double total = 1;
        double factorial = 1;

        for (double i = 1; i < num; i++){
            for (double j = i; j > 0; j--){
                factorial *= i;
            }
            total += Math.Pow(i, i) * Math.Cos(i * Math.PI);
        }

        Console.WriteLine($"\n Soma é: {total}");
    }

    public static void Problem6d(){
        Console.Write("\nIntroduz um numero: ");
        int num = Convert.ToInt32(Console.ReadLine());
        int total = 1;

        for(int i = 1; i < num; i++){
           for(int n = 1; n < i; n++){
            total += Convert.ToInt32(n / Math.Pow(n, 2));
           }            
        }

        Console.WriteLine($"\n Soma é: {total}");
    }

    public static void Problem7(){
        int x;
        do{
            Console.Write("\nIntroduz um numero para o seno de X: ");
            x = Convert.ToInt32(Console.ReadLine());
        }
        while(x < -4*Math.PI || x > 4*Math.PI);

        Console.Write("\nIntroduz um numero para o limite: ");
        int num = Convert.ToInt32(Console.ReadLine());        

        double total = 1, factorial = 1;

        for(double n = 1; n < num; n++){
           for(double i = n; i > 0; i--){
                factorial *= (2 * n + 1) * i;
                
           }
            total += Math.Pow(-1, n) *  Math.Pow(x, 2*n+1) / factorial;               
        }

        Console.WriteLine($"\n Soma é: {Math.Sin(total)}");
    }
}