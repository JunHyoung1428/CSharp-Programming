using System;
using System.Data;

namespace _06.UserDefineType
{
    internal class Program
    {

        /****************
         * 열거형(Enum) *
         ****************/
        //enum 열거형 이름 {멤버명, 멤버명, 멤버명, ...}
        enum Direction { Up, Down, Left, Right }

        enum Equipment
        {
            Head, //0
            Body,       //1
            Foot,       //2 실제로는 정수값이 할당되어있음. 따라서 int로 형 변환이 가능
            Ring,       //3
            Hand = 40,       //40 정수값을 직접 할당하는것도 가능
            Cape        //41 직접 할당하면 다음 값은 이전값 +1을 가짐
        }
        static void Main(string[] args)
        {
            Direction dir = Direction.Left;
            switch (dir)
            {
                case Direction.Up: //정수 자료보다 가독성이 좋다.
                    Console.WriteLine("UP");
                    break;
                case Direction.Down:
                    Console.WriteLine("Down");
                    break;
                case Direction.Left:
                    Console.WriteLine("Left");
                    break;
                case Direction.Right:
                    Console.WriteLine("Right");
                    break;
            }
            Equipment eq = (Equipment)Direction.Up;
            int value = (int)Equipment.Hand;
            Equipment eq2 = (Equipment)41; // 정수와는 자유롭게 형변환 가능

            MonsterStat stat;

            stat.HP = 10;
            stat.Level = 77;



            StudentInfo park;
            park.name = "준형";
            park.math = 77;
            park.english = 66;
            park.science = 99;

            Console.WriteLine(park.GetAverage());

            Point p = new Point(1, 2);
            Point l = new Point(); // 기본초기화는 사실 기본적으로 지원함 

            Vector3 source = new Vector3(1, 2, 3);
            Vector3 destination = source; // 대입연산하면 내용물들이 전부 똑같이 복사됨


            Console.WriteLine(source.ToString());
            Console.WriteLine(destination.ToString());

        }
        /**************
         *   구조체   *
         **************/
        //데이터와 관련 기능을 캡슐화 할 수 있는 값 형식
        //데이터를 저장하고 보관하기 위한 단위용도로 사용

        struct MonsterStat
        {
            public int HP;
            public int MP;
            public int Level;
            public float Speed;
            public float Range;
        }

        struct StudentInfo
        {
            public string name;
            public int math;
            public int english;
            public int science;

            public int GetSum()
            {
                return math + english + science;
            }
            public float GetAverage()
            {
                return GetSum() / 3.0f;
            }
        }
        //구조체 안에는 함수도 포함 가능
        struct Vector3
        {
            public float x;
            public float y;
            public float z;

            public Vector3(float x, float y, float z)
            {
                this.x = x; this.y = y; this.z = z;
            }
            public float Magnitude()
            {
                return (float)Math.Sqrt(x * x + y * y + z * z);
            }

            public string ToString()
            {
                return $"({x}, {y}, {z})";
            }
        }

        struct Point
        {
            public int x;
            public int y;


            // 반환형이 없는 구조체이름의 함수를 초기화라 하며 구조체 변수들의 초기화를 진행하는 역할로 사용
            // 매개변수가 있는 초기화를 정의하여 구조체 변수의 값을 설정하기 위한 용도로 사용
            // 구조체의 초기화는 new 키워드를 통해서 사용
            public Point(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }

        //튜플 <- 쓰지말고 구조체 만들어 쓰셈, 관리가 어려움, 혼용이되버림
    }
}
