/**************************
          반복문
     블록을 반복적으로
      실행하는 문장
***************************/

namespace _04.Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // while 문

            int money = 300;
            while (money > 0)
            {
                Console.WriteLine("100원을 꺼냅니다.");
                money -= 100;
                Console.WriteLine($"남은 잔액은 {money}원 입니다.");
            }

            // do while 문
            // 한번은 무조건 실행
            int input;
            do
            {
                Console.Write("1에서 9사이의 수를 입력하세요 : ");
                string txt = Console.ReadLine();
                input = int.Parse(txt);
            } while (input < 1 || 9 < input);


            // for 반복문
            Console.WriteLine();

            for (int i = 1; i <= input; i++)
            {
                Console.WriteLine($"{i}번 반복");
            }

            for (int i = 0; i <= 5; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            // foreach 반복문, 반복가능한 데이터 집합의 처음부터 끝까지 반복
            int[] intArray = { 1, 2, 4, 9, 6, 0, 3, 7, 8, 11, 12, 13 };
            foreach (int element in intArray)
            {
                Console.WriteLine($"현재 요소{element}");
            }

            //제어문 , 순차적인 실행 중 다른 문으로 제어를 전송
            //break; continue;

            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                    continue;//맨 처음으로 돌아가며 증감연산 또한 진행
                if (i % 3 == 0)
                    continue;
                Console.WriteLine($"{i}는 2나 3의 배수가 아닙니다.");
            }

        }
    }
}
