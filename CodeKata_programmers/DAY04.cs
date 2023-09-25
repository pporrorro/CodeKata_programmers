using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKata_programmers
{
    /*
    @ DATE   : 2023.8.29 Tue
    @ AUTHOR : 임현진
    */
    internal class DAY04
    {
        // 7. 자연수 뒤집어 배열로 만들기
        // 자연수 n을 뒤집어 각 자리 숫자를 원소로 가지는 배열 형태로 리턴하는 함수 완성하기.
        // ex) n이 12345이면 [5,4,3,2,1]을 리턴.

        public int[] solution7(long n)
        {
            string sn = n.ToString();
            int[] answer = new int[sn.Length];

            for (int i = 0; i < sn.Length; i++)
            {
                answer[i] = Convert.ToInt32(sn[i].ToString());
            }
            Array.Reverse(answer);

            return answer;
        }


    }
}
