using System;

namespace ConsoleApp1.Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string opcao;
            do
            {
                string operador;
                Console.WriteLine("Digite [1] para SOMA ");
                Console.WriteLine("Digite [2] para MÈDIA ARITMÈTICA DE TRÊS NÙMEROS  ");
                Console.WriteLine("Digite [3] para ÁREA DE UM RETANGULO ");
                Console.WriteLine("Digite [4] para ÁREA DE UM TRIANGULO ");
                Console.WriteLine("Digite [5] para ÁREA DE UM CIRCULO");
                Console.WriteLine("Digite [6] para IDADE EM DIAS ");
                Console.WriteLine("Digite [7] para SUBTRAÇÃO ");
                Console.WriteLine("Digite [8] para DIVISÃO ");
                Console.WriteLine("Digite [9] para MULTIPLICAÇÃO ");
                Console.WriteLine("Digite [S] para SAIR ");
                opcao = Console.ReadLine();
                //  Console.WriteLine("Digite o primeiro número: ");
                //  string strx = Console.ReadLine();
                //  Console.WriteLine("Digite o segundo número: ");
                //  string stry = Console.ReadLine();                           
                //  int x = Convert.ToInt32(strx);             
                // int y = Convert.ToInt32(stry);
                //  int z = Convert.ToInt32(Console.ReadLine());
                double resultado;

                if (opcao == "1")
                {
                    Console.Write("Digite o primeiro número: ");
                    string strx = Console.ReadLine();
                    Console.Write("Digite o segundo número: ");
                    string stry = Console.ReadLine();
                    int x = Convert.ToInt32(strx);
                    int y = Convert.ToInt32(stry);
                    resultado = x + y;
                    Console.WriteLine(resultado);
                }
                else if (opcao == "2")
                {
                    Console.Write("Digite o primeiro número: ");
                    string strx = Console.ReadLine();
                    Console.Write("Digite o segundo número: ");
                    string stry = Console.ReadLine();
                    Console.Write("Digite o terceiro número: ");
                    string strz = Console.ReadLine();
                    int x = Convert.ToInt32(strx);
                    int y = Convert.ToInt32(stry);
                    int z = Convert.ToInt32(strz);
                    resultado = x + y + z / 3;
                    Console.WriteLine(resultado);
                }
                else if (opcao == "3")
                {
                    Console.Write("Digite o valor da BASE do retangulo: ");
                    string strx = Console.ReadLine();
                    Console.Write("Digite o valor da ALTURA do retangulo: ");
                    string stry = Console.ReadLine();
                    int x = Convert.ToInt32(strx);
                    int y = Convert.ToInt32(stry);
                    resultado = x * y;
                    Console.WriteLine(resultado);
                }
                else if (opcao == "4")
                {

                    Console.Write("Digite o valor da BASE: ");
                    string strx = Console.ReadLine();
                    Console.Write("Digite o Valor da ALTURA: ");
                    string stry = Console.ReadLine();
                    int x = Convert.ToInt32(strx);
                    int y = Convert.ToInt32(stry);
                    resultado = x * y / 2;
                    Console.WriteLine(resultado);
                }
                else if (opcao == "5")
                {

                    Console.Write("Digite o valor do RAIO do circulo: ");
                    string strx = Console.ReadLine();
                    double x = Convert.ToDouble(strx);
                    double π;
                    π = 3.14;
                    resultado = (x * x) * π; // area= π x R² 
                    Console.WriteLine(resultado);
                }
                else if (opcao == "6")
                {

                    Console.WriteLine("Qual o seu Nome?");
                    string nome = Console.ReadLine();
                    Console.Write("Digite a sua Idade: ");
                    string strx = Console.ReadLine();
                    int x = Convert.ToInt32(strx);

                    resultado = x * 365;
                    Console.WriteLine(nome + ", você já viveu " + resultado + " dias");
                }

                else if (opcao == "7")
                {
                    Console.Write("Digite o primeiro número: ");
                    string strx = Console.ReadLine();
                    Console.Write("Digite o segundo número: ");
                    string stry = Console.ReadLine();
                    int x = Convert.ToInt32(strx);
                    int y = Convert.ToInt32(stry);
                    resultado = x - y;
                    Console.WriteLine(resultado);
                }
                else if (opcao == "8")
                {
                    Console.Write("Digite o primeiro número: ");
                    string strx = Console.ReadLine();
                    Console.Write("Digite o segundo número: ");
                    string stry = Console.ReadLine();
                    int x = Convert.ToInt32(strx);
                    int y = Convert.ToInt32(stry);
                    resultado = x / y;
                    Console.WriteLine(resultado);
                }
                else if (opcao == "9")
                {
                    Console.Write("Digite o primeiro número: ");
                    string strx = Console.ReadLine();
                    Console.Write("Digite o segundo número: ");
                    string stry = Console.ReadLine();
                    int x = Convert.ToInt32(strx);
                    int y = Convert.ToInt32(stry);
                    resultado = x * y;
                    Console.WriteLine(resultado);
                }
                else if (opcao == "S") 
                {
                    break;                
                }
                /*else if (opcao == "0")
                {
                    Console.WriteLine();
                    Console.WriteLine(historioco);
                    Console.ReadLine();
                    Console.Clear();
                    continue;
                }
                
                // Historico de Resultado apenas
                // != 0 divisão e validação de menu 
                */
                Console.WriteLine("=======================");
                Console.WriteLine("Aperte [ENTER] para continuar");
                Console.ReadLine();
                // Barra invertida (\) alt + 92 
                // Barra Vertical (|)               
            } while (opcao == "1" || opcao == "2" || opcao == "3" || opcao == "4" || opcao == "5" || opcao == "6" || opcao == "7" || opcao == "8" || opcao == "9" || opcao == "S" || opcao == "0");

        }
        
    }
}
