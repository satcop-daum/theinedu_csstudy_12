using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Ch04Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Function1();
            //Function2();
            //Function3();
            //Function4();

            //Function5();
            //Function6();

            //Function7();
            //Function8();

            Function9();

        }

        private static void Function9()
        {

            Ch04Class2 myClass = new Ch04Class2();

            int value = 100;
            Console.WriteLine("Main value: " + value);

            myClass.Display(value);

            Console.WriteLine("Main value: " + value);

            Console.WriteLine("=====================");
            
            value = 100;
            Console.WriteLine("Main value: " + value);

            myClass.DisplayRef(ref value);

            Console.WriteLine("Main value: " + value);

        }

        private static void Function8()
        {

            Random random = new Random();

            Ch04Class myClass = new Ch04Class();
            myClass.Show(false);
            myClass.Show2();
            myClass.Show(false);
            myClass.Show2();

            Console.WriteLine("==========================");
            Ch04Class yourClass = new Ch04Class();
            yourClass.Show(false);
            yourClass.Show2();
            yourClass.Show(false);
            yourClass.Show2();


        }

        static void Function7()
        {

            string str = "반도체 장비 및 제어 시스템 S/W개발자";
            String str2 = "!!!";

            Console.WriteLine(str);
            Console.WriteLine(str.Length);
            Console.WriteLine(str[16] + "" + str[17] + "" + str[18]);
        }

        static void Function6()
        {
            //데이터값을 저장하는 배열

            int[,] data = new int[10, 2];

            data[0, 0] = 1;
            data[0, 1] = 2;

            data[1, 0] = 3;
            data[1, 1] = 4;


            int[,,] data3 = new int[10, 2, 4];

            data3[0, 0, 0] = 10;
            data3[0, 0, 1] = 20;

            int[,,,] data4 = new int[10, 2, 4, 5];
            data4[0, 0, 0, 0] = 100;


            //3,2
            int[,] data2 = 
                {
                    {0,0 },
                    {1,1 },
                    {2,2 }
                };

            //4,3,2
            int[,,] data30 =
            {

                {
                    {1,1 },
                    {2,2 },
                    {3,3 }
                },
                {
                    {4,4 },
                    {5,5 },
                    {6,6 }
                 },
                {
                    {7,7 },
                    {8,8 },
                    {9,9 }
                 },
                {
                    {10,10 },
                    {11,11 },
                    {12,12 }
                 }


            };



        }

        static void Function5()
        {
            int[] data = { 10, 11, 12 };

            Console.WriteLine(data.Length);

            for(int i = 0; i < data.Length; i++)
            {
                Console.WriteLine(data[i]);
            }

            Array.Resize(ref data, 5);

            Console.WriteLine("====================");

            Console.WriteLine(data.Length);

            for (int i = 0; i < data.Length; i++)
            {
                Console.WriteLine(data[i]);
            }



        }

        static void Function1()
        {
            //Console.WriteLine("메서드 호출!!!");

            //로또번호: 1~65사이의 값
            //6개를 출력

            Random random = new Random();

            int no1 = random.Next(1, 65);
            int no2 = random.Next(1, 65);
            int no3 = random.Next(1, 65);
            int no4 = random.Next(1, 65);
            int no5 = random.Next(1, 65);
            int no6 = random.Next(1, 65);

            Console.WriteLine("no1: " + no1);
            Console.WriteLine("no2: " + no2);
            Console.WriteLine("no3: " + no3);
            Console.WriteLine("no4: " + no4);
            Console.WriteLine("no5: " + no5);
            Console.WriteLine("no6: " + no6);

        }

        static void Function2()
        {
            Random random = new Random();

            int[] no = new int[6];

            /*
            no[0] = random.Next(1, 65);
            no[1] = random.Next(1, 65);
            no[2] = random.Next(1, 65);
            no[3] = random.Next(1, 65);
            no[4] = random.Next(1, 65);
            no[5] = random.Next(1, 65);

            Console.WriteLine("no[0]: " + no[0]);
            Console.WriteLine("no[1]: " + no[1]);
            Console.WriteLine("no[2]: " + no[2]);
            Console.WriteLine("no[3]: " + no[3]);
            Console.WriteLine("no[4]: " + no[4]);
            Console.WriteLine("no[5]: " + no[5]);
            */

            for (int i = 0; i <= 5; i++)
            {
                no[i] = random.Next(1, 65);
            }

            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine("no[" + i + "]: " + no[i]);
            }
        }

        static void Function3()
        {
            Random random = new Random();

            int[] no = new int[6];

            //중복값이 나오지 않게 처리!!!
            for (int i = 0; i <= 5; i++)
            {
                int randomNo = random.Next(1, 65);
                Console.WriteLine(randomNo);
                //randomNo값이 이미 나온값이니?

                bool dubCheckYn = false;

                //만약에 중복이라면, dubCheckYn = true;
                for(int j = 0; j <= 5; j++)
                {
                    if (no[j] == randomNo)
                    {
                        dubCheckYn = true;
                    }
                }

                if (!dubCheckYn)
                {
                    no[i] = randomNo;
                } else
                {
                    i--;
                }
            }

            Console.WriteLine("로또번호");
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine("no[{0}] = {1}", i, no[i]);
            }
            Console.WriteLine();
        }


        // data배열값에 checkNo값이 존재하는지 여부(있으면: true, 없으면: false)를 리턴
        static bool ExistsYn(int[] data, int checkNo)
        {
            bool checkYn = false;

            //만약에 중복이라면, checkYn = true;
            for (int j = 0; j <= 5; j++)
            {
                if (data[j] == checkNo)
                {
                    checkYn = true;
                }
            }

            return checkYn;
        }

        static void Function4()
        {
            Random random = new Random();

            int[] no = new int[6];
            int index = 0;

            int[] otherNo = { 0, 0, 0, 0, 0, 0, 0 };

            do
            {
                int randomNo = random.Next(1, 7);
                Console.WriteLine("랜덤값: " + randomNo);

                bool existsYn = ExistsYn(no, randomNo);
                if (!existsYn)
                {
                    no[index++] = randomNo;
                }

            } while (index <= 5);

            Console.WriteLine("로또번호");
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine("no[{0}] = {1}", i, no[i]);
            }
            Console.WriteLine();
        }
    }
}
