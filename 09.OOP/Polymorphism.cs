using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _09.OOP
{
    internal class Polymorphism
    {
        /**********************************************************************************
         * 다형성 Polymorphism
         * 
         * 부모클래스의 멤버를 자식클래스가 상황에 따라 여러가지 형태를 가질 수 있는 성질
         **********************************************************************************/

        class Car
        {
            protected string name;
            protected int speed;
            public void Move()
            {
                Console.WriteLine($"{name} 이/가 {speed} 의 속도로 이동합니다.");
            }
        }

        class Truck : Car
        {
            public Truck()
            {
                name = "트럭";
                speed = 35;
            }
        }

        class Sport : Car
        {
            public Sport()
            {
                name = "스포츠카";
                speed = 100;
            }
        } // 자료 자체의 데이터를 달리한 예

        static void Main2()
        {
            Car car1 = new Truck();
            Car car2 = new Sport();

            car1.Move();
            car2.Move();

           FireBall fireball = new FireBall();
           Skill heal = new Heal();


            fireball.Execute();
            heal.Execute(); //skill.Excute

            Heal heal2 = new Heal();
            heal2.Execute();

            SuperFireBall superFireBall = new SuperFireBall();
            superFireBall.Execute();

            

        }

        // <가상함수와 오버라이딩>
        // 가상함수   : 부모클래스의 함수 중 자식클래스에 의해 재정의 할 수 있는 함수를 지정
        // 오버라이딩 : 부모클래스의 가상함수를 같은 함수이름과 같은매개변수로 재정의하여 자식만의 반응을 구현 

        // ***가상 함수 테이블(CS 지식)
        public class Skill
        {
            protected float coolTime;
            public virtual void Execute()  // virtual 키워드를 사용해 가상함수 지정, 자식 클래스에서 재정의를 허용해줌
            {
                Console.WriteLine("Use Skill / Run CoolTime");
            }

        }
        //<<다형성 사용의미 1>>
        // 새 클래스를 추가하거나 확장할 때 기존 코드의 영향을 최소화함
        public class FireBall : Skill
        {
            public FireBall()
            {
                coolTime = 3f;
               
            }

            public override void Execute() // override 키워드를 통해 앞서 지정한 가상함수를 덮어 씌워줌 , 가상함수가 아니면 재정의 불가 , 행동을 달리해줌
            {
                base.Execute(); // base 키워드를 사용 해 부모클래스의 기능을 가져올 수 있음
                Console.WriteLine("Throw FireBall");
            }
        }
        //<<다형성 사용의미 2>>
        // 클래스간의 의존성을 줄여 확장성을 높임

        public class SuperFireBall: FireBall
        {
            public SuperFireBall()
            {
            }
            public override void Execute()
            {
                
                Console.WriteLine("Super Fire Ball");
            }
        }

        public class Heal : Skill
        {
            public Heal()
            {
                coolTime = 15f;
                
            }
            public new void  Execute() //메소드 하이딩
            {
                Console.WriteLine("Healing Target");
            }

        }
    }
}
