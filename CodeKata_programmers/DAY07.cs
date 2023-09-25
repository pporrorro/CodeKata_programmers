using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKata_programmers
{
    /*
    @ DATE   : 2023.9.1 Fri
    @ AUTHOR : 임현진
    */

    internal class DAY07
    {
        // 11. 하샤드 수
        // 양의 정수 x 가 하샤드 수이려면 x의 자릿수의 합으로 x가 나누어져야 합니다.
        // ex) 18의 자릿수 합은 1+8=9이고, 18은 9로 나누어 떨어지므로 18은 하샤드 수.
        // 자연수 x를 입력받아 x가 하샤드 수인지 아닌지 검사하는 함수 완성하기.
        static bool solution11(int x)
        {
            bool answer = true;
            string strx = x.ToString();
            int totalsum = 0;

            for (int i = 0; i < strx.Length; i++)
            {
                totalsum += Convert.ToInt32(strx[i].ToString());
            }

            if (x % totalsum != 0) answer = false;

            return answer;
        }
    }
}
