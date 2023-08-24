using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
@ DATE   : 2023.8.24
@ AUTHOR : 임현진
*/
namespace CodeKata_programmers
{

    internal class DAY1
    {
        // 1. 짝수 구하기
        // 정수 num이 짝수일 경우 "Even"을 반환하고 홀수인 경우 "Odd"를 반환하는 함수, solution을 완성하기.

        public string solution1(int num)
        {
            string answer = "";

            if (num % 2 == 0) answer = "Even";
            else answer = "Odd";

            return answer;
        }

        // 2. 평균 구하기
        // 정수를 담고 있는 배열 arr의 평균값을 return하는 함수, solution을 완성하기.

        public double solution2(int[] arr)
        {
            double answer = 0;
            int total = 0;

            foreach (int i in arr)
            {
                total += i;
            }

            answer = (double)total / arr.Length;
            return answer;
        }

        // 3. 자릿수 더하기
        // 자연수 N이 주어지면, N의 각 자릿수의 합을 구해서 return 하는 solution 함수를 만들어 주세요.
        // ex) N = 123 이면 1 + 2 + 3 = 6 을 반환.

        // string 변환. 잘라서 다시 int로 변환 후 바로바로 answer에 넣어주기
        public int solution3_1(int num)
        {
            int answer = 0;
            int index = 0;
            string snum = num.ToString();

            while (index < snum.Length)
            {
                answer += Convert.ToInt32(snum.Substring(index, 1));
                index++;
            }

            return answer;
        }

        // 잘라서 배열로 만든 후 foreach로 돌리며 더하기
        // 가장 처음 생각난 방법이지만 중간에 굳이? 싶어서 1로 전환
        public int solution3_2(int num)
        {
            int answer = 0;
            List<int> numlist = new List<int>();
            string snum = num.ToString();

            for (int i = 0; i < snum.Length; i++)
            {
                numlist.Add(Convert.ToInt32(snum.Substring(i, 1)));
            }

            foreach (int n in numlist)
            {
                answer += n;
            }

            return answer;
        }
    }
}
