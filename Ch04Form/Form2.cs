using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch04Form
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        bool ExistsYn(string[] texts, string text)
        {
            bool result = false;

            for(int i = 0; i < texts.Length; i++)
            {
                if (text.Length > 0 && texts[i] == text)
                {
                    result = true;
                }
            }

            return result;
        }

        /*
        - 쩜, 콤마를 공백으로 변환
        - 대소문는 구분하지 않음
        - 공백으로 split
        - 양쪽끝공백제거한 문자열의 길이가 0보다 크면
            => 단어
        */
        string TextProcessing(string text)
        {
            text = text.Replace(".", " ");
            text = text.Replace(",", " ");
            text = text.Replace(";", " ");
            text = text.Replace("\r\n", " ");
            text = text.ToLower();

            string[] resultTexts = new string[1];
            int[] resultTextsCount = new int[1];
            int index = 0;

            string[] allTexts = text.Split(' ');
            for (int i = 0; i < allTexts.Length; i++)
            {
                string curText = allTexts[i].Trim();
                if (!string.IsNullOrEmpty(curText))
                {
                    bool existsYn = ExistsYn(resultTexts, curText);

                    if (!existsYn)
                    {
                        resultTexts[index] = curText;
                        index++;
                        Array.Resize(ref resultTexts, resultTexts.Length + 1);
                        Array.Resize(ref resultTextsCount, resultTextsCount.Length + 1);
                    }
                }
            }

          
            for(int i = 0; i < resultTexts.Length;i++)
            {
                string resultText = resultTexts[i];

                for (int j = 0; j < allTexts.Length; j++)
                {
                    string allText = allTexts[j];

                    if (resultText == allText)
                    {
                        resultTextsCount[i] += 1;
                    }
                }
            }

            string result = "";
            for (int i = 0; i < resultTexts.Length; i++)
            {
                result += string.Format("{0}:\t\t:{1}\r\n", resultTexts[i], resultTextsCount[i]);
            }

            return result;
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            string text = tbInput.Text;

            string result = TextProcessing(text);

            tbOuput.Text = result;
        }
    }
}
