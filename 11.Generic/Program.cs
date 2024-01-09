using System;

namespace _11._Generic
{
    internal class Program
    {
        /********************************************************************************************
        * 일반화 (Generic)
        * 
        * 클래스 또는 함수가 코드에 의해 선언되고 인스턴스화될 때까지 형식의 사양을 연기하는 디자인
        * 기능을 구현한 뒤 자료형을 사용 당시에 지정해서 사용
        ********************************************************************************************/

        // <일반화 함수>
        // 일반화가 없는 경우 자료형마다 함수를 작성
        public static void IntArrayCopy(int[] source, int[] output)
        {
            for (int i = 0; i < source.Length; i++)
            {
                output[i] = source[i];
            }
        }
        public static void FloatArrayCopy(float[] source, float[] output)
        {
            for (int i = 0; i < source.Length; i++)
            {
                output[i] = source[i];
            }
        }


        // 일반화를 이용하면 위 함수들과 다른 자료형의 함수 또한 호환할 수 있음
        public static void ArrayCopy<Type>(Type[] source, Type[] output) //함수명 <자료형 이름> 붙이는것으로 선언 
        {
            for (int i = 0; i < source.Length; i++)
            {
                output[i] = source[i];
            }
        }

        static void Main(string[] args)
        {

            int[] iSrc = { 1, 2, 3, 4, 5 };
            float[] fSrc = { 1f, 2f, 3f, 4f, 5f };
            double[] dSrc = { 1d, 2d, 3d, 4d, 5d };

            int[] iDst = new int[iSrc.Length];
            float[] fDst = new float[fSrc.Length];
            double[] dDst = new double[dSrc.Length];
            //일반화가 없는 경우 자료형 마다 함수 구현
            IntArrayCopy(iSrc, iDst);
            FloatArrayCopy(fSrc, fDst);

            // 일반화된 함수로 자료형과 무관한 함수 구현
            ArrayCopy<int>(iSrc, iDst);         // 자료형을 함수 호출 당시 결정
            ArrayCopy<float>(fSrc, fDst);
            ArrayCopy<double>(dSrc, dDst);

        }

        // <일반화 클래스>
        // 클래스에 필요한 자료형을 일반화하여 구현
        // 이후 클래스 인스턴스를 생성할 때 자료형을 지정하여 사용
        public class SafeArray<T>
        {
            T[] array;

            public SafeArray(int size)
            {
                array = new T[size];
            }

            public void Set(int index, T value)
            {
                if (index < 0 || index >= array.Length)
                    return;

                array[index] = value;
            }

            public T Get(int index)
            {
                if (index < 0 || index >= array.Length)
                    return default(T);      // default : T 자료형의 기본값

                return array[index];
            }
        }


        // <일반화 자료형 제약>
        // 일반화 자료형을 선언할 때 제약조건을 선언하여, 사용 당시 쓸 수 있는 자료형을 제한 / where 키워드 / 중복해서도 걸 수 있음
        class StructT<T> where T : struct { }           // T는 구조체만 사용 가능
        class ClassT<T> where T : class { }             // T는 클래스만 사용 가능
        class NewT<T> where T : new() { }               // T는 매개변수 없는 생성자가 있는 자료형만 사용 가능

        class ParentT<T> where T : Parent { }           // T는 Parent 파생클래스만 사용 가능
        class InterfaceT<T> where T : IComparable { }   // T는 인터페이스를 포함한 자료형만 사용 가능

        public static Type Bigger<Type>(Type left, Type right) where Type : IComparable
        {
            if (left.CompareTo(right) < 0)
            {
                return right;
            }
            else
            {
                return left;
            }
        }




        class Parent { }
        class Child : Parent { }

    }
}
