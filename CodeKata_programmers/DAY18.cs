using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKata_programmers
{
    /*
    @ DATE   : 2023.9.18 Mon
    @ AUTHOR : 임현진
    */

    internal class DAY18
    {
        // 31. 이상한 문자 만들기
        // 문자열 s는 한 개 이상의 단어로 구성되어 있습니다. 각 단어는 하나 이상의 공백문자로 구분되어 있습니다.
        // 각 단어의 짝수번째 알파벳은 대문자로, 홀수번째 알파벳은 소문자로 바꾼 문자열을 리턴하는 함수 완성하기.
        
        // using System;
        public string solution31(string s)
        {
            string answer = "";
            string[] strarray = s.Split(' ');

            int split = 0;
            foreach (char ch in s)
            {
                string str = Convert.ToString(ch);

                if (str == " ") split = 0;
                else
                {
                    if (split == 0 || split % 2 == 0)
                    {
                        str = str.ToUpper();
                    }
                    else str = str.ToLower();

                    ++split;
                }
                answer += str;
            }
            return answer;
        }
    }
}
