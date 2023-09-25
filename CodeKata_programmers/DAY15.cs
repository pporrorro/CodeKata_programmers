using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKata_programmers
{
    /*
    @ DATE   : 2023.9.13 Wed
    @ AUTHOR : 임현진
    */

    internal class DAY15
    {
        // 25. 부족한 금액 계산하기
        // 새로 생긴 놀이기구의 인기가 많아 원래 이용료는 price원 인데
        // N 번 째 이용한다면 원래 이용료의 N배를 받기로 하였습니다.
        // 즉, 처음 이용료가 100이었다면 2번째에는 200, 3번째에는 300으로 요금이 인상됩니다.
        // 놀이기구를 count번 타게 되면 현재 자신이 가지고 있는 금액에서 얼마가 모자라는지를 return 하는 함수 완성하기.
        // 단, 금액이 부족하지 않으면 0을 return.

        public long solution25(int price, int money, int count)
        {
            long currprice = 0;
            long result = 0;

            for (int i = 1; i <= count; ++i)
            {
                currprice += price * i;
            }
            if (currprice > money) result = currprice - money;

            return result;
        }

        // 26. 문자열 다루기 기본
        // 문자열 s의 길이가 4 혹은 6이고, 숫자로만 구성돼있는지 확인해주는 함수 완성하기.
        // 예를 들어 s가 "a234"이면 False를 리턴하고 "1234"라면 True를 리턴하면 됩니다.

        // using System;
        public bool solution26(string s)
        {
            bool answer = true;

            if (s.Length == 4 || s.Length == 6) ;
            else answer = false;

            foreach (char ch in s)
            {
                if (48 > Convert.ToInt32(ch) || Convert.ToInt32(ch) > 57)
                {
                    answer = false;
                    break;
                }
            }

            return answer;
        }

        // 27. 행렬의 덧셈
        // 행과 열의 크기가 같은 두 행렬의 같은 행, 같은 열의 값을 서로 더한 결과가 됩니다.
        // 2개의 행렬 arr1과 arr2를 입력받아, 행렬 덧셈의 결과를 반환하는 함수 완성하기.

        public int[,] solution27(int[,] arr1, int[,] arr2)
        {
            int index1 = arr1.GetLength(0);
            int index2 = arr1.GetLength(1);
            int[,] answer = new int[index1, index2];

            for (int i = 0; i < index1; ++i)
            {
                for (int j = 0; j < index2; ++j)
                {
                    answer[i, j] = arr1[i, j] + arr2[i, j];
                }
            }

            return answer;
        }
    }
}
