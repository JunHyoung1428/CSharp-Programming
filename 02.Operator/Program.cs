﻿/***************************
 *         연산자
 ***************************/

using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace _02.Operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool b = false;
            int i = 0;
            float f = 0.0f;

            //<이진 연산자>
            i = 2 + 3; // + plus 
            i = 3 - 1; // - minus
            i = 3 * 3; // * power
            f = 5.0f / 2.0f; // / divide, int의 나눗셈은 소수점 버려짐
            i = 235 % 3; // % 나머지

            //<단항 연산자>
            i = +3; // 값을 그대로 둠
            i = -3; // 값을 음수로 변환 - > 2의 보수로 만든다

            ++i; // ++ 전위증가연산자 i=i+1 
            --i; // -- 전위감소연산자 i=i-1 (증감 후 값 반환 )

            i++; // ++ 후위증가연산자
            i--; // -- 후위감소연산자 (값을 반환한 뒤 증감)


            i = 10; // 대입 연산자
            i += 10; // == i=i+10 복합 대입 연산자


            //<논리 연산자>
            b = !false; // NOT, 값을 논리 부정
            b = true && false; // AND
            b = true || false; // OR 
            b = true ^ false; // XOR

            //<조건부 논리 연산자>
            // false && x 인 연산, 혹은 true || x 인 연산 처럼 뒤에 어떠한 논리자료형이 있어도 연산 결과에 영향이 없으면 뒤에 논리자료형은 무시하게됨 



            //<비트 연산자> ->bitmask 
            // << , >> , <<<
            i = ~0x001F; //~  비트 보수 연산자

            //<이진 연산자>
            i = 0x11 & 0x83; //비트 단위로 논리곱
            i = 0x11 | 0x83; //비트 단위로 논리합

            // <비트 쉬프트 연산자> -> * 연산 대신 사용할경우  더 빠름, 최적화시 사용 (100/2 -> 100*0.2 -> 100 >>1 )
            i = 0x20 << 2;     // << : 왼쪽의 피연산자의 비트를 오른쪽 피연산자만큼 왼쪽으로 이동
            i = 0x20 >> 2;     // >> : 왼쪽의 피연산자의 비트를 오른쪽 피연산자만큼 오른쪽으로 이동

            /****************************************************************
            * 연산자 우선순위
            *
            * 여러 연산자가 있는 식에서 우선 순위가 높은 연산자가 먼저 계산
            ****************************************************************/

            // <연산자 우선순위>
            // 1. 기본 연산        : a[i], x++, x--                      ************
            // 2. 단항 연산        : +x, -x, !x, ~x, ++x, --x, (Type)x  
            // 3. 곱하기 연산      : x * y, x / y, x % y                 ***********
            // 4. 더하기 연산      : x + y, x - y                        ********
            // 5. 시프트 연산      : x << y, x >> y
            // 6. 비교 연산        : x < y, x > y, x <= y, x >= y        *****
            // 7. 같음 연산        : x == y, x != y
            // 8. 논리 AND 연산    : x & y, x && y                       ***
            // 9. 논리 XOR 연산    : x ^ y
            // 10. 논리 OR 연산    : x | y, x || y
            // 11. 대입 연산       : x = y, x op= y                      *

        }
    }
}
