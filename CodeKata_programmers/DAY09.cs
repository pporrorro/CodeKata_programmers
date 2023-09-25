using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKata_programmers
{
    /*
    @ DATE   : 2023.9.5 Tue
    @ AUTHOR : 임현진
    */
    internal class DAY09
    {
        // 14. 서울에서 김서방 찾기
        // String형 배열 seoul의 element중 "Kim"의 위치 x를 찾아, "김서방은 x에 있다"는 String을 반환하는 함수 완성하기.
        // seoul에 "Kim"은 오직 한 번만 나타나며 잘못된 값이 입력되는 경우는 없습니다.

        public string solution14(string[] seoul)
        {
            string answer = "";
            int index = 0;

            foreach (string str in seoul)
            {
                if (str == "Kim") break;
                ++index;
            }

            answer += "김서방은 " + index + "에 있다";
            return answer;
        }

        // 15. 나누어 떨어지는 숫자 배열
        // array의 각 element 중 divisor로 나누어 떨어지는 값을 오름차순으로 정렬한 배열을 반환하는 함수 완성하기.
        // divisor로 나누어 떨어지는 element가 하나도 없다면 배열에 -1을 담아 반환.

        //using System;
        public int[] solution15(int[] arr, int divisor)
        {
            int[] answer = new int[arr.Length];
            int index = 0;

            foreach (int num in arr)
            {
                if (num % divisor == 0)
                {
                    answer[index] = num;
                    ++index;
                }
            }

            if (answer[0] == 0)
            {
                answer[0] = -1;
                ++index;
            }
            Array.Resize(ref answer, index);
            Array.Sort(answer);
            return answer;
        }

    }
}
