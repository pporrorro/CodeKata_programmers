using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKata_programmers
{
    internal class DAY10
    {
        /*
        @ DATE   : 2023.9.6 Wed
        @ AUTHOR : 임현진
        */

        // 16. 음양 더하기  - 속도가 조금 걸리긴 함
        // 어떤 정수들의 절댓값을 차례대로 담은 정수 배열 absolutes와 이 정수들의 부호를 차례대로 담은 불리언 배열 signs가 매개변수로 주어집니다.
        // 실제 정수들의 합을 구하여 return 하도록 함수 완성하기.
        public int solution16(int[] absolutes, bool[] signs)
        {
            int answer = 0;

            for (int i = 0; i < absolutes.Length; ++i)
            {
                if (!signs[i]) answer -= absolutes[i];
                else answer += absolutes[i];
            }
            
            return answer;
        }

        // 17. 핸드폰 번호 가리기
        // 전화번호가 문자열 phone_number로 주어졌을 때, 뒷 4자리를 제외한 나머지 숫자를 전부* 으로 가린 문자열을 리턴하는 함수 완성하기.
        public string solution17(string phone_number)
        {
            string answer = "";
            int phone_numberLen = phone_number.Length;

            for (int i = 0; i < phone_numberLen - 4; ++i)
            {
                answer += "*";
            }
            answer += phone_number.Substring(phone_numberLen - 4, 4);
            return answer;
        }

        // 18. 없는 숫자 더하기
        // 0부터 9까지의 숫자 중 일부가 들어있는 정수 배열 numbers에서 찾을 수 없는 0부터 9까지의 숫자를 모두 찾
        // 더한 수를 return 하도록 함수 완성하기.
        public int solution18(int[] numbers)
        {
            int answer = 45;

            for (int i = 0; i < 10; ++i)
            {
                foreach (int num in numbers)
                {
                    if (num == i)
                    {
                        answer -= i;
                        break;
                    }
                }
            }

            return answer;
        }
    }
}
