using System;

public class Solution {
    public int solution(int[] number) {
        //각 학생들(number)이 있는데, 배열에서 3가지 요소를 더하였때, 0을 만들수 있는 경우의 수를 구하여야 함
        //각 정수는 -, 0 이 포함되었다.
        //number의 길이는 최소 3이상이므로 3개의 반복문을 사용하여도 좋다.
        
        int answer = 0;
        
        //i를 기준으로 배열의 모든 요소를 체크한다.
        for (int i = 0; i < number.Length; i++)
        {
            //i는 확인 했으므로 그 다음 순서
            for (int j = i + 1; j < number.Length; j++)
            {
                //j는 확인 했으므로 그 다음 순서
                for (int k = j + 1; k < number.Length; k++)
                {
                    //이러면 i에서 j와 k번째의 모든값을 더해보고, [i]의 j에서는 k의 모든 값을 더해볼 수 있다.
                    if (number[i] + number[j] + number[k] == 0)
                        answer++;
                }
            }
        }
        return answer;
    }
}