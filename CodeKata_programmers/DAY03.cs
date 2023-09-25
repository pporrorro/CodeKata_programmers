using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKata_programmers
{
    /*
    @ DATE   : 2023.8.28 Mon
    @ AUTHOR : 임현진
    */
    internal class DAY03
    {
        // 6. x만큼 간격이 있는 n개의 숫자
        // 정수 x와 자연수 n을 입력 받아, x부터 시작해 x씩 증가하는 숫자를 n개 지니는 리스트를 리턴하는 함수 완성하기.
        // 제한 조건 x는 -10000000 이상, 10000000 이하인 정수 / n은 1000 이하인 자연수.
        public long[] solution6(long x, int n)
        {
            long[] answer = new long[n];
            long originx = x;
            int count = 0;

            while (count < n)
            {
                answer[count] = x;
                x += originx;
                count++;
            }

            return answer;
        }        
    }
}
