using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch05Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("프로그램 시작");

            StreamWriter sw = null;
            try
            {
                sw = new StreamWriter("c:\\abc\\rrdef.txt");

                int[] values = { 0, 1 };
                values[0] = 0;
                values[1] = 1;
                values[2] = 10;


                int a = 100;
                int b = 0;
                int c = a / b;

                sw.WriteLine(c);
                sw.Flush();
            }
            catch (DivideByZeroException e)
            {
                //Console.WriteLine(e);
                Console.WriteLine("0으로 나눌 수 없습니다.");
            }
            catch (UnauthorizedAccessException e)
            {
                Console.WriteLine("파일에 접근할 수 있는 권한이 없습니다.");
            }
            catch (Exception e)
            {
                Console.WriteLine("알수 없는 에러가 발생했습니다. 관리자에게 문의해 주세요.");
            }

            finally
            {
                //리소스를 해제하는 기능
                if (sw != null)
                {
                    sw.Close();
                }
            }


            Console.WriteLine("프로그램 종료");
        }
    }
}
