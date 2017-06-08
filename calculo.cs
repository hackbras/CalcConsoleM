using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcM
{
    public class calculo
    {

        public string[] operacao_opcoes = new string[6] { "+", "-", "*", "/" ,"^" , "."};

        public int soma(int parcela1, int parcela2){
            int total;
            total = parcela1 + parcela2;
            return total;
        }

        public int subtracao(int minuendo, int subtraendo){
            int resto;
            resto = minuendo - subtraendo;
            return resto;
        }

        public int multiplicacao(int multiplicando, int multiplicador){
            int produto;
            produto = multiplicando * multiplicador;
            return produto;
        }

        public int divisao(int dividendo, int divisor){
            int quociente;
            quociente = dividendo / divisor;
            return quociente;
        }

        public Double potencia(Double a, double b){
            Double resultado;
            resultado = Math.Pow(a,b);
            return resultado;
        }

        public Double raiz(double num){
            Double resultado;
            resultado = Math.Sqrt(num);
            return resultado;
        }

        public bool valida_operacao(string a){
            if (a == operacao_opcoes[0] || a == operacao_opcoes[1] || a == operacao_opcoes[2] 
            || a == operacao_opcoes[3] || a == operacao_opcoes[4] || a == operacao_opcoes[5] ){
                return true;
            }
            else
                return false;
        }


    }
}
