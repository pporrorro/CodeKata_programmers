using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKata_programmers
{
    internal class DAY20
    {
        /*
        @ DATE   : 2023.9.20 Wed
        @ AUTHOR : 임현진
        */

        // 34. 최소 직사각형 - 행렬공부가 좀 필요할 듯함 빼놓기
        // 다양한 모양과 크기의 명함들을 모두 수납할 수 있으면서, 작아서 들고 다니기 편한 지갑을 만들어야 합니다.
        // 이러한 요건을 만족하는 지갑을 만들기 위해 디자인팀은 모든 명함의 가로 길이와 세로 길이를 조사했습니다.
        // 모든 명함의 가로 길이와 세로 길이를 나타내는 2차원 배열 sizes 로 모든 명함을 수납할 수 있는 가장 작은 지갑을 만들 때, 지갑의 크기를 return 하는 함수 완성하기.
        // 세로 수납 가능

        // 35. 시저 암호
        // 각 알파벳을 일정한 거리만큼 밀어서 다른 알파벳으로 바꾸는 암호화 방식을 시저 암호라고 합니다.
        // 예를 들어 "AB"는 1만큼 밀면 "BC"가 되고, 3만큼 밀면 "DE"가 됩니다. "z"는 1만큼 밀면 "a"가 됩니다.
        // 문자열 s와 거리 n을 입력받아 s를 n만큼 민 암호문을 만드는 함수 완성하기.
        
        // using System;

        public string solution35(string s, int n)
        {
            string answer = "";

            for (int i = 0; i < s.Length; ++i)
            {
                int ich = (int)s[i];
                if (65 <= ich && ich <= 90)
                {
                    ich += n;
                    if (ich > (int)'Z') ich -= 26;  // - 90 + 64
                    answer += (char)ich;
                }
                else if (97 <= ich && ich <= 122)
                {
                    ich += n;
                    if (ich > (int)'z') ich -= 26;  // - 122 + 96
                    answer += (char)ich;
                }
                else answer += Convert.ToString(s[i]);
            }

            return answer;
        }

    }
}
