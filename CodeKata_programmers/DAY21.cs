using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKata_programmers
{
    internal class DAY21
    {
        /*
        @ DATE   : 2023.9.21 Thu
        @ AUTHOR : 임현진
        */

        // 36. 숫자 문자열과 영단어
        // 다음은 숫자의 일부 자릿수를 영단어로 바꾸는 예시입니다.
        // 1478 → "one4seveneight" 234567 → "23four5six7" 10203 → "1zerotwozero3"
        // 이렇게 숫자의 일부 자릿수가 영단어로 바뀌어졌거나, 혹은 바뀌지 않고 그대로인 문자열 s가 의미하는 원래 숫자를 return 하도록 함수 완성하기.
        
        // using System;

        public long solution36(string s)
        {
            long answer = 0;
            string sanswer = "";
            string[] alphabet = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            for (int i = 0; i < s.Length; ++i)
            {
                string ch = Convert.ToString(s[i]);
                if (int.TryParse(ch, out int ich)) sanswer += ch;
                else
                {
                    for (int j = 0; j < alphabet.Length; ++j)
                    {
                        string str = alphabet[j];
                        if (str.Length > s.Length - i) continue;
                        string sstr = s.Substring(i, str.Length);

                        if (String.Equals(str, sstr))
                        {
                            sanswer += $"{j}";
                            i += str.Length - 1;
                            break;
                        }
                    }
                }
            }
            answer = int.Parse(sanswer);
            return answer;
        }




    }
}
