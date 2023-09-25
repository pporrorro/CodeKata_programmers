using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKata_programmers
{
    /*
    @ DATE   : 2023.9.7 Thu
    @ AUTHOR : 임현진
    */

    internal class DAY11
    {
        // 19. 제일 작은 수 제거하기
        // 정수를 저장한 배열, arr 에서 가장 작은 수를 제거한 배열을 리턴하는 함수 완성하기.
        // 단, 리턴하려는 배열이 빈 배열인 경우엔 배열에 -1을 채워 리턴.
        // 예를들어 arr이 [4,3,2,1]인 경우는 [4,3,2]를 리턴 하고, [10]면 [-1]을 리턴.
        // ** 포인트는 원래 배열의 순서는 유지할 것!!! .. 오래걸림ㅠ

        public int[] solution19(int[] arr)
        {
            int arrlen = arr.Length;
            int index = 0;
            int[] answer;

            if (arrlen == 1)
            {
                answer = new int[1] { -1 };
            }
            else
            {
                answer = new int[arrlen - 1];
                for (int i = 0; i < arrlen; ++i)
                {
                    int minnum = arr[i];
                    foreach (int j in arr)
                    {
                        if (minnum > j)
                        {
                            minnum = j;
                            break;
                        }
                    }

                    if (minnum != arr[i])
                    {
                        answer[index] = arr[i];
                        ++index;
                    }
                }
            }

            return answer;
        }
    }
}
