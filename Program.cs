using System;

namespace lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Func<int, int, double> rs = Atividade.subtrair;
            Console.WriteLine(rs(10,5));

            Func<int, int, string> ser = Atividade.multiplicar;
            Console.WriteLine(ser(10,5));*/

            /*Action<int, int> res = soma;
            res(20,30);*/

            /*Predicate<int> res  = Par;
            Console.WriteLine(res(20));*/

            /*Data dt = delegate(string msg){
                return msg + " Hoje é " + DateTime.Now;
            };

            Console.WriteLine(dt("Olá, sexta-feira"));

        }

        static void soma(int v1, int v2){
            Console.WriteLine(v1 + v2);
        }

        static bool Par(int valor){
            return valor % 2 == 0;
        }

        delegate string Data(string mensagem);*/

            int[] valores = {40, 56, 1, 23, 9, 11, 22};
            
            // Sem Lambda.
            /*Func<int, bool> rs = delegate(int x){
                return x % 2 == 0;
            };*/
            
            // Com Lambda.
            /*Func<int, bool> rs = x => x % 2 == 0;
            
            foreach(int i in valores){
                if(rs(i)){
                    Console.WriteLine(i);
                }
            }*/

            Func<double, double, double> calculo = (x, y) => x /y;
            Console.WriteLine(calculo(5,3));
        }

        /*static bool Par(int v){
            return v % 2 == 0;
        }*/



    }
}
