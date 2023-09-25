using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKata_programmers
{
    /*
    @ DATE   : 2023.8.31 Thu
    @ AUTHOR : 임현진
    */
    internal class DAY06
    {
        // 10. 정수 내림차순으로 배치하기
        // 정수 n의 각 자릿수를 큰것부터 작은 순으로 정렬한 새로운 정수를 리턴하는 함수 완성하기.
        // ex) n이 118372면 873211을 리턴
        public long solution10(long n)
        {
            long answer = 0;
            string sn = n.ToString();
            int[] iarray = new int[sn.Length];
            for (int i = 0; i < sn.Length; ++i)
            {
                iarray[i] = int.Parse(sn[i].ToString());
            }
            Array.Sort(iarray);

            for (int num = 1; num < sn.Length; ++num)
            {
                answer += iarray[num] * (long)Math.Pow(10, num);
            }
            answer += iarray[0];

            return answer;
        }
    }
}
