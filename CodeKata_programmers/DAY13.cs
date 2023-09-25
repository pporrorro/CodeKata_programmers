using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKata_programmers
{
    /*
    @ DATE   : 2023.9.11 Mon
    @ AUTHOR : 임현진
    */

    internal class DAY13
    {
        //22. 내적 - 뛰어 넘음 다음에 개념 공부해서 다시 보기로!

        // 23. 약수의 개수와 덧셈
        // 두 정수 left부터 right까지의 모든 수들 중에서,
        // 약수의 개수가 짝수인 수는 더하고, 약수의 개수가 홀수인 수는 뺀 수를 return 하는 함수 완성하기.

        public int solution23(int left, int right)
        {
            int answer = 0;

            for (int i = left; i <= right; ++i)
            {
                int count = 0;
                for (int j = 1; j <= i; ++j)
                {
                    if (i % j == 0) ++count;
                }

                if (count % 2 == 0) answer += i;
                else answer -= i;
            }

            return answer;
        }

    }
}
