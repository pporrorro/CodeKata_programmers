using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKata_programmers
{
    /*
    @ DATE   : 2023.8.30 Wed
    @ AUTHOR : 임현진
    */
    internal class DAY05
    {
        // 8. 문자열을 정수로 바꾸기
        // 문자열 s를 숫자로 변환한 결과를 반환하는 함수 완성하기.
        public int solution8(string s)
        {
            int answer = 0;
            answer = int.Parse(s);
            return answer;
        }

        // 9. 정수 제곱근 판별
        // 임의의 양의 정수 n에 대해, n이 어떤 양의 정수 x의 제곱인지 아닌지 판단하려 합니다.
        // n이 양의 정수 x의 제곱이라면 x+1의 제곱을 리턴하고 아니라면 -1을 리턴하는 함수를 완성하기.

        // using System; Math 클래스 때문에
        public long solution9(long n)
        {
            long answer = -1;
            double lootn = Math.Sqrt(n);
            if (lootn % 1 == 0 && lootn > 0)
            {
                answer = (long)((lootn + 1) * (lootn + 1));
            }
            return answer;
        }

    }
}
