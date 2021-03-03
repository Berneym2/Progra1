using System;

namespace hola_mundo
{
    class Program
    {
        static void Main(string[] args)
        {
            double c1;
            double c2;
            string op;
            double Resultado;

            System.Console.WriteLine("Digite la operacion que desea realizar");
            System.Console.WriteLine("1. SUMA");
            System.Console.WriteLine("2. RESTA");
            System.Console.WriteLine("3. MULTIPLICACION");
            System.Console.WriteLine("4. DIVISION");
            System.Console.WriteLine("5. MODULO");

            op = Console.ReadLine();

            System.Console.WriteLine("Digite la primer Cantidad");
            c1=Convert.ToDouble(Console.ReadLine());
            System.Console.WriteLine("Digite la segunda Cantidad");
            c2=Convert.ToDouble(Console.ReadLine());

            Console.Clear();

            if(op == "1") {

                Resultado= c1+c2;
                System.Console.WriteLine("La suma es: " + Resultado);
                Console.ReadLine();
            }

             if(op == "2") {

                Resultado= c1-c2;
                System.Console.WriteLine("La Resta es: " + Resultado);
                Console.ReadLine();
            
            }

             if(op == "3") {

                Resultado= c1*c2;
                System.Console.WriteLine("La multiplicacion es: " + Resultado);
                Console.ReadLine();
            }

             if(op == "4") {

                Resultado= c1/c2;
                System.Console.WriteLine("La Division es: " + Resultado);
                Console.ReadLine();
            }

             if(op == "5") {

                Resultado= c1%c2;
                System.Console.WriteLine("El modulo es: " + Resultado);
                Console.ReadLine();
            }


        }
        
    }
}
