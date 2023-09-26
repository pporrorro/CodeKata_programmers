using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKata_programmers
{
    internal class DAY24
    {
        /*
        @ DATE   : 2023.9.26 Tue
        @ AUTHOR : 임현진
        */

        // 38. K번째수
        // 배열 array의 i번째 숫자부터 j번째 숫자까지 자르고 정렬했을 때, k번째에 있는 수를 구하려 합니다.
        // 예를 들어 array가[1, 5, 2, 6, 3, 7, 4], i = 2, j = 5, k = 3이라면
        // array의 2번째부터 5번째까지 자르면[5, 2, 6, 3]입니다.
        // 1에서 나온 배열을 정렬하면[2, 3, 5, 6]입니다.
        // 2에서 나온 배열의 3번째 숫자는 5입니다.
        // 배열 array, [i, j, k]를 원소로 가진 2차원 배열 commands가 매개변수로 주어질 때,
        // commands의 모든 원소에 대해 앞서 설명한 연산을 적용했을 때 나온 결과를 배열에 담아 return 하도록 함수 완성하기.

        // using System;
        public int[] solution38(int[] array, int[,] commands)
        {
            int comlen = commands.GetLength(0);
            int[] answer = new int[comlen];

            for (int a = 0; a < comlen; ++a)
            {
                int i = commands[a, 0];
                int j = commands[a, 1];
                int k = commands[a, 2];
                int[] cArray = new int[j - i + 1];
                Array.Copy(array, i - 1, cArray, 0, j - i + 1);
                Array.Sort(cArray);
                answer[a] = cArray[k - 1];
            }
            return answer;
        }

        // 39. 두 개 뽑아서 더하기
        // 정수 배열 numbers에서 서로 다른 인덱스에 있는 두 개의 수를 뽑아 더해서 만들 수 있는
        // 모든 수를 배열에 오름차순으로 담아 return 하도록 함수 완성하기.

        // using System;
        public int[] solution39(int[] numbers)
        {
            int[] answer = { };
            int count = 0;

            for (int i = 0; i < numbers.Length; ++i)
            {
                for (int j = 0; j < numbers.Length; ++j)
                {
                    if (i == j) break;

                    int sum = numbers[i] + numbers[j];
                    int answerlen = answer.Length;
                    for (int k = 0; k < answerlen; ++k)
                    {
                        if (answer[k] == sum) break;
                        else if (k == answerlen - 1)
                        {
                            Array.Resize(ref answer, count + 1);
                            answer[count] = sum;
                            ++count;
                        }

                    }
                    if (answerlen == 0)
                    {
                        Array.Resize(ref answer, count + 1);
                        answer[count] = sum;
                        ++count;
                    }
                }
            }
            Array.Sort(answer);
            return answer;
        }
    }
}


