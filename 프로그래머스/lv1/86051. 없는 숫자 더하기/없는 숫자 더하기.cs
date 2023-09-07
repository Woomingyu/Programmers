using System;
using System.Linq; //sum사용

public class Solution {
    public int solution(int[] numbers) {
        int answer = -0;
        //1~10까지의 값 합산 answer에 넣어줌 
        for(int i = 0; i < 10; i++)
        {
            answer += i;
        }
        //answer에 numbers배열의 모든값을 더한만큼 빼줌
        answer -= numbers.Sum();
        return answer;
    }
}