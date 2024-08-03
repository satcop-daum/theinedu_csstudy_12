using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch02Console
{
    internal class Program
    {
        static void Main_01(string[] args)
        {
            /* 입력처리 */
            Console.WriteLine("첫번째 숫자값을 입력해 주세요.");
            string input1 = Console.ReadLine();
            Console.WriteLine("두번째 숫자값을 입력해 주세요.");
            string input2 = Console.ReadLine();

            Console.WriteLine("첫번째 입력값: " + input1);
            Console.WriteLine("두번째 입력값: " + input2);

            int value1 = Convert.ToInt32(input1);
            int value2 = Convert.ToInt32(input2);   

            Console.WriteLine("input1 + input2 :" + (value1 + value2));
            Console.WriteLine("input1 - input2 :" + (value1 - value2));


            bool checkYn; //변수를 선언
            checkYn = false; //변수에 값을 대입

            bool flagYn = true;//변수를 선언과 동시에 값을 대입


            int age = 0; //정수형 변수(int)를 선언하고 0으로 초기화
            long numbers = -100; //정수형 변수(long)를 선언하고 100으로 초기화


            float pi = 3.14f;
            double dValue = 3.14;

            //파랑색은 예약된 키워드 

            char ch1 = 'A'; //따옴표는 문자
            string str1 = "AAA"; //쌍따옴표는 문자열
            String str2 = "BBB"; //문자열


            //char ch2 = "A";

            DateTime tody = DateTime.Now;

        }
   
    
        static void Main_02(string[] args)
        {
            int age = 10; //age변수를 선언하고 10으로 초기화(대입)

            int myAge; //myAge변수를 선언
            myAge = 10; //myAge에 10으로 대입(myAge변수에 10이라는 상수를 대입)


            // 프로그래밍에서 "="은 오른쪽과 왼쪽이 같다라는 의미가 아니라
            //                   오른쪽에 있는 값을 왼쪽에 대입
            //                   오른쪽에 있는 연산결과가 왼쪽에 대입

            myAge = age; //myAge변수에 age변수의 값을 대입
            myAge = age + 10;

            //20 = 10;


            //변수를 사용하기 위해서 선언을 하는건데...
            //필요한 데이터 타입(int, bool, double, string)을 먼저 써주고, 그 뒤에 변수를 선언

            string myName = "홍길동";
            String yourName = "홍길순";


            Console.WriteLine("myName의 문자열 길이:" + myName.Length);

            Console.WriteLine("myName의 첫번째 문자는: " + myName.Substring(0, 1));



            int count1 = 0;
            int count2 = 0;

            int count11 = 0, count12 = 0;

        }
    

        static void Main_03(string[] args)
        {
            int value1 = 100;
            int value2 = 200;

            Console.WriteLine("value1 : {0}, value2 : {1}, sum = {2}"
                , value1, value2, value1 + value2);


            Console.WriteLine("value1 : " + value1 + ", value2 : " + value2 + ", sum = "
                + (value1 + value2));

        }


        static void Main_04(string[] args)
        {

            Console.WriteLine("금액을 입력해 주세요:");
            string input = Console.ReadLine();

            int value = Convert.ToInt32(input);
            //value = 127549;

            //개수파악
            int cnt50000 = value / 50000;
            int cnt10000 = (value - cnt50000 * 50000) / 10000;
            int cnt5000  = (value - cnt50000 * 50000 - cnt10000 * 10000) / 5000;
            int cnt1000  = (value - cnt50000 * 50000 - cnt10000 * 10000 - cnt5000 * 5000) / 1000;
            int cnt500   = (value - cnt50000 * 50000 - cnt10000 * 10000 - cnt5000 * 5000 - cnt1000 * 1000) / 500;
            int tip      = (value - cnt50000 * 50000 - cnt10000 * 10000 - cnt5000 * 5000 - cnt1000 * 1000) % 500;

            string msg = "오만원: {0}장, 만원: {1}장, 오천원: {2}장, 천원:{3}, 오백원: {4}개, 팁: {5}";
            Console.WriteLine(msg, cnt50000, cnt10000, cnt5000, cnt1000, cnt500, tip);

        }


        static void Main_05(string[] args)
        {


            int i = 10;
            Console.WriteLine(i);

            i++;
            Console.WriteLine(i);

            ++i;
            Console.WriteLine(i);

            Console.WriteLine(i++);
            Console.WriteLine(++i);
        }


        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;

            bool result1 = a == b;
            bool result2 = a != b;
            bool result3 = a > b;
            bool result4 = a < b;
            bool result5 = a >= b;
            bool result6 = a <= b;

            //bool result7 = a => b;
            //bool result 8 = a =< b;



        }


    }
}
