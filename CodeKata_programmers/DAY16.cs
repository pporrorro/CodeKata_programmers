using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKata_programmers
{
    /*
    @ DATE   : 2023.9.14 Thu
    @ AUTHOR : 임현진
    */

    internal class DAY16
    {
        // 28. 직사각형 별찍기
        // 이 문제에는 표준 입력으로 두 개의 정수 n과 m이 주어집니다.
        // 별(*) 문자를 이용해 가로의 길이가 n, 세로의 길이가 m인 직사각형 형태를 출력해보세요.
        
        // using System;
        public class Example
        {
            public static void solution28()
            {
                String[] s;
                Console.Clear();
                s = Console.ReadLine().Split(' ');
                int a = Int32.Parse(s[0]);
                int b = Int32.Parse(s[1]);
                string str = "";

                for (int i = 0; i < b; ++i)
                {
                    for (int j = 0; j < a; ++j)
                    {
                        str += "*";
                    }
                    str += "\n";
                }

                Console.WriteLine(str);
            }
        }

        // 29. 최대공약수와 최소공배수
        // 두 수를 입력받아 두 수의 최대공약수와 최소공배수를 반환하는 함수 완성하기.
        // 배열의 맨 앞에 최대공약수, 그다음 최소공배수를 넣어 반환하면 됩니다.
        // 예를 들어 두 수 3, 12의 최대공약수는 3, 최소공배수는 12이므로
        // olution(3, 12)는 [3, 12]를 반환해야 합니다.
        public int[] solution29(int n, int m)
        {
            int[] answer = new int[2];
            int maxnum = n;
            int minnum = m;

            // 뒤에 입력된 수가 더 클 경우 대비
            if (m > n)
            {
                maxnum = m;
                minnum = n;
            }

            for (int i = maxnum; i >= 1; --i)
            {
                if (minnum % i == 0 && maxnum % i == 0)
                {
                    answer[0] = i;
                    break;
                }
            }

            if (maxnum % minnum == 0) answer[1] = maxnum;
            else
            {
                int j = maxnum;
                while (true)
                {
                    if (j % minnum == 0) break;
                    j += maxnum;
                }

                answer[1] = j;
            }
            return answer;
        }

    }
}
