using System.Text;



namespace _07.Class
{
    internal class Program
    {

        // <<<<클래스>>>>
        // C# 프로그램의 기본 단위
        // 데이터와 관련 기능을 캡슐화 할 수 있는 "참조" 형식   >>>> 구조체는 직접적인 "값"을 가짐
        //데이터와 함수를 포함 할 수 있음
        class Student
        {
            public string name;
            public int age;
            public int math;
            public int english;
            public int science;

            public float GetAverage()
            {
                return (math + english + science) / 3;
            }
        }

        //<<<<클래스 생성자>>>>>
        //반환형이 없는 클래스 이름의 함수를 생성자라 하며, 인스턴스를 생성할 때 호출되는 역할로 사용
        // new 키워드를 통해서 사용

        class Car
        {
            public string name;
            public string color;
            public Car(string name, string color) //생성자 만들면 기본 생성자는 자동생성 X
            {
                this.name = name;
                this.color = color;
            }
        }

        class MyClass
        {
            public int value1;
            public int value2;
        }
        struct MyStruct
        {
            public int value1;
            public int value2;
        }

        static void Main(string[] args)
        {
            Student park = new Student();

            park.math = 10;
            park.english = 20;
            park.science = 30;

            Car car;
            ///car.name = "차"; // <- 구조체에서는 이거 됐는데 클래스에서는 안됨 , new 키워드를 통한 공간 할당이 안되서

            Car car2 = new Car("포터", "군청");
            Console.WriteLine($"{car2.name}, {car2.color}");


            //<<<클래스의 얕은 복사>>>
            MyClass c = new MyClass();
            c.value1 = 1;
            c.value2 = 2;

            MyClass t = c;      // 변수가 같은 인스턴스를 참조함
            t.value1 = 3;

            MyClass s = new MyClass();
            s.value1 = 4;
            s.value2 = 5;

            t.value1 = 6;


            // 같은 인스턴스를 참조하기 때문에 복사본을 변경하는 경우 원본도 변경됨
            Console.WriteLine(c.value1);    // 3
            Console.WriteLine(c.value2);    // 2

            Console.WriteLine(t.value1);    // 3
            Console.WriteLine(t.value2);    // 2


            RefType rF = new RefType();
            rF.value = 10;
            //깊은 복사, 얕은 복사




            /***************************************
                       * 값 형식, 참조형식*
             * 
             * 값형식 Valuetype :
             * 복사할 때 실제 값이 복사됨(깊은 복사)
             * 데이터가 중요한 경우 사용
             * 구조체
             * boxing
             * 
             * 참조형식 Reference type:
             * 복사할 때 객체주소가 복사됨(얕은 복사)
             * 객체가 중요한 경우
             * 클래스
             * unboxing
             ****************************************/
        }
        struct ValueType
        {
            public int value; // 이게 중요함
        }

        class RefType // 이거 자체가 중요함
        {
            public int value;
        }


        // <값에 의한 호출, 참조에 의한 호출>
        // 값에 의한 호출 (Call by value) : 
        // 값형식의 데이터가 전달되며 "데이터"가 복사되어 전달됨
        // 함수의 매개변수로 전달하는 경우 복사한 값이 전달되며 "원본은 유지됨"
        void Swap(ValueType left, ValueType right)
        {
            int temp = left.value;
            left.value = right.value;
            right.value = temp;
        }

        // 참조에 의한 호출 (Call by reference) :
        // 참조형식의 데이터가 전달되며 "주소"가 복사되어 전달됨
        // 함수의 매개변수로 전달하는 경우 주소가 전달되며 주소를 통해 접근하기 때문에 "원본을 전달하는 효과"
        void Swap(RefType left, RefType right)
        {
            int temp = left.value;
            left.value = right.value;
            right.value = temp;
        }



        // <얕은복사, 깊은복사>
        // 얕은복사 (Shallow copy) : 객체를 복사할 때 주소값만을 복사하여 같은 원본을 가리키게 함
        // 깊은복사 (Depp copy) : 객체를 복사할 때 주소값 안의 원본을 복사하여 다른 객체를 가지고 가리키게 함
        class CopyConstructor
        {
            public RefType shallow;
            public RefType deep;

            public CopyConstructor(CopyConstructor other)
            {
                // 얕은복사
                this.shallow = other.shallow;  // 서로 같은것을 봐야하는 경우 (ex)) monster의 타겟인 player)

                // 깊은복사
                this.deep = new RefType();
                this.deep.value = other.deep.value; // 각자가 각자의 원본 데이터값을 가지고 있어야하는 경우
            }
        }

    }
}
