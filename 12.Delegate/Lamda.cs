using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012.Delegate
{
    internal class Lamda
{

        static void Main()
        {
            Action<string> action; //= str => Console.WriteLine(str);

            //<무명메서드>
            action = delegate (string s) { Console.WriteLine(s); }; 

            //<람다식>
            action = (str) => { Console.WriteLine(str); };  //delegate 생략가능
            action = str => Console.WriteLine(str); // 심지어 괄호랑 자료형도 생략 가능

            action("람다람다람다");

            action = null; //해제

            int[] array = { 4, -2, -7, 1, 9 };

            // 대리자를 사용한 내림차순 정렬
            Array.Sort(array, (a, b) => b.CompareTo(a));
            Array.Sort(array, (a, b) => Math.Abs(a)-Math.Abs(b));


            foreach (int i in array)
            {
                Console.WriteLine(i);
            }
        }


    }
}
