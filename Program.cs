using System.ComponentModel.Design;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Timers;

namespace myfirstproject
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //primeiraFuncao();

            //segundaFuncao();

            //terceiraFuncao();

            //calculadora("BANANA",100, 200) ;
            //calculadora("soma",100, 200) ;
            //calculadora("subtracao",100, 200) ;
            
            // GitHub - matheusattorre
            // GitHub - fabiojsjr

            while (true)
            {

                //if (tipoCalculo.Equals("soma")) Console.Beep() ;

                //if (tipoCalculo.Equals("subtração")) Console.Beep();

                //if (tipoCalculo.Equals("divisão")) Console.Beep();

                //if (tipoCalculo.Equals("multiplicação")) Console.Beep();

                //if (tipoCalculo.Equals("pot")) Console.Beep();
                String tipoCalculo; 

                while (true)
                {
                    Console.WriteLine("Digite o tipo de calculo: (soma (+) / subtração (-) / divisão (/) / multiplicação (*) / potência (^) ou sair ");

                    tipoCalculo = Console.ReadLine();

                    if (tipoCalculo.Equals("sair")) Environment.Exit(0); ;


                    if ((tipoCalculo.Equals("soma")) ||
                       (tipoCalculo.Equals("subtração")) ||
                       (tipoCalculo.Equals("divisão")) ||
                       (tipoCalculo.Equals("multiplição")) ||
                       (tipoCalculo.Equals("pot")))
                    {
                        Console.Beep();
                        break;

                    }
                    else
                    {
                        Console.WriteLine("Invalid Option");
                    }

                }

                Console.Beep();

                long valor1;

                while (true)
                {
                    Console.WriteLine("Digite o primeiro Valor:");
                    bool ValorInvalido = long.TryParse(Console.ReadLine(), out valor1);

                    if (ValorInvalido)
                    {
                        break;
                    } else
                    {
                        Console.WriteLine("Valor inválido!");
                        continue;
                    }
                }

                //long valor1 = long.Parse(Console.ReadLine());

                Console.WriteLine("Digite o segundo Valor:");
               long valor2 = long.Parse(Console.ReadLine());

                Console.Beep();
                calculadora(tipoCalculo, valor1, valor2);

                                
            }

        }

        private static void calculadora(String tipo, long x, long y ) 
        {
            //Console.WriteLine("Valor 1: " + x);
            //Console.WriteLine("Valor 2: " + y);
            //Console.WriteLine("Tipo   : " + tipo);

            if (tipo.Equals("soma"))
            {
                Console.WriteLine($"A {tipo} entre os valores {x} e {y} é igual a {x + y}");

            } else if (tipo.Equals("subtração")) 
            {
                Console.WriteLine($"A {tipo} entre os valores {x} e {y} é igual a {x - y}");

            } else if (tipo.Equals("divisão"))
            {
                Console.WriteLine($"A {tipo} entre os valores {x} e {y} é igual a {x / y}");

            } else if (tipo.Equals("multiplicação"))
            {
                Console.WriteLine($"A {tipo} entre os valores {x} e {y} é igual a {x * y}");
            } else if (tipo.Equals("pot"))
            {
                Console.WriteLine($"A {tipo} entre os valores {x} e {y} é igual a {Math.Pow(x, y)}");
            } else 
            {

                

                Console.WriteLine("Eu não sei fazer essa conta");
            }
            


        }

        public static void primeiraFuncao()
        {
            Console.WriteLine("Banana e Abacaxi");

            Console.WriteLine(7 * 4);

            string fruit1 = "Banana";
            string fruit2 = "Abacaxi";

            Console.WriteLine(fruit1 + " é melhor que " + fruit2);

        }

        private static void segundaFuncao()
        {
            long numero1 = 1111111;
            long numero2 = 1000000;


            Console.WriteLine(numero1 * numero2);


            Console.WriteLine($"a soma entre {numero1} e {numero2} é :{numero1 + numero2} ");

            Console.WriteLine($"a subtração entre {numero1} e {numero2} é :{numero1 - numero2}");

            Console.WriteLine($"a divisão entre {numero1} e {numero2} é :{numero1 / numero2}");

            Console.WriteLine($"a multiplicação entre {numero1} e {numero2} é :{numero1 * numero2}");

            if (numero1 > numero2)
            {
                Console.WriteLine("1 > 2");
            }
            else
            {
                Console.WriteLine("opaaaaaaaaaaaaaaaa #1 < #2");
            }
        }

        public static void terceiraFuncao()
        {

            //while (numero1 > numero2 && fruit1.Equals("Banana"))
            //{
            //    numero1++;
            //    //numero2 = numero2 + 99;
            //    numero2++;
            //    Console.WriteLine($"bla bla bla #1 {numero1} e #2 {numero2}");
            //}



            Console.WriteLine("Boa noite Matheus, aula 1 finalizada com sucesso!");

            // Proxima - Pegar o valor das variaveis via console

            Console.WriteLine("Digite seu nome:");

            string nome = Console.ReadLine();

            Console.WriteLine("Digite seu sobrenome:");

            string sobrenome = Console.ReadLine();

            Console.WriteLine($"Seja muito bem vindo {nome} {sobrenome} ao meu primeiro projeto");

            Console.WriteLine("Digite sua idade:");

            int idade = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Digite idade da sua irmã:");
            Console.ForegroundColor = ConsoleColor.White;

            int idadeirma = int.Parse(Console.ReadLine());

            Console.WriteLine($"Eu {nome} tenho {idade} anos e minha irmã tem {idadeirma}.");

            if (idadeirma > idade)
            {
                Console.WriteLine("Ela é mais velha que eu");
            }
            else
            {

                Console.WriteLine("Eu sou mais velho que ela.");
            }



            Console.WriteLine("Boa noite Matheus, aula 2 finalizada com sucesso!");

            



        }


        
       



    }
}
