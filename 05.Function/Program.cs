using Microsoft.Win32.SafeHandles;
using System.Numerics;

namespace _05.Function
{
    internal class Program
    {
        // 함수 
        //*미리 정해진 동작을 수행하는 코드 묶음
        //*미리 함수로 만들어 두면 다시 반복적으로 사용 가능
        static int Plus(int left, int right)
        {
            Console.WriteLine($"Input:{left},{right}");
            int result = left + right;
            Console.WriteLine($"Output:{result}");
            return result;
        }

        //반환형 함수명(파라메타){함수 내용}


        static void PrintProfile(string name, string phone)
        {
            Console.WriteLine($"이름:{name}");
            Console.WriteLine($"번호:{phone}");
        }
        static void Main(string[] args)
        {
            //Console.ForegroundColor = ConsoleColor.Red;
            Plus(3, 4); // 함수를 사용할 떄는 구성해둔 코드를 이름으로 불러 사용함
                        // Console.ResetColor();
            Plus(12369, 21414);
            Minus(10, 7);

            Multiple(4.5f, 6.7f);

            Console.WriteLine($"총 데미지는:{TripleShot()}");
        }

        static int Minus(int left, int right)
        {
            int result = left - right;
            Console.WriteLine($"결과:{result}");
            return result;
        }


        //함수 호출 순서
        // 호출시 해당 함수 블럭으로 제어가 전송, 완료시 원위치로 재전송
        static int TripleShot()
        {
            int totalDamage = 0;
            for (int i = 0; i < 3; i++)
            {
                totalDamage += Attack();
            }
            return totalDamage;
        }

        static int Attack()
        {
            int damage = 10;
            Console.WriteLine("공격!");
            return damage;
        }

        //<함수 오버로딩>
        //같은 이름의 함수를 매개변수를 달리하여 다른 함수로 재정의하는 기술
        // 같은 이름의 함수를 호출하여도 매개변수의 자료형에 따라 함수를 달리 호출 할 수 있음
        static int Multiple(int left, int right) { return left * right; }
        static float Multiple(float left, float right) { return left * right; }
        static double Multiple(double left, double right) { return left * right; }


        int Multiple(int left, int middle, int right) { return left * middle * right; }

    }
}
