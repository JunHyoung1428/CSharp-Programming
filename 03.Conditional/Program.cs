
using System;
using System.ComponentModel.Design;
using System.Linq.Expressions;

namespace _03.Conditional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int playerHP = 100;
            int mobATK = 20;

            if (playerHP > mobATK)
            {
                playerHP -= mobATK; Console.WriteLine($"{mobATK} 데미지를 받았습니다.");
            }
            else
            {
                playerHP = 0; Console.WriteLine("YOU DIE");
            }

            bool isGround = true;
            bool jumkpPressed = true;

            if (jumkpPressed && isGround)
            {
                Console.WriteLine("점프한다");
            }
            else
            {
                // 선택 사항으로 생략도 가능
            }

            // else + if 
            string input = "가위";
            if (input == "가위")
            {
                Console.WriteLine("가위입니다.");
            }
            else if (input == "바위")
            {
                Console.WriteLine("바위입니다.");
            }
            else if (input == "보")
            {
                Console.WriteLine("보입니다.");
            }
            else
            {
                Console.WriteLine("아무것도 아닙니다.");
            }

            int rankScore = 87; // 아이언 60 브론즈 70 실버 80 골드 90 플레 100

            if (rankScore <= 60)
            {
                Console.WriteLine("브론즈입니다.");
            }
            else if (rankScore <= 70) // 이미 위에서 걸러졌기 때문에 60<rankScore&& 와 같이 조건을 다시 또 체크해줄필요 X
            {
                Console.WriteLine("가위입니다.");
            }
            else { } // .......

            // swtich 문의 경우 조건식이 아닌 조건값에 따라 처리
            // 경우(값이 여러개)에 따라 if문보다 가독성이 더 좋음
            char c = 'B';
            switch (c)
            {
                case 'A':
                    break;
                case 'B':
                    break;
                case 'C':
                    break;
                default: //그 외의 조건값
                    break;
            }

            // 삼항연산자
            int left = 11;
            int right = 7;

            // 조건식 ? true 일 때 : false 일 때
            int bigger = left > right ? left : right;
            Console.WriteLine(bigger);
        }
    }
}


