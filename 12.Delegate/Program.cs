namespace _12.Delegate
{

    internal class Program
    {
        /****************************************************************
         * 대리자 (Delegate)
         * 
         * 특정 매개 변수 목록 및 반환 형식이 있는 함수에 대한 참조
         * 대리자 인스턴스를 통해 함수를 호출 할 수 있음
         ****************************************************************/

        // <델리게이트 정의>
        // delegate 반환형 델리게이트이름(매개변수들);

        public delegate float Delegate1(float left, float right);
        public delegate void Delegate2(string s);
        public static float Add(float left, float right) { return left + right; }

        public static float AddTriple(float left, float right, float middle) { return left + middle + right; }
        public static void Message(string message) { Console.WriteLine(message); }
        static void Main1(string[] args)
        {
            int value = 2;

            Delegate1 delegate1 = Add;
            Delegate2 delegate2 = Message;

            Console.WriteLine(delegate1(value, value));

            //delegate1 = AddTriple;  //Error : 대리자와 일치하는 오버로드가 없습니다 
            //delegate2 = Add;
            //델리게이트는 매개변수와 반환형이 기준!


            //함수를 저장해 놓는방식을 이용해 계산기나 턴제배틀 구현에 응용가능
            // 계산기 - 연산자에 해당하는 함수를 델리게이트에 저장한 담에 = 입력시 호출
            // 턴제배틀 - 각 캐릭터의 행동을 델리게이트로 저장한 후에 턴 진행시 호출
        }
    }
}
