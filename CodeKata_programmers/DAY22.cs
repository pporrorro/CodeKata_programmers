using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKata_programmers
{
    internal class DAY22
    {
        /*
        @ DATE   : 2023.9.22 Fri
        @ AUTHOR : 임현진
        */

        // 뛰어넘었던 문제 풀기! 22번, 34번

        // 22. 내적 - 제목이랑 설명 슬쩍보고 이과문제인가봐! 하고 지레 겁먹고 도망쳤나보다ㅋㅋ
        // 길이가 같은 두 1차원 정수 배열 a와 b의 내적을 return 하도록 함수 완성하기.
        // 이때, a와 b의 내적은 a[0]*b[0] + a[1]* b[1] + ... + a[n - 1]* b[n - 1] 입니다. (n은 a, b의 길이)

        public int solution22(int[] a, int[] b)
        {
            int answer = 0;
            int ablen = a.Length;

            for (int i = 0; i < ablen; ++i)
            {
                answer += a[i] * b[i];
            }

            return answer;
        }

        // 34. 최소직사각형
        // 다양한 모양과 크기의 명함들을 모두 수납할 수 있으면서, 작아서 들고 다니기 편한 지갑을 만들어야 합니다.
        // 이러한 요건을 만족하는 지갑을 만들기 위해 디자인팀은 모든 명함의 가로 길이와 세로 길이를 조사했습니다.
        // 모든 명함의 가로 길이와 세로 길이를 나타내는 2차원 배열 sizes 로 모든 명함을 수납할 수 있는 가장 작은 지갑을 만들 때, 지갑의 크기를 return 하는 함수 완성하기.
        // 세로 수납 가능

        public int solution34(int[,] sizes)
        {
            int answer = 0;
            int maxW = 0;
            int maxH = 0;

            for (int i = 0; i < sizes.GetLength(0); ++i)
            {
                int a = sizes[i, 0];
                int b = sizes[i, 1];
                if (a < b)
                {
                    sizes[i, 0] = b;
                    sizes[i, 1] = a;
                }
                if (maxW < sizes[i, 0]) maxW = sizes[i, 0];
                if (maxH < sizes[i, 1]) maxH = sizes[i, 1];
            }

            answer = maxW * maxH;
            return answer;
        }
    }
}
