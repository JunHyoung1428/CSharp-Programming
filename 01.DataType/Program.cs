using System.ComponentModel.DataAnnotations;
using System.Xml;

namespace _01.DataType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //변수 선언
            String gameName = "Baldurs Gate3";
            // $ 문자열 보간 기능 사용!
            // + 연산자 사용시 가비지컬렉터로 인한 최적화 이슈 , 문자열의 불변성 때문에 사용할 때 마다 메모리에 다른 문자열을 생성해냄
            string str = $"Game of the year is {gameName}!!";
            Console.WriteLine(str);

            //상수 선언, 불변 값
            const int MAX = 10;
            const string gameTitle = "Splatoon3";
            int playerCount = MAX;
            //MAX = 100;  //Error: 상수는 값 변경 불가
            // const MIN; //Error: 초기화 없이 선언 불가

            //배열 선언
            int[] exam = new int[26];
            exam[0] = 0;
            exam[1] = 1;
            float[] fArray = { 1.1f, 2.2f, 3.3f, 4.4f };
            fArray[3] = 1f;

            //다차원 배열 선언, 차원 수 만큼 ','로 구분
            int[,] studentMatrix = new int[10, 10];
            float[,,] schoolMatrix = new float[3, 10, 10];

            int[,] intMatrix = new int[5, 5];
            int cnt = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    intMatrix[i, j] = cnt;
                    Console.Write($"{intMatrix[i, j]}\t");
                    cnt++;
                }
                Console.WriteLine();
            }

            //명시적 형변환 , 묵시적 형변환
            int defaultDMG = 23;
            float buff = 1.30f;
            int finalDMG = (int)(defaultDMG * buff); // 명시적 형변환, 데이터의 손실 발생 시 필수
            float realDMG = defaultDMG * buff; // 손실이 없을 때는 자동으로 묵시적 형변환
            Console.WriteLine($"최종 수치:{finalDMG}");
            Console.WriteLine($"실제 수치:{realDMG}");

            //문자열 형변환
            // 각 자료형의 .Parse , .TryParse 를 이용하여 문자열에서 자료형으로 변환 .// TryParse 는 bool 대수 반환, 
            // 각 자료형에서 ToString으로 자료형에서 문자열로 변환.
            int hp = int.Parse("100");

        }
    }
}

