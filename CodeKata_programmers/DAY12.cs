using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKata_programmers
{
    /*
    @ DATE   : 2023.9.8 Fri
    @ AUTHOR : 임현진
    */
    internal class DAY12
    {
        // 20. 가운데 글자 가져오기
        // 단어 s의 가운데 글자를 반환하는 함수 완성하기. 단어의 길이가 짝수라면 가운데 두글자를 반환하면 됩니다.

            public string solution20(string s)
            {
                string answer = "";
                int slen = s.Length;

                if (slen % 2 == 0) s.Substring(slen / 2 - 1, 2);
                else s.Substring(slen/2,1);
                return answer;
            }

        // 21. 수박수박수박수박수박수?
        // 길이가 n이고, "수박수박수박수...."와 같은 패턴을 유지하는 문자열을 리턴하는 함수 완성하기.
        // 예를들어 n이 4이면 "수박수박"을 리턴하고 3이라면 "수박수"를 리턴하면 됩니다.
        public string solution21(int n)
        {
            string answer = "";

            for (int i = n; i > 0; --i)
            {
                if (answer.EndsWith("수")) answer += "박";
                else answer += "수";
            }

            return answer;
        }

    }
}
