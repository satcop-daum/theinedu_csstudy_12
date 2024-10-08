﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch03Console
{
    internal class Program
    {
        static void Main_01(string[] args)
        {
            //Console.WriteLine("3일차 수업시작!!");


            int a = 100;

            //조건1
            if (a > 50)
            {
                Console.WriteLine("참입니다.");
            }
            else
            {
                Console.WriteLine("거짓입니다.");
            }

            //조건2
            if (a > 200)
            {
                Console.WriteLine("참입니다.");
                Console.WriteLine("정말 참입니다.");
            }


            //조건3
            int height = 165;

            // 180?
            // 170?
            // 160?
            // 그외

            if (height >= 180)
            {
                Console.WriteLine("180이상입니다.");
            }
            else
            {
                if (height >= 170)
                {
                    Console.WriteLine("170이상입니다.");
                }
                else
                {
                    if (height > 160)
                    {
                        Console.WriteLine("160이상입니다.");
                    }
                    else
                    {
                        Console.WriteLine("그외입니다.");
                    }
                }
            }

            if (height >= 180)
            {
                Console.WriteLine("180이상입니다.");
            }
            else if (height >= 170)
            {
                Console.WriteLine("170이상입니다.");
            }
            else if (height > 160)
            {
                Console.WriteLine("160이상입니다.");
            }
            else
            {
                Console.WriteLine("그외입니다.");
            }



            //연산
            int a1 = 100 + 200;

            //삼항연산자
            //int result2 = (조건식) ? (참) : (거짓);

            int score = 60;
            string scoreResult = "";
            if (score >= 60)
            {
                scoreResult = "합격";
            } else
            {
                scoreResult = "불합격";    
            }
            Console.WriteLine(scoreResult);

            int score2 = 55;
            string score2Result = (score2 >= 60) ? "합격" : "불합격";
            Console.WriteLine(score2Result);


        }

        static void Main_02(string[] args)
        {
            // 숫자를 입력(1~12범위)
            // 숫자에 해당하는 월의 일수를 구하는 프로그램

            int month = 6;
            int day = 0;
            String dayResult = "";

            
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    day = 31;
                    break;

                case 2:
                    day = 28;
                    break;

                case 4:
                case 6:
                case 9:
                case 11:
                    day = 30;
                    break;

                default:
                    Console.WriteLine("입력값이 정확하지 않습니다.");
                    break;
            }

            switch (month)
            {
                case 2:
                    {
                        int year = 2024;
                        day = 28;
                        dayResult = day + "월";
                    }
                    break;

                case 4:
                case 6:
                case 9:
                case 11:
                    {
                        int year = 2024;
                        day = 30;
                        dayResult = day + "월";
                    }
                    break;

                default:
                    {
                        int year = 2024;
                        day = 31;
                        dayResult = day + "월";
                    }
                    break;

            }



        }
 

        static void Main_03(string[] args)
        {
            for (int j = 1; j <= 9; j++)
            {
                for (int i = 2; i <= 9; i++)
                {
                    Console.Write("{0} x {1} = {2}\t", i, j, i * j);
                }
                Console.WriteLine();
            }
        }


        static void Main(string[] args)
        {
            //숫자값을 계속 입력(한개의 입력은 엔터) 받음.
            //입력받은 값은 계속 누적
            //0을 입력하면 계속 입력을 종료하고 누적값 출력

            /*
            int sum = 0;
            bool runYn = false;

            while (runYn)
            {
                int readValue = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("입력값:" + readValue);

                if (readValue == -1)
                {
                    runYn = false;
                    //break;
                    continue;
                }

                sum += readValue;
                Console.WriteLine("누적값: " + sum);
            }
            Console.WriteLine("종료전 누적값: " + sum);
            */


            int sum = 0;
            bool runYn = false;

            do
            {
                int readValue = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("입력값:" + readValue);

                if (readValue == -1)
                {
                    runYn = false;
                    //break;
                    continue;
                }

                sum += readValue;
                Console.WriteLine("누적값: " + sum);
            } while (runYn);

            Console.WriteLine("종료전 누적값: " + sum);


        }

    }
}
