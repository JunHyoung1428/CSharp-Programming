using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.OOP
{
    /***************************************
     *      캡슐화 Encapsulation
     * 
     *  객체를 정보와 기능(멤버)로 묶는것을 의미
     *  객체의 내부 정보와 기능을 숨기고, 
     *  허용한 정보와 기능만의 액세스를 허용한다.
     *****************************************/
    public class Encapsulation
    {
         void Main1()
        {
            Capsule capsule = new Capsule();
            //capsule.privateValue = 10; // <- 접근 불가
            capsule.publicValue = 1; // <- 접근 가능
        }
    }
    class Capsule
    {
        int variable;       // 멤버변수(필드) : 객체의 정보를 표현
        public int publicValue;
        private int privateValue;

        public void Function() { } // 멤버함수(메소드) : 객체의 기능을 표현
    }

      


    // 접근 제한자
    // 외부에서 접근이 가능한 멤버변수와 멤버함수를 지정하는 기능
    // 접근제한자를 지정하지 않는 경우 기본접근제한자는 private

    // public    : 외부에서도 접근가능
    // private   : 내부에서만 접근가능 
    // protected : 상속한 클래스에서 public, 그외에는 private

    // internal  : 같은 어셈블리 내에서 public, 그외에는 private

    class Kart
    {
        public string name;
        public int maxSpeed;
        private int accelation;
        public int rank;

        public void Accelate()
        {

        }

        public void Break()
        {

        }

        public void Drift() 
        {

        }
    }

    // <캡슐화 사용의미 1>
    // 캡슐화된 클래스는 외부에서 사용하기 위한 인터페이스만을 제공하여 복잡성 감소
    // 캡슐화된 클래스는 내부적으로 어떻게 구현되었는지 몰라도 사용가능

    // <캡슐화 사용의미 2>
    // 캡슐화된 클래스는 외부에서 원하지 않는 사용법으로부터 보호할 수 있어 오용된 사용을 방지
}
