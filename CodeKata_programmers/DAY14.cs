using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKata_programmers
{
    /*
    @ DATE   : 2023.9.12 Tue
    @ AUTHOR : 임현진
    */

    internal class DAY14
    {
        // 24. 문자열 내림차순으로 배치하기
        // 문자열 s에 나타나는 문자를 큰것부터 작은 순으로 정렬해 새로운 문자열을 리턴하는 함수 완성하기.
        // s는 영문 대소문자로만 구성되어 있으며, 대문자는 소문자보다 작은 것으로 간주합니다.

        // using System;
        public string solution24(string s)
        {
            string answer = "";
            int slen = s.Length;
            string[] strarray = new string[slen];

            foreach (char c in s)
            {
                int count = 0;
                foreach (char ch in s)
                {
                    if (c < ch) ++count;
                }
                strarray[count] = Convert.ToString(c);
            }
            for (int i = 0; i < slen; ++i)
            {
                if (String.IsNullOrEmpty(strarray[i])) answer += answer[answer.Length - 1];
                else answer += strarray[i];
            }
            return answer;
        }
    }
}
