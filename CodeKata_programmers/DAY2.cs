using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKata_programmers
{
    internal class DAY2
    {
        // 4. 약수의 합
        // 정수 n을 입력받아 n의 약수를 모두 더한 값을 리턴하는 함수 완성하기..
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
        // 자연수 n 이 매개변수로 주어질 때 n을 x로 나눈 나머지가 1이 되도록 하는 가장 작은 자연수 x를 return 하도록 함수 완성하기.
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
