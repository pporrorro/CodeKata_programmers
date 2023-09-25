using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKata_programmers
{
    /*
    @ DATE   : 2023.9.15 Fri
    @ AUTHOR : 임현진
    */

    internal class DAY17
    {
        // 30. 3진법 뒤집기
        // 자연수 n을 3진법 상에서 앞뒤로 뒤집은 후,
        // 이를 다시 10진법으로 표현한 수를 return 하는 함수 완성하기.
        public long solution30(int n)
        {
            long answer = 0;
            string reverse3 = "";

            while (n >= 3)
            {
                if (n % 3 == 0) reverse3 += " ";
                else reverse3 += $"{n % 3}";
                n /= 3;
            }
            if (n < 3) reverse3 += $"{n}";

            reverse3 = reverse3.TrimStart();
            int len3 = reverse3.Length;
            long icount = 1;

            for (int i = len3 - 1; i >= 0; --i)
            {
                string str = Convert.ToString(reverse3[i]);
                if (str == " ") str = "0";
                answer += Convert.ToInt32(str) * icount;
                icount *= 3;
            }
            return answer;
        }
    }
}
