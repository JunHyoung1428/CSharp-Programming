﻿
namespace _10._Interface
{
    internal class Program
    {
        /***************************************************************************
        * 인터페이스 (Interface)
        * 
        * 인터페이스는 맴버를 가질 수 있지만 직접 구현하지 않음 단지 정의만을 가짐
        * 인터페이스를 가지는 클래스에서 반드시 인터페이스의 정의를 구현해야함
        * 이를 반대로 표현하자면 인터페이스를 포함하는 클래스는
        * 반드시 인터페이스의 구성 요소들을 구현했다는 것을 보장함
        * Can-a 관계 : 클래스가 해당 행동을 할 수 있는 경우 적합함
        ***************************************************************************/

        // <인터페이스 정의>
        // 일반적으로 인터페이스의 이름은 I로 시작함
        // 인터페이스의 함수는 직접 구현하지 않고 정의만 진행

        public interface IEnterable
        {
            public void Enter();
        }

        public interface IOpenable
        {
            public void Open();
        }


        //<인터페이스 포함>
        // 상속 처럼 정의한 인터페이스를 클래스 뒤에 : 붙여서 사용
        // 인터페이스는 여러개 포함 가능
        // 포함하는 경우 반드시 인터페이스에서 정의한 함수를 구현해야만 함

        public class OpenableObject
        {
            public virtual void Open()
            {
                Console.WriteLine("열립니다.");
            }
        }

        public class EnterableObject
        {
            public virtual void Enter()
            {
                Console.WriteLine("들어갑니다.");
            }
        }
        public class Box : IOpenable
        {
            public void Open()
            {
                Console.WriteLine("박스를 엽니다.");
            }
        }

        public class Door : IEnterable, IOpenable//  OpenableObject, EnterableObject 두개의 클래스는 상속 불가.  인터페이스 사용
        {
            public void Enter()
            {
                Console.Write("문을 들어갑니다.");
            }

            public void Open()
            {
                Console.WriteLine("문을 엽니다.");
            }
        }

        public class Town : IEnterable
        {
            public void Enter()
            {
                Console.WriteLine("마을에 진입합니다.");
            }
        }

        // <인터페이스 사용>
        // 인터페이스를 이용하여 기능을 구현할 경우
        // 클래스의 상속관계와 무관하게 행동의 가능여부로 상호작용 가능
        public class Player
        {
            public void Open(IOpenable openableObject)
            {
                Console.WriteLine("플레이어가 박스를 엽니다.");
                openableObject.Open();
            }

            public void Enter(IEnterable enterable)
            {
                Console.WriteLine("플레이어가 마을에 진입합니다.");
                enterable.Enter();
            }

        }

        static void Main(string[] args)
        {
            Player player = new Player();

            Door door = new Door();
            Box box = new Box();
            Town town = new Town();

            // player.Enter(box);			    // error : Box 는 IEnterable 인터페이스가 없음
            player.Enter(door);
            player.Enter(town);

            player.Open(box);
            player.Open(door);
            // player.Open(town);		        // error : Town 는 IOpenable 인터페이스가 없음

            IEnterable enterable;
            enterable = new Door();
            enterable = new Town();
            // enterable = new IEnterable();    // error : 인터페이스는 인스턴스화 불가
        }
    }
}
