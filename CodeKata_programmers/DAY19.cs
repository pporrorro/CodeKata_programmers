using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKata_programmers
{
    /*
    @ DATE   : 2023.9.19 Tue
    @ AUTHOR : 임현진
    */

    internal class DAY19
    {
        // 32. 삼총사
        // 한국중학교에 다니는 학생들은 각자 정수 번호를 갖고 있습니다.
        // 3명의 정수 번호를 더했을 때 0이 되면 3명의 학생은 삼총사라고 합니다.
        // 예를 들어, 5명의 학생이 있고, 각각의 정수 번호가 순서대로 -2, 3, 0, 2, -5일 때, 첫 번째, 세 번째, 네 번째 학생의 정수 번호를 더하면 0이므로 세 학생은 삼총사입니다.
        // 또한, 두 번째, 네 번째, 다섯 번째 학생의 정수 번호를 더해도 0이므로 세 학생도 삼총사입니다. 따라서 이 경우 한국중학교에서는 두 가지 방법으로 삼총사를 만들 수 있습니다.

        // 학생들의 번호를 나타내는 정수 배열 number가 매개변수로 주어질 때, 학생들 중 삼총사를 만들 수 있는 방법의 수를 return 하도록 함수 완성하기.

        public int solution32(int[] number)
        {
            int answer = 0;

            for (int one = 0; one < number.Length; ++one)
            {
                for (int two = 0; two < number.Length; ++two)
                {
                    if (one == two) continue;
                    for (int three = 0; three < number.Length; ++three)
                    {
                        if (one == three || two == three) continue;
                        else if (number[one] + number[two] + number[three] == 0) ++answer;
                    }
                }
            }
            // 같은 조합이 순서만 바뀌는 경우의 수로 나누어 줌
            return answer / 6;
        }

        // 33. 크기가 작은 부분 문자열
        // 숫자로 이루어진 문자열 t에서 p와 길이가 같은 부분문자열 중에서, 이 부분문자열이 나타내는 수가 p가 나타내는 수보다 작거나 같은 것이 나오는 횟수를 return하는 함수 완성하기.
        // 예를 들어, t = "3141592"이고 p = "271" 인 경우, t의 길이가 3인 부분 문자열은 314, 141, 415, 159, 592입니다.이 문자열이 나타내는 수 중 271보다 작거나 같은 수는 141, 159 2개 입니다.

        // using System;

        public int solution33(string t, string p)
        {
            int answer = 0;
            int tlen = t.Length;
            int plen = p.Length;

            for (int i = 0; i <= tlen - plen; ++i)
            {
                int index = i;
                for (int j = 0; j < plen; ++j)
                {
                    int p1 = Convert.ToInt32(Convert.ToString(p[j]));
                    int t1 = Convert.ToInt32(t.Substring(index, 1));

                    if (t1 < p1)
                    {
                        ++answer;
                        break;
                    }
                    else if (t1 > p1) break;

                    if (index == i + plen - 1) ++answer;
                    ++index;
                }
            }
            return answer;
        }


    }
}
