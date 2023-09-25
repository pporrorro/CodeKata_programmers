using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKata_programmers
{
    internal class DAY23
    {
        /*
        @ DATE   : 2023.9.25 Mon
        @ AUTHOR : 임현진
        */

        // 37. 문자열 내 마음대로 정렬하기 (1시간 반 소요.. 테스트케이스 넣어볼만한 거 검색하다가 시간 다 감ㅠ)
        // 
        public string[] solution37(string[] strings, int n)
        {
            string[] answer = new string[strings.Length];

            for (int i = 0; i < strings.Length; ++i)
            {
                int maxcount = 0;
                string str1 = strings[i];
                for (int j = 0; j < strings.Length; ++j)
                {
                    if (i == j) continue;

                    string str2 = strings[j];
                    if (str1[n] > str2[n]) ++maxcount;
                    else if (Char.Equals(str1[n], str2[n]))
                    {
                        bool isshort = true;
                        int minlen = str1.Length;
                        if (str1.Length > str2.Length)
                        {
                            minlen = str2.Length;
                            isshort = false;
                        }
                        for (int k = 0; k < minlen; ++k)
                        {
                            // 사전순에 따라 인덱스 0부터 비교하면서 순서가 판별되면 바로 탈출
                            if (str1[k] > str2[k])
                            {
                                ++maxcount;
                                break;
                            }
                            else if (str1[k] < str2[k]) break;
                            // 철자가 모두 같지만 길이가 다른 단어일 때 짧은쪽이 작음(앞순서)
                            else if (str1[k] == str2[k] && k == minlen - 1)
                            {
                                if (!isshort) ++maxcount;
                                break;
                            }
                            else continue;
                        }
                    }
                }
                if (answer[maxcount] != null) ++maxcount;
                answer[maxcount] = str1;
            }
            return answer;
        }

    }
}
