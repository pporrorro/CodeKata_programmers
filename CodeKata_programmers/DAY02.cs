using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKata_programmers
{
    /*
    @ DATE   : 2023.8.25 Fri
    @ AUTHOR : 임현진
    */
    internal class DAY02
    {
        // 4. 약수의 합
        // 정수 n을 입력받아 n의 약수를 모두 더한 값을 리턴하는 함수 완성하기.
        public int solution4(int num)
        {
            int answer = 0;
            int inum = 1;   // 0으로는 나눌 수 없기 때문에 가장 작은 단위인 1 로 할당.

            while (inum <= num)
            {
                if (num % inum == 0) answer += inum;
                inum++;
            }

            return answer;
        }

        // 5. 나머지가 1이 되는 수 찾기
        // 자연수 n을 x로 나눈 나머지가 1이 되도록 하는 가장 작은 자연수 x를 리턴하는 함수 완성하기.
        // 답이 항상 존재함은 증명될 수 있습니다.

            public int solution5(int num)
            {
                int answer = 0;
                int inum = 1;

                while (inum < num)
                {
                if (num % inum == 1)
                {
                    answer = inum;
                    break;
                }
                    inum++;
                }
                return answer;
            }

    }
}
