using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKata_programmers
{
    /*
    @ DATE   : 2023.9.4 Mon
    @ AUTHOR : 임현진
    */
    internal class DAY08
    {
        // 12. 두 정수 사이의 합 (Math 클래스 쓰고 싶었는데 프로그래머스상에선 Math 유징이 안되더라..ㅠ) 
        // 두 정수 a, b가 주어졌을 때 a와 b 사이에 속한 모든 정수의 합을 리턴하는 함수 완성하기.
        public long solution12(int a, int b)
        {
            long answer = 0;
            long max, min = 0;
            if (a < b)
            {
                max = b;
                min = a;
            }
            else
            {
                max = a;
                min = b;
            }

            for (; min <= max; ++min)
            {
                answer += min;
            }

            return answer;
        }

        // 13. 콜라츠 추측
        // 주어진 수가 1이 될 때까지 다음 작업을 반복하면, 모든 수를 1로 만들 수 있다는 추측. 
        // 1-1. 입력된 수가 짝수라면 2로 나눕니다.
        // 1-2. 입력된 수가 홀수라면 3을 곱하고 1을 더합니다. 
        // 2. 결과로 나온 수에 같은 작업을 1이 될 때까지 반복합니다. 
        //위 작업을 몇 번이나 반복해야 하는지 반환하는 함수 완성하기. 단, 주어진 수가 1인 경우에는 0을, 작업을 500번 반복할 때까지 1이 되지 않는다면 –1을 반환.
        public int solution13(long num)
        {
            int answer = 0;
            while (num != 1)
            {
                if (num % 2 == 0) num /= 2;
                else num = num * 3 + 1;
                ++answer;

                if (answer == 500)
                {
                    answer = -1;
                    break;
                }
            }

            return answer;
        }
    }
}
