using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcM
{
    class Program:calculo
    {
        static void Main(string[] args)
        {
            int b=0;            
            bool sair = false;
            string msg = "TABELA DE OPERAÇÕES\n\n + = soma,\n - = subtração,\n * = multiplicacao, \n / = divisão, \n ^ = potencia, \n . = raiz";
            string operacao;

            while (!sair) {
                Console.WriteLine();
                Console.WriteLine(msg);                

                Console.Write("\n digite o primeiro numero:");
                int a = int.Parse(Console.ReadLine());
                
                Console.Write("digite o numero da operação desejada:");
                operacao = Console.ReadLine();

                var c = new calculo();

                //enquanto a operação for falsa 
                while (c.valida_operacao(operacao)==false)
                {
                    Console.Write("Favor selecionar alguma operação válida:");
                    operacao = Console.ReadLine();
                }

                if (operacao!="."){
                    Console.Write("digite o segundo numero:");
                    b = int.Parse(Console.ReadLine());
                }    
                           
              
                
                    switch (operacao){
                        case "+":
                            Console.Write("O resultado é: " + c.soma(a, b));
                            break;
                        case "-":
                            Console.Write("O resultado é: " + c.subtracao(a, b));
                            break;
                        case "*":
                            Console.Write("O resultado é: " + c.multiplicacao(a, b));
                            break;
                        case "/":
                            Console.Write("O resultado é: " + c.divisao(a, b));
                            break;
                        case "^":
                            Console.Write("O resultado é: " + c.potencia(a, b));
                            break;
                        case ".":
                            Console.Write("O resultado é: " + c.raiz(a));
                            break;
                }
               
                
                Console.Write("\nDeseja sair? \nDigite y para sim e n para não:");
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "y":
                        sair = true;
                        break;

                    default:
                        sair = false;
                        break;
                }
                Console.WriteLine("\n\n");

                Console.Clear();
            }
            
        }


    }
}

