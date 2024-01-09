using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012.Delegate
{
    internal class GenericDelegate
    {
        /**************************************************************************
        * 일반화 델리게이트
        * 
        * 개발과정에서 많이 사용되는 델리게이트의 경우 일반화된 델리게이트를 사용
        **************************************************************************/

        // <Func 델리게이트>
        // 반환형과 매개변수를 지정한 델리게이트
        // Func<매개변수1, 매개변수2, ..., 반환형>
        int Plus(int left, int right) { return left + right; }
        int Minus(int left, int right) { return left - right; }

       // Type GenericPlus<Type>(Type left, Type right) { return right + left; }

        void Main1()
        {
            Func<int, int, int>[] func = new Func<int, int, int>[3]; //이미 만들어진 Func 델리게이트 쓰면됨
            Func<Type, Type, Type> func1;
            func[0] = Plus;  // 객체인지라 배열로도 쓸 수 있음
            func[1] = Minus;
            //func1 = GenericPlus;
        }


        // ***********<Action 델리게이트>******** 주구장창 씀
        // 반환형이 void 이며 매개변수를 지정한 델리게이트
        // Action<매개변수1, 매개변수2, ...>
        void Message(string message) { Console.WriteLine(message); }

        void Main2()
        {
            Action<string> action;
            action = Message;
        }


        // <Predicate 델리게이트>
        // 반환형이 bool, 매개변수가 하나인 델리게이트
        bool IsSentence(string str) { return str.Contains(' '); }

        void Main3()
        {
            Predicate<string> predicate;
            predicate = IsSentence;

            // 이렇게 써두 됨...
            Func<string, bool> func;
            func = IsSentence;
        }
    }
}
