using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch05Form
{
    internal class FileUtils
    {

        // filePath에 있는 파일을 읽어서 텍스트 문자열을 리턴하는 메서드
        public static string GetTextFromFile(string filePath)
        {
            StreamReader streamReader = new StreamReader(filePath);

            string allText = "";
            while (true)
            {
                string readText = streamReader.ReadLine();
                if (readText == null)
                {
                    break;
                }

                allText += "\r\n" + readText;
            }

            streamReader.Close();

            return allText;
        }

        // text의 내용을 filePath의 파일에 저장하는 메서드
        public static void SaveFileFromText(string filePath, string text)
        {
            File.WriteAllText(filePath, text);
        }

    }
}
