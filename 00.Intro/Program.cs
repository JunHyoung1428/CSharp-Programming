namespace _00.Intro
{
    class Program
    {/// <summary>
     ///  메인함수/함수의 자동완성 주석에 설명을 달면 문서 처럼 쓸 수 있음
     /// </summary>
     /// <param name="args">여기에는 매개변수 주석 작성</param>
        static void Main(string[] args)
        {
            /*Console.WriteLine("Login\n");

            Console.WriteLine("Player\tSelect");

            Console.WriteLine("Enter Shop");

            Console.WriteLine("Buy Item");

            Console.WriteLine("End");*/


            //Console.WriteLine("");

            /*
            Console.Write("이름은?:");
            var name = Console.ReadLine();

            Console.WriteLine("이름은 " + name + " 이군요.");

            Console.Write("아무 키를 입력해주세요");
            var key =Console.ReadKey();*/
            Network n = new Network();

            n.RunNetwork();

        }
    }

    internal class Network()
    {
        internal void RunNetwork()
        {

            Console.WriteLine("Start Network");
        }
    }

}
