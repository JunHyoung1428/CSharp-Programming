using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.OOP
{
    internal class Abstraction
    {
        /***************************************************************************
         * 추상화 (Abstraction)
         *
         * 클래스를 정의할 당시 구체화 시킬 수 없는 기능을 추상적 표현으로 정의
         ****************************************************************************/
        // abstract 키워드를 사용
        public abstract class Animal {
            public string name;
            public int age;

            public virtual void AAA()
            {

            }
            public abstract void Cry();  // 이후 추상클래스를 상속받는 클래스는 이 함수를 반드시 오버라이드해야만 함

        }

        public class Cat : Animal
        {
            public override void Cry()
            {
                Console.WriteLine("Meow");
            }
        }

        public class Dog : Animal
        {
            public override void Cry()
            {
                Console.WriteLine("BowWow");
            }
        }

        static void Main()
        {
            Animal cat = new Cat();
            Animal dog = new Dog();

            cat.Cry();
            dog.Cry();
            
            Player player = new Player();
            Item item = new Potion();

            player.Use(item);

        }

        public class Player
        {
            public void Use(Item item)
            {
                item.Use();
            }
        }

        // <추상화 사용의미 1>
        // 객체들의 공통적인 특징을 도출하는데 의미
        // 구현을 구체화하기 어려운 상위클래스를 설계하기 위한 수단으로 사용

        // <추상화 사용의미 2>
        // 상위클래스의 인터페이스를 구현하기 위한 수단으로 사용
        // 추상적인 기능을 구체화시키지 않은 경우 인스턴스 생성이 불가
        // 이를 통해 자식클래스에게 순수가상함수의 구현을 강제하여 실수를 줄임
        public abstract class Item
        {
            public abstract void Use();
        }
        public class Potion : Item
        {
            public override void Use()
            {
                Console.WriteLine("포션을 사용하여 체력을 회복합니다.");

            }
        }

        public class Equip : Item
        {
            public override void Use()
            {
                Console.WriteLine("장비를을 착용합니다.");
            }
        }
    }
}
