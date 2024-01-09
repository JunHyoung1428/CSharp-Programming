using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _09.OOP
{
    internal class Inheritance
    {
        /*************************************************************************************
         * 상속 (Inheritance)
         * 
         * 부모클래스의 모든 기능을 가지는 자식 클래스를 설계하는 방법
         * is-a 관계 : 부모클래스가 자식클래스를 포함하는 상위개념일 경우 상속관계가 적합함. <==> has-a 관계 / can - a
         *************************************************************************************/

        // class 자식클래스이름 : 부모클래스이름
        // 코드의 재사용성 UP
        // but 다중상속 X -https://velog.io/@livelyjuseok/C-C%EC%9D%80-%EC%99%9C-%EB%8B%A4%EC%A4%91%EC%83%81%EC%86%8D%EC%9D%B4-%EC%95%88%EB%90%A0%EA%B9%8C
        // 위험부담이 있는 업 캐스팅
        /// 업캐스팅 O (자식클래스를 부모위치에 가능( 묵시적)
        public class Monster
        {
            public string name;
            public int hp;

            
            public void Move()
            {

            }
            public void TakeHit(int dmg)
            {
                hp -= dmg;
                Console.WriteLine($"{name} 이/가 데미지를 받아 체력이 {hp}가 되었습니다.");
            }
        }

        public class AttackRange  
        {
            public float range;
            public void SetTarget()
            {

            }
        }


        public class Dragon : Monster
        {
            public Dragon()
            {
                name = "드래곤";
                hp = 100;
            }
            
            public void Breath()
            {

            }

            public void Reflect()
            {

            }
        }

        public class Slime : Monster
        {
            public Slime()
            {
                name = "슬라임";
                hp = 25;
            }
        }
        static void Main2()
        {
            Dragon dragon = new Dragon();
           dragon.TakeHit(10);

            Slime slime = new Slime();
            slime.TakeHit(10);

            //업캐스팅
            Monster monster1 = new Dragon(); // 부모클래스에 자식클래스를 보관 (묵시적)
            //monster1.Breath(); // 부모클래스에 보관된 자식클래스의 메소드는 사용 불가
            Monster monster2 = new Slime();

            //다운캐스팅     부모클래스를 자식 클래스에 보관 - 다형성과 추상화 특성으로 대체 가능
            Dragon dra = (Dragon)monster1;  //100%인 경우에만 명시적으로 진행 - 불가능하면 Error 

            // is 키워드를 사용해 캐스팅이 가능한지 여부를 bool로 반환
            if(monster1 is Dragon)
            {
                Dragon d = (Dragon)monster1;
                Console.WriteLine("monster1은 드래곤입니다");
            }
            else
            {
                Console.WriteLine("monster1은 드래곤이 아닙니다.");
            }

            Dragon asDragon = monster1 as Dragon; // as 키워드를 통해 가능할 경우에만 다운캐스팅
            Slime asSlime = monster1 as Slime; // 아니면 NULL 리턴

        }

        public class DragonKiller
        {
            int dmg = 3;
            public void Attack(Monster monster)
            {
                monster.TakeHit(dmg);
                if( monster is Dragon)
                {
                    Dragon dr = (Dragon)monster;
                    dr.Reflect();
                }
            }
        }

    }
}
