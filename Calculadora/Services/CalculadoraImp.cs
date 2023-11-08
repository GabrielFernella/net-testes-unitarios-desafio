using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.Services
{
    public class CalculadoraImp
    {
        private List<string> listHistory;

        public CalculadoraImp(){
            listHistory = new List<string>();
        }

        public int Somar(int num1, int num2){
            var res = num1+num2;

            listHistory.Insert(0, "Val: "+ res);

            return res;
        }

        public bool EhPar(int num){
            return num % 2 ==0;
        }

        public int Subtrair(int num1, int num2){
            var res = num1-num2;

            listHistory.Insert(0, "Val: "+ res);

            return res;
        }

        public int Multiplicar(int num1, int num2){
            var res = num1*num2;

            listHistory.Insert(0, "Val: "+ res);

            return res;
        }

        public int Dividir(int num1, int num2){
            var res = num1/num2;

            listHistory.Insert(0, "Val: "+ res);

            return res;
        }

        public List<string> history(){

            listHistory.RemoveRange(3, listHistory.Count - 3);

            return listHistory;
        }
        
    }
}