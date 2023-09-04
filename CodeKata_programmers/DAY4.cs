using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKata_programmers
{
    internal class DAY4
    {
        // 7. 자연수 뒤집어 배열로 만들기
        // 

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
